using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOdev
{
    public class Logger
    {
        public string Log(Log log)
        {
            return log.LogWrite();
        }



        //public XmlLog xmlLog;
        //public DbLog dbLog;

        //public Logger(XmlLog xmlLog, DbLog dbLog)
        //{
        //    this.xmlLog = xmlLog;
        //    this.dbLog = dbLog;
        //}

        //public void Log(LogType type, string value)
        //{
        //    switch (type)
        //    {
        //        case LogType.Xml:
        //            xmlLog.Log(value);
        //            break;
        //        case LogType.Db:
        //            dbLog.dbKayit(value);
        //            break;
        //    }
        //}



    }
}
