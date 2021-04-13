using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
namespace ProcessManager
{
    public class EntryData
    {
        private const string JsonData = "/Resources/Entries.json";
        private static Dictionary<string, EntryDataDetails> Entries = new Dictionary<string, EntryDataDetails>();
        public EntryData() 
        { 
        
        }
        public EntryData(string exe, int priority, List<bool> CPUaffinity) 
        {
            if (!Entries.ContainsKey(exe)) 
            {
                Entries.Add(exe, new EntryDataDetails(exe, priority, CPUaffinity));
            }
        }
        public static void Save() 
        {
            string json = JsonConvert.SerializeObject(Entries);
            File.WriteAllText(JsonData,json);
        }
        public static bool Load() 
        {
            if (File.Exists(JsonData))
            {
                string json = File.ReadAllText(JsonData);
                Entries = JsonConvert.DeserializeObject<Dictionary<string, EntryDataDetails>>(json);
                return true;
            }
            else 
            {
                return false;
            }
        }
        public static string[] GetEntryKeys() 
        {
            string[] keys = new string[Entries.Keys.Count];
            Entries.Keys.CopyTo(keys, 0);
            return keys;
        }
        public static void AddEntry(in EntryObject entryObject) 
        {
            EntryDataDetails entry = new EntryDataDetails();
            entry.Executable = entryObject.Executable;
            entry.Priority = entryObject.ProcessPriority;
            entry.CPUaffinity = entryObject.CPUAffinity;
            entry.KillProcess = entryObject.KillProcessFlag;
            Entries.Add(entry.Executable, entry);
        }
        public static void EditEntry(in EntryObject entryObject) 
        {
            EntryDataDetails temp = new EntryDataDetails();
            temp.Executable = entryObject.Executable;
            temp.Priority = entryObject.ProcessPriority;
            temp.CPUaffinity = entryObject.CPUAffinity;
            temp.KillProcess = entryObject.KillProcessFlag;
            Entries.Remove(entryObject.Executable);
            Entries.Add(temp.Executable, temp);
        }
        public static void RemoveEntry(string exe) 
        {
            Entries.Remove(exe);
        }
        public static void ManageEntries(EntryObject entryObject) 
        {
            if (Entries.ContainsKey(entryObject.Executable))
            {
                switch (entryObject.DoEdit)
                {
                    case true:
                        EditEntry(in entryObject);
                        break;
                    default:
                        RemoveEntry(entryObject.Executable);
                        //Entries.Remove(entryObject.Executable);
                        break;
                }
                
            }
            else
            {
                AddEntry(entryObject);
            }
        }
    }
    internal class EntryDataDetails 
    {
        public EntryDataDetails() 
        { 
            
        }
        public EntryDataDetails(string exe, int priority, List<bool>CPUAffinity) 
        {
            Executable = exe;
            Priority = priority;
            CPUaffinity = CPUAffinity;
        }
        public string Executable { get; set; }
        public int Priority { get; set; }
        public List<bool> CPUaffinity { get; set; }
        public bool KillProcess { get; set; }
    }
}
