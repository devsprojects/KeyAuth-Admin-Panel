using System;
using System.Windows.Forms;

namespace KeyAuth_Admin_Panel
{
    public partial class frmBan : Form
    {
        public frmBan()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
