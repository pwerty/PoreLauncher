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
using NobleLauncher;

namespace GameLauncher
{



    public partial class Form1 : Form
    {


        InkViewer theViewer = new InkViewer();

        void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {

            int iWidth = Screen.PrimaryScreen.Bounds.Width;
            int iHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Left = (iWidth / 2) - (927 / 2);
            this.Top = (iHeight - 489);
        }

        public Form1()
        {
            Microsoft.Win32.SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            int iWidth = Screen.PrimaryScreen.Bounds.Width;
            int iHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Left = (iWidth / 2) - (927 / 2);
            this.Top = (iHeight - 489);
        

        }

        public void errorPrinter()
        {
            MessageBox.Show("해당 내용의 폴더를 찾을 수 없었습니다.\r폴더의 이름이 바뀌거나 삭제 된 것 같습니다.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Process.Start("explorer.exe", "=");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewerActivator();
            theViewer.GetPath(@"./popular");
            //theViewer.GetPath(@"D:\foreLauncher\popular");        
        }

        //foreLauncher의 완전 대체로 사용 하게되면 상대경로로 코딩 하면 되겠는데..

        private void Online_Click(object sender, EventArgs e)
        {
            ViewerActivator();
            theViewer.GetPath(@"./online");
            //theViewer.GetPath(@"D:\foreLauncher\online");
        }

        private void FPS_Click(object sender, EventArgs e)
        {
            ViewerActivator();
            theViewer.GetPath(@"./fps");
            //theViewer.GetPath(@"D:\foreLauncher\fps");
        }

        private void internet_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome.exe");
            }
            catch (Win32Exception)
            {
                errorPrinter();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\NVIDIA Corporation\Control Panel Client\nvcplui.exe");
        }

        private void info_Click(object sender, EventArgs e)
        {

        }

        private void mobile_Click(object sender, EventArgs e)
        {
            ViewerActivator();
            theViewer.GetPath(@"./mobile");
            //theViewer.GetPath(@"D:\foreLauncher\mobile");
        }

        private void cd_Click(object sender, EventArgs e)
        {
            ViewerActivator();
            theViewer.GetPath(@"./cd");
           //theViewer.GetPath(@"D:\foreLauncher\cd");           
        }

        private void sports_Click(object sender, EventArgs e)
        {
            ViewerActivator();
            theViewer.GetPath(@"./sports");
           //theViewer.GetPath(@"D:\foreLauncher\sports");
        }

        private void casual_Click(object sender, EventArgs e)
        {
            ViewerActivator();
            theViewer.GetPath(@"./casual");
           // theViewer.GetPath(@"D:\foreLauncher\casual");
        }

        private void board_Click(object sender, EventArgs e)
        {
             ViewerActivator();
            theViewer.GetPath(@"./board");
             //theViewer.GetPath(@"D:\foreLauncher\board");     
        }
        
        private void messenger_Click(object sender, EventArgs e)
        {
            ViewerActivator();
           theViewer.GetPath(@"./document");
            //theViewer.GetPath(@"D:\foreLauncher\document");
        }

        private void settings_Click(object sender, EventArgs e)
        {
           Process.Start("control","main.cpl");
        }

        private void internet_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("iexplore.exe");
            }
            catch (Win32Exception)
            {
                errorPrinter();
            }
        }

        void ViewerActivator()
        {
            if (theViewer.IsDisposed)
            {
                theViewer = new InkViewer();
                theViewer.Show();
                theViewer.BringToFront();
            }
            else
            {
                theViewer.Show();
                theViewer.BringToFront();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                Process.Start("control", "keyboard");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("control", "main.cpl");
            }
            catch (Win32Exception)
            {
                errorPrinter();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Program Files\Logitech Gaming Software\LCore.exe");
            }
            catch (Win32Exception)
            {
                errorPrinter();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "=");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=qqlteyFc76U");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("노블존 PC방을 방문 해 주셔서 감사합니다. \r손님 여러분들의 건승을 기원하겠습니다.\r\r오른쪽 아래 아이콘에서도 추가 메뉴를 이용 하실 수 있습니다.\r기술 문의 : pwertyman@naver.com");
        }
    }
}
