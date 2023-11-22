using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diagrams.Behaviour_pattern
{
   
    public class Editor
    {
        public EventManager events { get; set; }
        public Editor() { }

        public void openFile() { }
        public void saveFile() { }

    }

    public class EventManager
    {
        private EventListeners listeners { get; set; }


        public void subscribe(EventListeners eventType,EventListeners listeners)
        {

        }

        public void unsubscribe(EventListeners eventType, EventListeners listeners)
        {

        }

        public void notify(EventListeners eventType, EventListeners listeners)
        {

        }


    }

    public interface EventListeners
    {
        public void update(string filename);
    }

    public class EmailAlertsListener : EventListeners
    {
        public void update(string filename)
        {
           //
        }
    }
    public class LoggingListener : EventListeners
    {
        public void update(string filename)
        {
            //
        }
    }


}
