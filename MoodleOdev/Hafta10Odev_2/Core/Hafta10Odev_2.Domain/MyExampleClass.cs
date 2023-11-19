using Hafta10Odev_2.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta10Odev_2.Domain
{
    public class MyExampleClass
    {
        private readonly IConfigurationService _configurationService;

        public MyExampleClass(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }
        
    }
}
