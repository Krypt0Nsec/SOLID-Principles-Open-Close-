using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOdev
{
    public class JsonLog : Log
    {
        public override string LogWrite()
        {
            return LogType.Json.ToString();
        }
    }
}
