using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    internal class Players
    {
        public string Name { get; set; }
        public ushort Score { get; set; }
        public bool Status { get; set; }
        public Players(string name)
        {
            Name = name;
            Score = 0;
            Status = false;
        }
    }
}
