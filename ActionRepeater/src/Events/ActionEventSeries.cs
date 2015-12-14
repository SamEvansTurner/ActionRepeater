using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ActionRepeater
{
    public class ActionEventSeries
    {

        private static ActionEventSeries instance;

        private List<ActionEvent> events = new List<ActionEvent>();
        public List<ActionEvent> Events
        {
            get { return events; }
            set { events = value; }
        }

        private int mSpeed = 18;
        public int MSpeed
        {
            get { return mSpeed; }
            set { mSpeed = value; }
        }


        private ActionEventSeries()
        {

        }

        public static ActionEventSeries GetInstance()
        {
            if (instance == null)
            {
                instance = new ActionEventSeries();
            }
            
            return instance;
        }
      
        public void PlayEvents()
        {
            for (int i = 0; i < events.Count; i ++)
            {
                events[i].ProcessEvent();
            }
        }

        public void ClearEvents()
        {
            events.Clear();
        }

        public void RemoveEvent(int index)
        {
            events.RemoveAt(index);
        }

        public ActionEvent GetEvent(int index)
        {
            return events[index];
        }

        public void InsertEvent(int index, ActionEvent ev)
        {
            events.Insert(index, ev);
        }

        public void AddEvent(ActionEvent ev)
        {
            events.Add(ev);
        }

        public void SaveToFile(String filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlSerializer ser = new XmlSerializer(typeof(ActionEventSeries));
            ser.Serialize(fs, instance);

            

            fs.Flush();
            fs.Close();
            fs.Dispose();
        }

        public static void LoadFromFile(String filename)
        {
            FileStream fs;
            try
            {
                fs = new FileStream(filename, FileMode.Open);
            }
            catch (System.IO.FileNotFoundException)
            {
                return;
            }

            XmlSerializer ser = new XmlSerializer(typeof(ActionEventSeries));
            instance = (ActionEventSeries)ser.Deserialize(fs);

            fs.Flush();
            fs.Close();
            fs.Dispose();
        }

    }
}
