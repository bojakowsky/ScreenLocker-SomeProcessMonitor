using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenLocker
{
    public class ProcessesManager
    {
        private int coding;
        private int gaming;
        private int others;

        private string[] pCoding;
        private string[] pGaming;
        private string[] pOthers;
        public ProcessesManager()
        {
            coding = gaming = others = 0;
            pCoding = new string[] { "devenv", "eclipse" };
            pGaming = new string[] { "csgo", "steam" };
            pOthers = new string[] { "chrome", "firefox" };
        }

        //public void addProcess(); 
        //ToDo
        
        public void checkStates()
        {
            //var codingProcesses = GetProcesses(new[] { "devenv","eclipse" });
            //var gamingProcesses = GetProcesses(new[] { "csgo", "steam" });
            //var othersProcesses = GetProcesses(new[] { "firefox", "chrome" });
            var codingProcesses = GetProcesses(pCoding);
            var gamingProcesses = GetProcesses(pGaming);
            var othersProcesses = GetProcesses(pOthers);
            if (codingProcesses.Count > 0) coding++;
            if (gamingProcesses.Count > 0) gaming++;
            if (othersProcesses.Count > 0) others++;
            
        }

        public static IList<Process> GetProcesses(string[] processNames)
        {
            var processes = new List<Process>(processNames.Length);
            foreach (var processName in processNames)
            {
                var namedProcesses = Process.GetProcessesByName(processName);
                processes.AddRange(namedProcesses);
            }

            return processes;
        }

        public int codingGetter()
        {
            return coding;
        }

        public int gamignGetter()
        {
            return gaming;
        }

        public int othersGetter()
        {
            return others;
        }

    }
}
