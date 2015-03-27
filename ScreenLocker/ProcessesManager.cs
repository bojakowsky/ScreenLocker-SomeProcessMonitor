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
        public int coding;
        public int gaming;
        public int others;

        public string[] pCoding;
        public string[] pGaming;
        public string[] pOthers;
        public ProcessesManager()
        {
            coding = gaming = others = 0;
            pCoding = new string[30];
            fillArray(pCoding);
            pGaming = new string[30];
            fillArray(pGaming);
            pOthers = new string[30];
            fillArray(pOthers);
        }

        private void fillArray(string [] s)
        {
            for (int i = 0 ; i < s.Length ; i++)
                s[i] = "" ;
        }

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
 
    }
}
