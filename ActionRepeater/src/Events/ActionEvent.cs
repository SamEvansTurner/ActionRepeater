using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroRecorder
{
    class ActionEvent
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

        private String keys;
        public String Keys
        {
            get { return keys; }
            set { keys = value; }
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


        public ActionEvent(String keysToSend)
        {
            eventType = EventTypes.Keys;
            keys = keysToSend;
        }

        public ActionEvent(int msToWait)
        {
            eventType = EventTypes.Wait;
            waitTimeMS = msToWait;
        }

        public ActionEvent(Point dest, int randx, int randy, int mSpeed)
        {
            eventType = EventTypes.MouseMove;
            destination = dest;
            mouseSpeed = mSpeed;
        }

        public ActionEvent(int x, int y, int randx, int randy, int mSpeed)
        {
            eventType = EventTypes.MouseMove;
            destination.X = x;
            destination.Y = y;
            mouseSpeed = mSpeed;
        }

        public ActionEvent(MouseButton mb)
        {
            eventType = EventTypes.MouseButton;
            mButton = mb;
        }

        public void ProcessEvent()
        {
            switch (eventType)
            {
                case EventTypes.Keys:
                    SendKeys.SendWait(keys);
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
                    MouseMover.MoveMouse(destination.X, destination.Y, destRand.X, destRand.Y, mouseSpeed);
                    break;
                case EventTypes.Wait:
                    System.Threading.Thread.Sleep(waitTimeMS);
                    break;
            }
        }
        
    }
}
