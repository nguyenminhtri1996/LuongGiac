using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Reflection;


namespace MapleBatchFile
{
    public partial class FormShowResult : Form
    {
        private const int small_Width = 991;
        private const int small_Height = 615;
        private bool isMax = false;
        public Point pLocation;
        public FormShowResult()
        {
            InitializeComponent();
        }
        public FormShowResult(int t, string dirToPass)
        {
            InitializeComponent();
            pLocation = new Point(Screen.PrimaryScreen.WorkingArea.Size.Width - 20, 15);
            displayResult(t, dirToPass);
        }
        private void displayResult()
        {
            FileStream source = new FileStream("result\result.html", FileMode.Open, FileAccess.Read);
            webBrowser1.DocumentStream = source;
        }
        private void displayResult(int t, string dirToPass)
        {
            //FileStream source = new FileStream(dirToPass+ @"\result" + t.ToString() + @".html", FileMode.Open, FileAccess.Read);
            //webBrowser1.DocumentStream = source;

            //ver 2.
            webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.Url = new Uri(dirToPass + @"\result\result" + t.ToString() + @".html");
        }
        private void flatMax1_Click(object sender, EventArgs e)
        {
            if (!isMax)
            {
                panel1.Height = Screen.PrimaryScreen.WorkingArea.Size.Height - 20;
                panel1.Width = Screen.PrimaryScreen.WorkingArea.Size.Width - 10;
                //panel1.Width = this.Size.Width - 1;
                webBrowser1.Width = Screen.PrimaryScreen.WorkingArea.Size.Height - 25;
                webBrowser1.Height = Screen.PrimaryScreen.WorkingArea.Size.Height - 15;
                isMax = !isMax;
                label1.Location = pLocation;
                pLocation = flatClose1.Location;
            }
            else
            {
                panel1.Height = small_Height - 205;
                panel1.Width = small_Width - 280;
                //panel1.Width = this.Size.Width - 1;
                webBrowser1.Width = small_Width - 280;
                webBrowser1.Height = small_Height - 185;
                isMax = !isMax;
                label1.Location = pLocation;
                pLocation = flatClose1.Location;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentStream.Close();
            this.Close();
        }
    }
}
