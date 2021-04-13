using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ProcessManager
{
    class Logging
    {
        const string log = "/Resources/log.txt";
        public static void LogAction(DateTime date, string action, string process)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(log)))
            {
                binaryWriter.Write(date.ToUniversalTime().ToString() + ':' + action);
            }
        }
    }
}
