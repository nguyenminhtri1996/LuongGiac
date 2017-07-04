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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            screenOut();
        }
        private void screenOut()
        {
            lbAbout.Text = null;
            lbAbout.Text += "Trần Quốc Long        - 14520490\n";
            lbAbout.Text += "Hoàng Ngọc Thạch  - 14520811\n";
            lbAbout.Text += "Lê Thị Ngọc Thúy     - 14520932\n";
            lbAbout.Text += "Nguyễn Minh Trí       - 14520994\n";
            lbAbout.Text += "-----------------------------------";

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
