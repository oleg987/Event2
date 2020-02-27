using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev
{
    public class Publisher : IPublisher
    {
        public string Name { get; set; }
        public List<ISubscriber> Subscribers { get; set; } = new List<ISubscriber>();
        private EventHandler _del;
        private int count = 0;

        public IEnumerable<Delegate> SubList;


        public Publisher(string name)
        {
            Name = name;
            SubList = _del.GetInvocationList();
        }

        public event EventHandler OnStore
        {
            add
            {
                count++;
                _del += value;
                Subscribers.Add((ISubscriber)value.Target);
            }
            remove
            {
                count--;
                _del -= value;
                Subscribers.Remove((ISubscriber)value.Target);
            }
        }

        public void Store(string data)
        {
            Storage.Data = data;

            _del?.Invoke(this, EventArgs.Empty);
        }
    }
}
