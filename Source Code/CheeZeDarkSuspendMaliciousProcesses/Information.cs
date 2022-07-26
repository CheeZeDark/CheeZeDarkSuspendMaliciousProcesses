using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CheeZeDarkSuspendMaliciousProcesses
{
    class Infor
    {
       public bool Readme()
        {
            if (!File.Exists(@"C:\Windows\System32\kal.exe"))
            {
                File.WriteAllText(@"C:\Temp\Readme.txt", "Thank U For Downloading This Library... Made By CheeZeDark");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
