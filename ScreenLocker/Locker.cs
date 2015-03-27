using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Threading;

namespace ScreenLocker
{
    public partial class Locker : Form
    {
 
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }


        //System level functions to be used for hook and unhook keyboard input
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);



        //Declaring Global objects
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;
        bool lockerIsActive;

        public Locker()
        {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
            lockerIsActive = true;

            InitializeComponent();
        }

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        
        {
            if (nCode >= 0 && lockerIsActive)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));


                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Escape || objKeyInfo.key == Keys.Delete ||
                    objKeyInfo.key == Keys.Alt || objKeyInfo.key == Keys.F4 || objKeyInfo.key == Keys.RControlKey ||
                    objKeyInfo.key == Keys.Tab || objKeyInfo.key == Keys.K) // Disabling Windows keys
                {
                    return (IntPtr)1;
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        void alarm()
        {
                Console.Beep(1000, 100);
        }

        
        private int attempts = 0;
        private void passwordUnlocker_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "123")
            {
                ProcessesChecker.Enabled = false;
                lockerIsActive = false;
                this.Close();
            }
            else
            {
                passwordMismatch.Text = "Password incorrect!";
                passwordMismatch.Visible = true;
                ++attempts;
                
            }
        }

        private void ProcessesChecker_Tick(object sender, EventArgs e)
        {
            Process[] taskmanager = Process.GetProcessesByName("taskmgr");
            if (taskmanager.Length != 0)
            {
                taskmanager[0].Kill();
                passwordMismatch.Text = "Don't try to cheat me!";
                passwordMismatch.Visible = true;
                
            }
            string subtime = string.Format("Time: {0:t}",(DateTime.Now.TimeOfDay)).ToString().Substring(0,14);
            ClockTextBox.Text = subtime;
            DayLabel.Text = string.Format("Date: {0:d}", DateTime.Now.Date).ToString().Substring(0, 16);

            if (attempts >= 3)
            {
                alarm();
            }
        }

        private void Locker_Load(object sender, EventArgs e)
        {

        }
    }
}
