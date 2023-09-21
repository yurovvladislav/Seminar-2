using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace Seminar_2
{
    internal class Writer
    {
        static void Write(string login, string password, string adress) 
        {
            //запись в файл
            StreamWriter sw=new StreamWriter(adress);
            sw.Write(login+" "+password);
            sw.Close();
        }
    }
}
