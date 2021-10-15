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
using System.Net;
using Newtonsoft.Json;

namespace KeyAuth_Admin_Panel
{
    public partial class ConnectKey : Form
    {
        public ConnectKey()
        {
            InitializeComponent();
        }
        WebClient wc = new WebClient();

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome Back, {Environment.UserName}";

            if (Properties.Settings.Default.key.Contains("none"))
            {
                loadapp.Text = "Last App Not Found";
            }
            else
            {
                loadapp.Text = "Load " + Properties.Settings.Default.name;
            }
        }
      

        private void newapp_Click(object sender, EventArgs e)
        {
            animation.Show(addapppanel);

            savenewapp.BringToFront();
            back.BringToFront();

            newapp.SendToBack();
            loadapp.SendToBack();
        }

        private void addapppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            animation.Hide(addapppanel);

        }

        private async void savenewapp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(appname.Text) || string.IsNullOrWhiteSpace(appkey.Text))
            {
               MessageBox.Show("Please enter all fields");
               timeformsg.Start();
            }
            else
            {
                var keyinfo = await Task.Run(() => wc.DownloadString($"https://keyauth.com/api/seller/?sellerkey={appkey.Text}"));
                if (keyinfo.Contains("failed"))
                {
                    MessageBox.Show("Seller Key is Invalid");
                    timeformsg.Start();
                }
                else
                {
                    MessageBox.Show("Your app was successfully saved");
                    Properties.Settings.Default.key = appkey.Text;
                    Properties.Settings.Default.name = appname.Text;
                    Properties.Settings.Default.Save();

                    newapp.BringToFront();
                    loadapp.BringToFront();

                    timeformsg.Start();
                    loadapp.Text = "Load " + Properties.Settings.Default.name;
                }
            }
        }

        private async void loadapp_Click(object sender, EventArgs e)
        {
            if (loadapp.Text == "Last App Not Found")
            {
                MessageBox.Show("Create an app first");
                timeformsg.Start();
            }
            else
            {
                var keyinfo = await Task.Run(() => wc.DownloadString($"https://keyauth.com/api/seller/?sellerkey={Properties.Settings.Default.key}" + "type=fetchallusers"));
                if (keyinfo.Contains("failed"))
                {
                    MessageBox.Show("Seller key was changed...","invalid");
                    timeformsg.Start();

                    Properties.Settings.Default.key = "none";
                    Properties.Settings.Default.name = "none";
                    loadapp.Text = "Last App Not Found";
                    Properties.Settings.Default.Save();
                }
                else
                {
                    label5.Text = "Redirecting to main page";
                    MessageBox.Show("Redirecting to main page");
                    loadapp.Enabled = false;
                    msgpanel.Show(messageboxx);
                    timeformsg.Start();
                }

            }
        }

        private void timeformsg_Tick(object sender, EventArgs e)
        {
            if (messageboxx.Visible == true)
            {
                msgpanel.Hide(messageboxx);
                timeformsg.Stop();

                if (label5.Text == "Redirecting to main page")
                {
                    new Form1().Show();
                    this.Hide();
                }
                return;

            }
            else
            {
                timeformsg.Stop();
                return;
            }
        }

        private void social_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCl0Pf09waKeAmRIZz6a-Mtg");
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
