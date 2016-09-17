using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhone.Infrastructure
{
    public interface IConfig
    {
        string Retrieve(string key);
    }
}
