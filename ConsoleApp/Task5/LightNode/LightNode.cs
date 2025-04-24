namespace ConsoleApp.Task5.LightNode
{
    public abstract class LightNode
    {

        private readonly Dictionary<string, List<IEventListener>> _eventListeners = new Dictionary<string, List<IEventListener>>();

        public void AddEventListener(string eventType, IEventListener listener)
        {
            if (!_eventListeners.ContainsKey(eventType))
            {
                _eventListeners[eventType] = new List<IEventListener>();
            }
            _eventListeners[eventType].Add(listener);
        }

        public void TriggerEvent(string eventType)
        {
            if (_eventListeners.ContainsKey(eventType))
            {
                foreach (var listener in _eventListeners[eventType])
                {
                    listener.HandleEvent(eventType);
                }
            }
        }

        public abstract string OuterHTML();
        public abstract string InnerHTML();
    }
}
