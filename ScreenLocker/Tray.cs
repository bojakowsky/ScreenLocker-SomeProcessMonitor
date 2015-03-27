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

namespace ScreenLocker
{
    public partial class Tray : Form
    {
        private ProcessesManager Pm;
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        KeyboardHook hook = new KeyboardHook();
        KeyboardHook hookA = new KeyboardHook();
        private bool isStatOpen;
        private Stats statsWindow;
        bool isOptionOpened = false;
        public Tray()
        {
            InitializeComponent();
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Tray manager", manageTray);
            trayMenu.MenuItems.Add("Alt+K  -  Locker");
            trayMenu.MenuItems.Add("Alt+I  -  Stats");
            trayMenu.MenuItems.Add("Exit", onExit);
            

            trayIcon = new NotifyIcon();
            trayIcon.Text = "Locker";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);

            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            // register the event that is fired after the key press.
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            hook.RegisterHotKey(ScreenLocker.ModifierKeys.Alt, Keys.K);

            hookA.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hookA_KeyPressed);
            hookA.RegisterHotKey(ScreenLocker.ModifierKeys.Alt, Keys.I);
            statsWindow = new Stats();

            Pm = new ProcessesManager();
            try
            {
                ReadXML();
            }
            catch (Exception)
            {
                WriteXML();
            }
            isStatOpen = false;
        }

        void hookA_KeyPressed(object sender, KeyPressedEventArgs e)
        {

            if (!isStatOpen)
            {
                isStatOpen = true;
                statsWindow.SetStats(Pm.coding, Pm.gaming, Pm.others);
                statsWindow.ShowDialog();
            }
            else
            {
                statsWindow.Close();
                isStatOpen = false;
            }
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            var lockerWindow = new Locker();
            lockerWindow.ShowDialog();
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            base.OnLoad(e);
        }

        private void onExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageTray(object sender, EventArgs e)
        {
            if (!isOptionOpened)
            {
                isOptionOpened = true;
                Options optionsWindow = new Options();
                optionsWindow.optionsInit(ref Pm.pCoding, ref Pm.pGaming, ref Pm.pOthers, ref statsWindow);
                optionsWindow.ShowDialog();
                isOptionOpened = false;
            }

        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                trayIcon.Dispose();
            }
            base.Dispose(isDisposing);
        }

        private void processesTimer_Tick(object sender, EventArgs e)
        {
            Pm.checkStates();
            statsWindow.SetStats(Pm.coding, Pm.gaming, Pm.others);
            WriteXML();
        }

        public void WriteXML()
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(ProcessesManager));

            using (var file = new System.IO.StreamWriter(
                @"SuperbImportantData.xml"))
            {
                writer.Serialize(file, Pm);

                file.Close();
            }
        }

        public void ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(ProcessesManager));
            using (var file = new System.IO.StreamReader(
                @"SuperbImportantData.xml"))
            {
                Pm = (ProcessesManager)reader.Deserialize(file);
                file.Close();
            }
            statsWindow.SetStats(Pm.coding, Pm.gaming, Pm.others);


        }

    }
}
