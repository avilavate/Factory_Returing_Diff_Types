using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Returing_Diff_Types.Types
{
    class Radio : IElectronics
    {
        public string CircuirError { get; set; }
        public void Tune()
        {
            Console.WriteLine("Radio Tuning");
        }
    }
}
