using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActionRepeater
{
    public class ActionEvent
    {
        public enum EventTypes
        {
            Wait,
            MouseMove,
            Keys,
            MouseButton
        }

        public enum MouseButton
        {
            Left,
            Right
        }

        private EventTypes eventType;
        public EventTypes EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }

        private InputImports.VirtualKeyShort key = InputImports.VirtualKeyShort.LBUTTON;
        public InputImports.VirtualKeyShort Key
        {
            get { return key; }
            set { key = value; }
        }

        private int waitTimeMS;
        public int WaitTimeMS
        {
            get { return waitTimeMS; }
            set { waitTimeMS = value; }
        }

        private MouseButton mButton;
        public MouseButton MButton
        {
            get { return mButton; }
            set { mButton = value; }
        }

        private Point destination;
        public Point Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        private Point destRand;
        public Point DestRand
        {
            get { return destRand; }
            set { destRand = value; }
        }

        private int mouseSpeed;
        public int MouseSpeed
        {
            get { return mouseSpeed; }
            set { mouseSpeed = value; }
        }

        private bool relative;
        public bool Relative
        {
            get { return relative; }
            set { relative = value; }
        }


        public ActionEvent(InputImports.VirtualKeyShort keysToSend)
        {
            eventType = EventTypes.Keys;
            key = keysToSend;
        }

        public ActionEvent(int msToWait)
        {
            eventType = EventTypes.Wait;
            waitTimeMS = msToWait;
        }

        public ActionEvent(Point dest, int randx, int randy, int mSpeed, bool rel)
        {
            eventType = EventTypes.MouseMove;
            destination = dest;
            destRand.X = randx;
            destRand.Y = randy;
            mouseSpeed = mSpeed;
            relative = rel;
        }

        public ActionEvent(int x, int y, int randx, int randy, int mSpeed, bool rel)
        {
            eventType = EventTypes.MouseMove;
            destination.X = x;
            destination.Y = y;
            destRand.X = randx;
            destRand.Y = randy;
            mouseSpeed = mSpeed;
            relative = rel;
        }

        public ActionEvent(MouseButton mb)
        {
            eventType = EventTypes.MouseButton;
            mButton = mb;
        }

        private ActionEvent()
        {

        }

        public void ProcessEvent()
        {
            switch (eventType)
            {
                case EventTypes.Keys:
                    InputImports.SendKey(key);
                    break;
                case EventTypes.MouseButton:
                { 
                    switch (mButton)
                    {
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
                    if(relative)
                    {
                        Point pos = Cursor.Position;
                        pos.X += destination.X;
                        pos.Y += destination.Y;
                        MouseMover.MoveMouse(pos.X, pos.Y, destRand.X, destRand.Y, mouseSpeed);
                    }
                    else
                    {
                        MouseMover.MoveMouse(destination.X, destination.Y, destRand.X, destRand.Y, mouseSpeed);
                    }
                    
                    break;
                case EventTypes.Wait:
                    System.Threading.Thread.Sleep(waitTimeMS);
                    Random rnd = new Random();
                    int wait = rnd.Next(100);
                    System.Threading.Thread.Sleep(wait);
                    break;
            }
        }
        
    }
}
