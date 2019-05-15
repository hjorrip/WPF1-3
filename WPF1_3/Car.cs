using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1_3
{

    public class CarInfo
    {
        public Car[] results { get; set; }
    }

    public class Car
    {
        public string type { get; set; }
        public string subType { get; set; }
        public string color { get; set; }
        public string registryNumber { get; set; }
        public string number { get; set; }
        public string factoryNumber { get; set; }
        public string registeredAt { get; set; }
        public string pollution { get; set; }
        public string weight { get; set; }
        public string status { get; set; }
        public string nextCheck { get; set; }
    }

}
