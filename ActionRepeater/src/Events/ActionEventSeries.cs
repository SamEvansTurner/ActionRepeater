using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace ActionRepeater {
    [XmlRoot("ActionEventSeries")]
    public class ActionEventSeries {

        public delegate void LoopFinished();
        private LoopFinished loopFinishedCallback;
        [XmlIgnore]
        public LoopFinished FinishedCallback {
            get { return loopFinishedCallback; }
            set { loopFinishedCallback = value; }
        }

        private static ActionEventSeries instance;

        private List<ActionEvent> before = new List<ActionEvent>();

        private List<ActionEvent> loop = new List<ActionEvent>();

        private List<ActionEvent> after = new List<ActionEvent>();
        private List<List<ActionEvent>> queues = new List<List<ActionEvent>>();

        private int iNumLoops = 1;

        [XmlIgnore]
        public List<List<ActionEvent>> EventQueues {
            get { return queues; }
            set { queues = value; }
        }
        [XmlArray("Before")]
        [XmlArrayItem("ActionEvent")]
        public List<ActionEvent> BeforeEvents {
            get { return before; }
            set { before = value; }
        }
        [XmlArray("Loop")]
        [XmlArrayItem("ActionEvent")]
        public List<ActionEvent> LoopEvents {
            get { return loop; }
            set { loop = value; }
        }
        [XmlArray("After")]
        [XmlArrayItem("ActionEvent")]
        public List<ActionEvent> AfterEvents {
            get { return after; }
            set { after = value; }
        }
        [XmlElement("Loops")]
        public int Loops {
            get { return iNumLoops; }
            set { iNumLoops = value; }
        }

        private int mSpeed = 18;
        [XmlElement("MSpeed")]
        public int MSpeed {
            get { return mSpeed; }
            set { mSpeed = value; }
        }


        private ActionEventSeries() {
            queues.Add(before);
            queues.Add(loop);
            queues.Add(after);
        }

        public static ActionEventSeries GetInstance() {
            if (instance == null) {
                instance = new ActionEventSeries();
            }

            return instance;
        }

        public void PlayEvents() {

            foreach (ActionEvent ev in before) {
                ev.ProcessEvent();
            }
            Stopwatch st = new Stopwatch();
            st.Start();
            for (int i = 0; i < iNumLoops; i++) {
                foreach (ActionEvent ev in loop) {
                    ev.ProcessEvent();
                    st.Restart();
                }
                loopFinishedCallback?.Invoke();
            }
            st.Stop();
            foreach (ActionEvent ev in after) {
                ev.ProcessEvent();
            }
        }

        public void ClearEvents(int queue) {
            queues[queue].Clear();
        }

        public void RemoveEvent(int queue, int index) {
            queues[queue].RemoveAt(index);
        }

        public ActionEvent GetEvent(int queue, int index) {
            return queues[queue][index];
        }

        public void InsertEvent(int queue, int index, ActionEvent ev) {
            queues[queue].Insert(index, ev);
        }

        public void AddEvent(int queue, ActionEvent ev) {
            queues[queue].Add(ev);
        }

        public void SaveToFile(String filename) {
            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlSerializer ser = new XmlSerializer(typeof(ActionEventSeries));
            ser.UnknownNode += new XmlNodeEventHandler(serializer_UnknownNode);
            ser.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);
            ser.UnknownElement += new XmlElementEventHandler(serializer_UnknownElement);
            ser.Serialize(fs, instance);



            fs.Flush();
            fs.Close();
            fs.Dispose();
        }

        private static void serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e) {
            throw new System.NotImplementedException();
        }

        private static void serializer_UnknownNode(object sender, XmlNodeEventArgs e) {
            throw new System.NotImplementedException();
        }

        private static void serializer_UnknownElement(object sender, XmlElementEventArgs e) {
            throw new System.NotImplementedException();
        }

        public static void LoadFromFile(String filename) {
            FileStream fs;
            try {
                fs = new FileStream(filename, FileMode.Open);
            } catch (System.IO.FileNotFoundException) {
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
