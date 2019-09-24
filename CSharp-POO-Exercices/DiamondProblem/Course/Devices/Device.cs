using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
