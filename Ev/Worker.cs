using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev
{
    public class Worker : ISubscriber
    {
        public string Name { get; set; }
        private string command;

        public Worker(string name, IPublisher publisher)
        {
            Name = name;
            publisher.OnStore += Update;
        }

        public void Update(object sender, EventArgs e)
        {
            command = Storage.Data;

            DoWork();
        }

        private void DoWork()
        {
            switch (command.ToLower().Trim())
            {
                case "start":
                    Console.WriteLine($"{Name} start work!");
                    break;
                case "finish":
                    Console.WriteLine($"{Name} finish work!");
                    break;
            }
        }
    }
}
