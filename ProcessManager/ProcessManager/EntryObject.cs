using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessManager
{
    public class EntryObject
    {
        public EntryObject() 
        { 
        
        }
        public EntryObject(string exe, int Priority, List<bool> CPUaffinity, bool KillProcess, bool DoEditOperation) 
        {
            Executable = exe;
            ProcessPriority = Priority;
            CPUAffinity = CPUaffinity;
            KillProcessFlag = KillProcess;
            DoEdit = DoEditOperation;
        }
        public string Executable { get; set; }
        public int ProcessPriority { get; set; }
        public List<bool> CPUAffinity { get; set; }
        public bool KillProcessFlag { get; set; }
        public bool DoEdit { get; set; }
    }
}
