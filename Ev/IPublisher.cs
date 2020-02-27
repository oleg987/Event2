using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev
{
    public interface IPublisher
    {
        string Name { get; set; }

        event EventHandler OnStore;

        void Store(string data);
    }
}
