using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Task2
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {HasSidecar}");
        }
    }
}
