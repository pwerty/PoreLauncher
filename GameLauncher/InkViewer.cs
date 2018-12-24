using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobleLauncher
{
    public partial class InkViewer : Form
    {


        string thePath = string.Empty;

        public InkViewer()
        {
            InitializeComponent();
            BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

        }


        private void InkViewer_Load(object sender, EventArgs e)
        {
            
        }

        private void ChangeLabelContents(string path)
        {
            string whatFolder = String.Empty;
            if (path.EndsWith("popular"))
                 whatFolder = "인기 게임";
            else if(path.EndsWith("online"))
                 whatFolder = "온라인 게임";
            else if(path.EndsWith("fps"))
                 whatFolder = "FPS 게임";
            else if(path.EndsWith("mobile"))
                 whatFolder = "모바일 게임";
            else if(path.EndsWith("cd"))
                whatFolder = "CD 게임";
            else if(path.EndsWith("sports"))
                whatFolder = "스포츠 게임";
            else if(path.EndsWith("casual"))
                whatFolder = "캐주얼 게임";
            else if(path.EndsWith("board"))
                whatFolder = "보드 게임";
            else if(path.EndsWith("document"))
                whatFolder = "메신저 계열";
            else
                whatFolder = "Undefined Folder";

            label1.Text = "현재 " + whatFolder + " 리스트 내용을 표시하고 있습니다."; 

        }

        public void GetPath(string path)
        {
            ChangeLabelContents(path);
            SetList(path);
        }

        private void SetList(string fullpath)
        {             
            imageList1.Images.Clear();
            listView1.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(fullpath);

            try
            {
                FileInfo[] files = dir.GetFiles();
                int Count = 0;
                foreach (FileInfo fileinfo in files)
                {
                    ListViewItem lsvitem = new ListViewItem();

                    string RealPath = fullpath.ToString() + "\\" + fileinfo.Name;
                    Icon iconfile = Icon.ExtractAssociatedIcon(RealPath);

                    imageList1.Images.Add(Count.ToString(), iconfile);
                    listView1.LargeImageList = imageList1;

                    lsvitem.Text = fileinfo.Name;

                    lsvitem.Text = fileinfo.Name.Remove(fileinfo.Name.Length - 4, 4);


                    lsvitem.ImageIndex = 0;
                    listView1.Items.Add(lsvitem);
                    lsvitem.ImageKey = Count.ToString();

                    if (fileinfo.LastWriteTime != null)
                    {
                        listView1.Items[Count].SubItems.Add(fileinfo.LastWriteTime.ToString());
                    }
                    else
                    {
                        listView1.Items[Count].SubItems.Add(fileinfo.CreationTime.ToString());
                    }
                    listView1.Items[Count].SubItems.Add(fileinfo.Attributes.ToString());
                    listView1.Items[Count].SubItems.Add(fileinfo.Length.ToString());
                    Count++;
                    thePath = fullpath;
                }
            }

            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("리스트를 읽어 올 폴더를 찾지 못했습니다.");
            }

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string dePath = string.Empty;
            if (listView1.SelectedItems.Count == 1)
            {

                dePath = thePath.ToString() + "\\" + listView1.SelectedItems[0].Text;           
                // 4번 예외처리 거의 만능의자~
                try
                {
                    System.Diagnostics.Process.Start(dePath + ".exe");
                }
                catch (Win32Exception)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(dePath + ".url");
                    }
                    catch (Win32Exception)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(dePath + ".lnk");
                        }
                        catch (Win32Exception)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(dePath + ".bat");
                            }
                            catch (Win32Exception)
                            {
                                MessageBox.Show("올바른 실행 유형의 바로가기가 아닌 것 같습니다.");
                            }
                            return;
                        }
                    }
                }
                Close();

                // how about using string.EndWith(".exe") ?

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Point mousePoint;

        private void InkViewer_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void InkViewer_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
