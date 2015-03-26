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

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        KeyboardHook hook = new KeyboardHook();
        

        public Tray()
        {
            InitializeComponent();
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", onExit);

            trayIcon = new NotifyIcon();
            trayIcon.Text = "Locker";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);

            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            // register the event that is fired after the key press.
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(ScreenLocker.ModifierKeys.Alt | ScreenLocker.ModifierKeys.Control, Keys.F12);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            // show the keys pressed in a label.
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

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                trayIcon.Dispose();
            }
            base.Dispose(isDisposing);
        }
    }
}
