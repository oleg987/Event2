using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev
{
    public interface ISubscriber
    {
        string Name { get; set; }

        void Update(object sender, EventArgs e);
    }
}
