using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOdev
{
    public class XmlLog : Log
    {
        //public bool Log(string value)
        //{
        //    //islemler
        //    Console.WriteLine(value + " xml e kaydedildi");
        //    return true;
        //}
        
        public override string LogWrite()
        {
            return LogType.Xml.ToString();
        }
    }
}
