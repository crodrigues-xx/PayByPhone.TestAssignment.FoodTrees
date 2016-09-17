using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhone.Infrastructure
{
    public class WebConfig : IConfig
    {
        public string Retrieve(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
