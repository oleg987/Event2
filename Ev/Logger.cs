using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev
{
    class Logger : ISubscriber
    {
        public string Name { get; set; }
        public Dictionary<DateTime, string> History { get; set; }

        public Logger(string name, IPublisher publisher)
        {
            Name = name;

            History = new Dictionary<DateTime, string>();

            publisher.OnStore += Update;
        }

        public void Update(object sender, EventArgs e)
        {
            History.Add(DateTime.Now, $"Name: {((IPublisher)sender).Name}  Data: {Storage.Data}");
        }

        public override string ToString()
        {
            string result = "";

            foreach (var item in History)
            {
                result += $"{item.Key}\t{item.Value}\n";
            }

            return result;
        }
    }
}
