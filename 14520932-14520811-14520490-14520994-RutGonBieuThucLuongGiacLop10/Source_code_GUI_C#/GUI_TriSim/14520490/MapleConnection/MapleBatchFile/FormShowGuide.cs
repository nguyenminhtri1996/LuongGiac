using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleBatchFile
{
    public partial class FormShowGuide : Form
    {
        public FormShowGuide()
        {
            InitializeComponent();
            showGuide();
        }
        private void showGuide()
        {
            lbGuide.Text = null;
            lbGuide.Text += "Bước 1. Chọn đường dẫn đến file cmaple.exe.\n";
            lbGuide.Text += "Bước 2. Nhập biểu thức lượng giác cần rút gọn\n   vào ô \"Biểu thức lượng giác\".\n";
            lbGuide.Text += " ------------------------------------------------------------\n";
            lbGuide.Text += " (*) Nhập điều kiện bổ sung cho bài toán (nếu có)\n vào ô \"Điều kiện bổ sung\".\n";
            lbGuide.Text += " (*) Các điều kiện cách nhau bởi dấu phẩy.\n";
        }


        private void btnOK_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
