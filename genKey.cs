using System;
using System.Windows.Forms;

namespace KeyAuth_Admin_Panel
{
    public partial class genKey : Form
    {
        public genKey()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
