using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ActionRepeater {
    static class MouseMover {
        static Random random = new Random();
        static int mouseSpeed = 15;
        const int stepSleep = 5;
        const int pixPerSpeed = 5;
        const double speedBias = (double)stepSleep / pixPerSpeed;

        public static int CalcMovespeedForTime(int srcX, int srcY, int destX, int destY, int time) {
            double distance = Math.Sqrt(Math.Pow(destX - srcX, 2) + Math.Pow(destY - srcY, 2));
            double msPerPix = time/distance;
            if(msPerPix > 10) {
                msPerPix = 10;
            }
            if(msPerPix < 0.5) {
                msPerPix = 0.5;
            }
            double ratio = 5;
            double inside = (0.5 * msPerPix) - 0;
            double logParam = 17 / inside;
            double log = Math.Log(logParam);
            double funcOutput = ratio * log;
            if(Double.IsNaN(funcOutput)) {
                Console.WriteLine("" + msPerPix);
            }
            //return (int)Math.Round(funcOutput);
            return (int)Math.Round(3 + (8 / msPerPix));
        }

        public static int CalcTimeToMove(int srcX, int srcY, int destX, int destY, int mouseSpd) {
            double distance = Math.Sqrt(Math.Pow(destX - srcX, 2) + Math.Pow(destY - srcY, 2));
            double msPerPixel = 1.5 + 68 * Math.Pow(Math.E, (-0.45 * mouseSpd));
            return (int) Math.Round(distance * msPerPixel);
        }

        public static void MoveMouse(int destX, int destY, int destRandX, int destRandY) {
            Point c = new Point();
            GetCursorPos(out c);

            destX += random.Next(destRandX);
            destY += random.Next(destRandY);

            double randomSpeed = Math.Max((random.Next(mouseSpeed) / 2.0 + mouseSpeed) / 10.0, 0.1);

            double grav = (mouseSpeed / 15.0) * 9.0;
            double wind = (mouseSpeed / 15.0) * 3.0;

            
            //This roughly moves according to the function 130 + 8000*e^(-0.5*speed)
            WindMouse(c.X, c.Y, destX, destY, grav, wind, 11.0 / randomSpeed,
                12.0 / randomSpeed, 10.0 * randomSpeed, 10.0 * randomSpeed);
        }

        public static void MoveMouse(int destX, int destY, int destRandX, int destRandY, int mouseSpd) {
            int backupMs = mouseSpeed;
            mouseSpeed = mouseSpd;

            MoveMouse(destX, destY, destRandX, destRandY);

            mouseSpeed = backupMs;
        }

        static void WindMouse(double xs, double ys, double xe, double ye,
                                double gravity, double wind, double minWait, double maxWait,
                                double maxStep, double targetArea) {

            double dist, windX = 0, windY = 0, veloX = 0, veloY = 0, randomDist, veloMag, step;
            int oldX, oldY, newX = (int)Math.Round(xs), newY = (int)Math.Round(ys);

            double waitDiff = maxWait - minWait;
            double sqrt2 = Math.Sqrt(2.0);
            double sqrt3 = Math.Sqrt(3.0);
            double sqrt5 = Math.Sqrt(5.0);

            dist = Hypot(xe - xs, ye - ys);

            while (dist > 1.0) {

                wind = Math.Min(wind, dist);

                if (dist >= targetArea) {
                    int w = random.Next((int)Math.Round(wind) * 2 + 1);
                    windX = windX / sqrt3 + (w - wind) / sqrt5;
                    windY = windY / sqrt3 + (w - wind) / sqrt5;
                } else {
                    windX = windX / sqrt2;
                    windY = windY / sqrt2;
                    if (maxStep < 3)
                        maxStep = random.Next(3) + 3.0;
                    else
                        maxStep = maxStep / sqrt5;
                }

                veloX += windX;
                veloY += windY;
                veloX = veloX + gravity * (xe - xs) / dist;
                veloY = veloY + gravity * (ye - ys) / dist;

                if (Hypot(veloX, veloY) > maxStep) {
                    randomDist = maxStep / 2.0 + random.Next((int)Math.Round(maxStep) / 2);
                    veloMag = Hypot(veloX, veloY);
                    veloX = (veloX / veloMag) * randomDist;
                    veloY = (veloY / veloMag) * randomDist;
                }

                oldX = (int)Math.Round(xs);
                oldY = (int)Math.Round(ys);
                xs += veloX;
                ys += veloY;
                dist = Hypot(xe - xs, ye - ys);
                newX = (int)Math.Round(xs);
                newY = (int)Math.Round(ys);

                if (oldX != newX || oldY != newY)
                    SetCursorPos(newX, newY);

                step = Hypot(xs - oldX, ys - oldY);
                int wait = (int)Math.Round(waitDiff * (step / maxStep) + minWait);
                Thread.Sleep(wait);
            }

            int endX = (int)Math.Round(xe);
            int endY = (int)Math.Round(ye);
            if (endX != newX || endY != newY)
                SetCursorPos(endX, endY);
        }

        public static void MoveMouseLinear(int sx, int sy, int destX, int destY, int destRandX, int destRandY, int mouseSpd = 15) {
                        
            int xs = sx;
            int ys = sy;
            destX += random.Next(destRandX);
            destY += random.Next(destRandY);

            double speedOffset = mouseSpd * speedBias;
            int diffX = destX - xs;
            int diffY = destY - ys;
            double distance = Hypot(diffX, diffY);
            double velX = Math.Round((diffX / distance) * speedOffset);
            double velY = Math.Round((diffY / distance) * speedOffset);
            double distPerStep = Hypot(velX, velY);
            Console.WriteLine(xs + "," + ys + " | " + diffX + "," + diffY + " | " + velX + "," + velY + " -||- " + distance);
            while (distance > distPerStep) {
                int nextX = (int) Math.Round(xs + velX);
                int nextY = (int) Math.Round(ys + velY);
                Console.WriteLine(xs + "," + ys + " | " + diffX + "," + diffY + " | " + velX + "," + velY + " -||- " + distance);
                SetCursorPos(nextX, nextY);
                xs = Cursor.Position.X;
                ys = Cursor.Position.Y;
                diffX = destX - xs;
                diffY = destY - ys;
                velX = (int)Math.Round((diffX / distance) * speedOffset);
                velY = (int)Math.Round((diffY / distance) * speedOffset);
                distance = Hypot((double)diffX, (double)diffY);
                Console.WriteLine(xs + "," + ys + " | " + diffX + "," + diffY + " | " + velX + "," + velY + " -||- " + distance);
                Thread.Sleep(stepSleep);

            }
            if (destX != xs || destY != ys)
                SetCursorPos(destX, destY);

        }

        public static int LinearSpeedForTime(int sx, int sy, int destX, int destY, int timeMS) {
            int diffX = destX - sx;
            int diffY = destY - sy;
            double distance = Hypot(diffX, diffY);

            double timeAdjusted = timeMS / (pixPerSpeed * pixPerSpeed);
            return (int) Math.Ceiling(distance / timeAdjusted);

        }

        static double Hypot(double dx, double dy) {
            return Math.Sqrt(dx * dx + dy * dy);
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point p);
    }
}
