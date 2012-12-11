using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using USBScale;
using ZWeighBtn;


namespace ConsoleApplication1
{
    public partial class DeviceServerMain : Form
    {
        public DeviceServerMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


namespace MyTrayApp
{
    public class SysTrayApp : Form
    {
        [STAThread]
        public static void Main()
        {

            Bend.Util.HttpServer httpServer;
            // USBScale.Scale scale;
            // scale = new USBScale.Scale;

            // double v;

            //ZWeighBtn.ScaleBtn zb;
            //zb = new ZWeighBtn.ScaleBtn

            // zb.VID = 0x1446;
            // zb.VID ="0x1446";
            //v = zb.SWeight;
            //Console.WriteLine("weight: " + v.ToString());


            httpServer = new Bend.Util.MyHttpServer(8080);
            // httpServer = new MyHttpServer(Convert.ToInt16(args[0]));
            Thread thread = new Thread(new ThreadStart(httpServer.listen));
            thread.Start();

            Console.WriteLine("http server running");

            Application.Run(new SysTrayApp());
        }

        private NotifyIcon  trayIcon;
        private ContextMenu trayMenu;

        public SysTrayApp()
        {
            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Configure", OnConfigure);
            trayMenu.MenuItems.Add("Exit", OnExit);

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon      = new NotifyIcon();
            trayIcon.Text = "MyTrayApp";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible     = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible       = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }


        private void OnConfigure(object sender, EventArgs e)
        {
            ConsoleApplication1.DeviceServerMain f = new ConsoleApplication1.DeviceServerMain();
            f.ShowDialog();
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                trayIcon.Dispose();
            }

            base.Dispose(isDisposing);
        }
    }
}
