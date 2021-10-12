using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ActionRepeater {
    public class ActionEvent {
        public enum EventTypes {
            Wait,
            MouseMove,
            Keys,
            MouseButton
        }

        public enum MouseButton {
            Left = 0x0201,
            Right = 0x0204,
            Wheel = 0x020A,
            ControlWheel = 0x020B,
            Move = 0x00
        }

        private EventTypes eventType;
        public EventTypes EventType {
            get { return eventType; }
            set { eventType = value; }
        }

        private InputImports.VirtualKeyShort key = InputImports.VirtualKeyShort.A;
        public InputImports.VirtualKeyShort Key {
            get { return key; }
            set { key = value; }
        }

        private int waitTimeMS;
        public int WaitTimeMS {
            get { return waitTimeMS; }
            set { waitTimeMS = value; }
        }

        private MouseButton mButton = MouseButton.Move;
        public MouseButton MButton {
            get { return mButton; }
            set { mButton = value; }
        }

        private Point destination;
        public Point Destination {
            get { return destination; }
            set { destination = value; }
        }

        private Point destRand;
        public Point DestRand {
            get { return destRand; }
            set { destRand = value; }
        }

        private int mouseSpeed;
        public int MouseSpeed {
            get { return mouseSpeed; }
            set { mouseSpeed = value; }
        }

        private bool relative;
        public bool Relative {
            get { return relative; }
            set { relative = value; }
        }

        private bool linear;
        public bool Linear {
            get { return linear; }
            set { linear = value; }
        }


        public ActionEvent(InputImports.VirtualKeyShort keysToSend) {
            eventType = EventTypes.Keys;
            key = keysToSend;
        }

        public ActionEvent(int msToWait) {
            eventType = EventTypes.Wait;
            waitTimeMS = msToWait;
        }

        public ActionEvent(Point dest, int randx, int randy, int mSpeed, bool rel, bool lin=false) {
            eventType = EventTypes.MouseMove;
            destination = dest;
            destRand.X = randx;
            destRand.Y = randy;
            mouseSpeed = mSpeed;
            relative = rel;
            linear = lin;
        }

        public ActionEvent(int x, int y, int randx, int randy, int mSpeed, bool rel, bool lin=false) {
            eventType = EventTypes.MouseMove;
            destination.X = x;
            destination.Y = y;
            destRand.X = randx;
            destRand.Y = randy;
            mouseSpeed = mSpeed;
            relative = rel;
            linear = lin;
        }

        public ActionEvent(MouseButton mb) {
            eventType = EventTypes.MouseButton;
            mButton = mb;
        }

        private ActionEvent() {

        }

        public override string ToString() {
            switch (EventType) {
                case EventTypes.Wait: {
                        string str = "Wait ";
                        if (linear) {
                            str += "exactly ";
                        } else {
                            str += "roughly ";
                        }
                        str += WaitTimeMS.ToString() + " ms";
                        return str;
                    }
                case EventTypes.MouseMove: {
                        string str = "Move Mouse ";
                        if (linear) {
                            str += "linearly ";
                        }
                        if (!Relative) {
                            str += "to ";
                        }
                        str += Destination.X + ", " + Destination.Y;
                        if (Relative) {
                            str += " from the current position";
                        }
                        if (DestRand.X > 0 || DestRand.Y > 0) {
                            str += " plus a random " + DestRand.X + ", " + DestRand.Y;
                        }
                        str += " at a speed of " + MouseSpeed;

                        return str;
                    }
                case EventTypes.MouseButton: {
                        switch (MButton) {
                            case MouseButton.Left: {
                                    return "Left Click";
                                }
                            case MouseButton.Right: {
                                    return "Right Click";
                                }
                        }
                        break;
                    }
                case EventTypes.Keys: {
                        return "Send key " + Key;
                    }
                default: {
                        return "";
                    }
            }
            return "";
        }


        public void ProcessEvent() {
            switch (eventType) {
                case EventTypes.Keys:
                    InputImports.SendKey(key);
                    break;
                case EventTypes.MouseButton: {
                        switch (mButton) {
                            case MouseButton.Left:
                                InputImports.ClickLeftMouseButton();
                                break;
                            case MouseButton.Right:
                                InputImports.ClickRightMouseButton();
                                break;
                        }
                        break;
                    }
                case EventTypes.MouseMove:
                    if (relative) {
                        Point pos = Cursor.Position;
                        pos.X += destination.X;
                        pos.Y += destination.Y;
                        if(linear) {
                            MouseMover.MoveMouseLinear(Cursor.Position.X, Cursor.Position.Y, pos.X, pos.Y, destRand.X, destRand.Y, mouseSpeed);
                        } else {
                            MouseMover.MoveMouse(pos.X, pos.Y, destRand.X, destRand.Y, mouseSpeed);
                        }
                        
                    } else {
                        if(linear) {
                            MouseMover.MoveMouseLinear(Cursor.Position.X, Cursor.Position.Y, destination.X, destination.Y, destRand.X, destRand.Y, mouseSpeed);
                        } else {
                            MouseMover.MoveMouse(destination.X, destination.Y, destRand.X, destRand.Y, mouseSpeed);
                        }
                    }

                    break;
                case EventTypes.Wait:
                    Thread.Sleep(waitTimeMS);
                    if (!linear) {
                        Random rnd = new Random();
                        int wait = rnd.Next(100);
                        Thread.Sleep(wait);
                    }
                    
                    break;
            }
        }

    }
}
