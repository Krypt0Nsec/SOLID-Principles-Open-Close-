using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOdev
{
    public class DbLog : Log
    {
        //public bool dbKayit(string value)
        //{
        //    //islemler
        //    Console.WriteLine(value + "database e kaydedildi");
        //    return true;
        //}





        public override string LogWrite()
        {
            return LogType.Db.ToString();
        }
    }
}
