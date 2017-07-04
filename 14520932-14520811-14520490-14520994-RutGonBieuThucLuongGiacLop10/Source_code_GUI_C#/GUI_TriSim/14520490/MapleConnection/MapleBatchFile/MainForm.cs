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
using System.IO;
using System.Threading;

namespace MapleBatchFile
{
    public partial class MainForm : Form
    {
        public string strCMapleDir = null;
        private int count = 0;  //đếm số lần chạy (số bài giải)
        public string dirToPass = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadCmaple_Click(object sender, EventArgs e)
        {
            strCMapleDir = openMaple();
            if (strCMapleDir != null)
            {
                MessageBox.Show(strCMapleDir);
            }
            else
            {
                MessageBox.Show("Chưa chọn file cmaple.exe!");
                return;
            }
            tbCmapleDir.Text = strCMapleDir;
            createSolveBat();
        }
        string openMaple()
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                return sFileName;
            }
            return null;
        }
        private void createSolveBat()
        {
            //var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            var currentDirectory = System.Reflection.Assembly.GetEntryAssembly().Location;
            currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            //currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            //MessageBox.Show(currentDirectory);
            var dir = currentDirectory + @"\package";
            string path_SolveBat = dir + @"\solve.bat";

            if (!File.Exists(path_SolveBat))
            {
                File.Create(path_SolveBat).Dispose();
            }

            string maple_path = '"' + strCMapleDir + '"';
            maple_path += " problem.mpl";
            System.IO.File.WriteAllText(path_SolveBat, maple_path);
        }
        private void preProcessForOutScreen(string path_Out)
        {
            var logFile = File.ReadAllLines(path_Out);
            var logList = new List<string>(logFile);

            {//create html file
                bool isTwoEquationInOneStep = false;
                bool isInput = true;
             
                var currDir = System.Reflection.Assembly.GetEntryAssembly().Location;
                currDir = currDir.Substring(0, currDir.LastIndexOf('\\'));
                var dir = currDir + @"\result\result" + count.ToString() + @".html";
                dirToPass = currDir;
                count++;
                string contentInHtml = "";
                //ofs << "<html><head><style> img { max-width: 320px; }</style></head><body><h3>Query</h3><img src=\"" << argv[1] << "\" alt=\"\" /><br />";
                contentInHtml += "<html><head><meta http-equiv='Content-Type' content='text/html;charset=UTF-8'></head><body>";
                for (int i = 0; i < logFile.Count(); i++)
                {
                    if (logList[i].Equals("Áp dụng:"))
                    {
                        isTwoEquationInOneStep = true;
                        isInput = true;
                        contentInHtml += "<p><font face=\"verdana\"color=\"green\">" + logFile[i] + "</p>";
                    }
                    else if (logList[i].Equals("Ta có:"))
                    {
                        isTwoEquationInOneStep = false;
                        contentInHtml += "<p><font face=\"verdana\"color=\"green\">" + logFile[i] + "</font></p>";
                    }
                    else if (logList[i].Contains("Bước") || logList[i].Contains("Input")|| logList[i].Contains("thúc"))
                    {
                        isTwoEquationInOneStep = false;
                        contentInHtml += "<p><h3><font face=\"verdana\"color=\"green\">" + logFile[i] + "</font></h3></p>";
                    }
                    else if (logList[i].Contains("thành") || logList[i].Contains("thừa") || logList[i].Contains("RÚT")
                                                         || logList[i].Contains("đồng") || logList[i].Contains("QUẢ"))
                    {
                        isTwoEquationInOneStep = false;
                        contentInHtml += "<p><font face=\"verdana\"color=\"green\">" + logFile[i] + "</font></p>";
                    }
                    else
                    {
                        if (isInput)
                        {
                            string gifFilename = "result" + count.ToString()+ i.ToString() + ".gif";
                            CreateEquation(logList[i], gifFilename);
                            contentInHtml += "<img alt=\"\" src=\"" + currDir + @"\gifPath\" + gifFilename + "\" />";
                            isTwoEquationInOneStep = false;
                            isInput = false;
                            
                        }
                        else
                        {
                            if (isTwoEquationInOneStep)//nếu một bước có 2 biểu thức - ràng buộc để tránh ghi đè
                            {
                                string gifFilename = i.ToString() + "a" + ".gif";
                                CreateEquation(logList[i], gifFilename);
                                contentInHtml += "<img alt=\"\" src=\"" + currDir + @"\gifPath\" + gifFilename + "\" />";
                                isTwoEquationInOneStep = false;
                            }
                            else
                            {
                                string gifFilename = i.ToString() + ".gif";
                                CreateEquation(logList[i], gifFilename);
                                contentInHtml += "<img alt=\"\" src=\"" + currDir + @"\gifPath\" + gifFilename + "\" />";

                            }
                        }
                        

                    }
                }

                contentInHtml += "</body></html>";

                File.WriteAllText(dir, contentInHtml);
                //cerr << "Html outputted." << endl;
            }

        }
        /// <summary>
        /// CREATE EQUATION
        /// </summary>
        /// <param name="equation"></param>
        /// <param name="gifFileName"></param>
        private void CreateEquation(string equation, string gifFileName)
        {
            try
            {

                if (equation.Length > 0)
                {
                    string gifFilePath = GetGifFilePath(gifFileName);
                    NativeMethods.CreateGifFromEq(equation, gifFilePath); //tạo file ảnh gif của biểu thức
                                                                          //Image tmpImg = Image.FromFile(gifFilePath);
                                                                          //pbResult.Size = tmpImg.Size;
                                                                          //pbResult.Image = tmpImg;
                }
                //else pbResult.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// GET FILE PATH
        /// </summary>
        /// <param name="gifFileName"></param>
        /// <returns></returns>
        private string GetGifFilePath(string gifFileName)
        {
            //var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            //currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            //currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            var currentDirectory = System.Reflection.Assembly.GetEntryAssembly().Location;
            //MessageBox.Show(currentDirectory);
            currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
            var dir = currentDirectory + @"\gifPath\" + gifFileName;
            //return Path.Combine("E:\\","equationImage.gif");
            return dir;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                if (strCMapleDir == null)
                {
                    MessageBox.Show("Chưa chọn file cmaple.exe!");
                    return;
                }
                if (inputTextBox.Text == "")
                {
                    MessageBox.Show("Chưa nhập input!");
                    return;
                }
                string[] query = { //content of type 1 of "solve.bat" file
                "restart;",
                "url := currentdir();",
                "libname := libname, url;",
                "with(TriSim);",
                "f :=" + inputTextBox.Text + ";",
                "Simplify_Tri(f);",
                "print_SOL(f);"
                };

                //var currentDirectory = System.IO.Directory.GetCurrentDirectory();
                //currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
                //currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
                var currentDirectory = System.Reflection.Assembly.GetEntryAssembly().Location;
                //MessageBox.Show(currentDirectory);
                currentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('\\'));
                var dir = currentDirectory + @"\package";
                string path_Problem = dir + @"\problem.mpl";

                if (!File.Exists(path_Problem))
                {
                    File.Create(path_Problem).Dispose();
                }
                if (tbDK.Text != "")
                {//content of type 2 of "solve.bat" file
                    string strDK = "{" + tbDK.Text + "}";
                    string[] query2 = {
                    "restart;",
                    "url := currentdir();",
                    "libname := libname, url;",
                    "with(TriSim);",
                    "f :=" + inputTextBox.Text + ";",
                    "Simplify_Tri(f,"+strDK+");",
                    "print_SOL(f);"
                    };
                    File.WriteAllLines(path_Problem, query2);
                }
                else
                {
                    File.WriteAllLines(path_Problem, query);
                }
                
                //Create solve.bat file and run it
                var p = Process.Start(new ProcessStartInfo("solve.bat")
                {
                    WorkingDirectory = Path.GetFullPath(dir),
                    WindowStyle = ProcessWindowStyle.Hidden,
                });
                p.WaitForExit();

                string path_Out = dir + @"\out.txt";
                string tmp = System.IO.File.ReadAllText(path_Out);

                //Get all line and add to list - use for out screen functions
                preProcessForOutScreen(path_Out); //print out
                MessageBox.Show("Đã giải xong!");
                showSolutionOnScreen();
            }
            catch
            {
                MessageBox.Show("Lỗi chọn file cmaple.exe!");
            }
        }

        private void inputTextBox_DragDrop(object sender, DragEventArgs e)
        {
            inputTextBox.Text = "";
        }

        private void inputTextBox_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
        }

        private void inputTextBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showSolutionOnScreen();
           
        }
        private void showSolutionOnScreen()
        {
            try
            {
                if (inputTextBox.Text != "")
                {
                    int t = count - 1;
                    FormShowResult f2 = new FormShowResult(t, dirToPass);
                    f2.ShowDialog();
                    //webBrowser1.DocumentStream = source;
                    //webBrowser1.Visible = true;
                }
                //else
                //{
                //    MessageBox.Show("Chưa nhập input!");
                //}
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại input và thực hiện giải lại!");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FormShowGuide f1 = new FormShowGuide();
            f1.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAbout f1 = new FormAbout();
            f1.ShowDialog();
        }
    }
}

