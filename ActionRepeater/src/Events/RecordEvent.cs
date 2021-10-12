namespace ActionRepeater.src.Events {
    class RecordEvent {
        public enum EventTypes {
            Keys,
            MouseButton
        }

        private EventTypes eventType;
        public EventTypes EventType {
            get { return eventType; }
            set { eventType = value; }
        }

    }
}
