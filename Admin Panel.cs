using Network;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth_Admin_Panel
{
    public partial class Form1 : Form
    {
        private const string KeyAuth = "https://keyauth.com/api/seller/?sellerkey=";

        private WebClient wc = new WebClient();

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var js = new WebClient().DownloadString(KeyAuth + Properties.Settings.Default.key + "&type=fetchallkeys");
            var data = JObject.Parse(js);
            var items = data["keys"]?.Children<JObject>().Select(jo => new ListViewItem(new[]
            {
                (string)jo["key"],
                (string)jo["note"],
                TimeLicense((string)jo["expires"]),
                (string)jo["status"],
                (string)jo["level"],
                (string)jo["genby"],
                UnixTimeToDateTime((string)jo["gendate"]),
                UnixTimeToDateTime((string)jo["usedon"]),
                (string)jo["usedby"],
                (string)jo["app"],
                (string)jo["banned"]
            })).ToArray();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Key", 275, HorizontalAlignment.Left);
            listView1.Columns.Add("Note", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Expires", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Status", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Level", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Generate By", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Generate Date", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Used On", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Used By", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("App", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Banned", 60, HorizontalAlignment.Left);
            listView1.Items.AddRange(items);

            var js1 = new WebClient().DownloadString(KeyAuth + Properties.Settings.Default.key + "&type=fetchallusers");
            var data1 = JObject.Parse(js1);
            var items1 = data1["users"]?.Children<JObject>().Select(joe => new ListViewItem(new[]
            {
                (string)joe["username"],
                (string)joe["password"],
                (string)joe["expires"],
                (string)joe["hwid"],
                (string)joe["banned"],
                (string)joe["ip"]
            })).ToArray();

            listView3.View = View.Details;
            listView3.FullRowSelect = true;
            listView3.Columns.Add("Username", 85, HorizontalAlignment.Left);
            listView3.Columns.Add("Password", 185, HorizontalAlignment.Left);
            listView3.Columns.Add("Expires", 85, HorizontalAlignment.Left);
            listView3.Columns.Add("Hwid", 285, HorizontalAlignment.Left);
            listView3.Columns.Add("Banned", 85, HorizontalAlignment.Left);
            listView3.Columns.Add("Ip", 85, HorizontalAlignment.Left);
            listView3.Items.AddRange(items1);
        }

        private static string UnixTimeToDateTime(string unixtime)
        {
            if (unixtime == null)
            {
                return "N/A";
            }
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(int.Parse(unixtime)).ToLocalTime();
            return dtDateTime.ToShortDateString();
        }

        private static string TimeLicense(string str)
        {
            return str switch
            {
                "86400" => "1 Day",
                "2628000" => "30 Days",
                "2592000" => "30 Days",
                "7776000" => "90 days",
                _ => str
            };
        }

        private void RefreshListView1()
        {
            listView1.Clear();
            var js = new WebClient().DownloadString(KeyAuth + Properties.Settings.Default.key + "&type=fetchallkeys");
            var data = JObject.Parse(js);
            var items = data["keys"]?.Children<JObject>().Select(jo => new ListViewItem(new[]
            {
                (string)jo["key"],
                (string)jo["note"],
                TimeLicense((string)jo["expires"]),
                (string)jo["status"],
                (string)jo["level"],
                (string)jo["genby"],
                UnixTimeToDateTime((string)jo["gendate"]),
                UnixTimeToDateTime((string)jo["usedon"]),
                (string)jo["usedby"],
                (string)jo["app"],
                (string)jo["banned"]
            })).ToArray();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Key", 275, HorizontalAlignment.Left);
            listView1.Columns.Add("Note", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Expires", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Status", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Level", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Generate By", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Generate Date", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Used On", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Used By", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("App", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Banned", 85, HorizontalAlignment.Left);
            listView1.Items.AddRange(items);
        }

        private void RefreshListView3()
        {
            listView3.Clear();
            var js1 = new WebClient().DownloadString(KeyAuth + Properties.Settings.Default.key + "&type=fetchallusers");
            var data1 = JObject.Parse(js1);
            var items1 = data1["users"]?.Children<JObject>().Select(joe => new ListViewItem(new[]
            {
                (string)joe["username"],
                (string)joe["password"],
                (string)joe["expires"],
                (string)joe["hwid"],
                (string)joe["banned"],
                (string)joe["ip"]
            })).ToArray();

            listView3.View = View.Details;
            listView3.FullRowSelect = true;
            listView3.Columns.Add("Username", 85, HorizontalAlignment.Left);
            listView3.Columns.Add("Password", 185, HorizontalAlignment.Left);
            listView3.Columns.Add("Expires", 85, HorizontalAlignment.Left);
            listView3.Columns.Add("Hwid", 285, HorizontalAlignment.Left);
            listView3.Columns.Add("Banned", 85, HorizontalAlignment.Left);
            listView3.Columns.Add("Ip", 85, HorizontalAlignment.Left);
            listView3.Items.AddRange(items1);
        }

        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to ban " + listView1.SelectedItems[0].SubItems[0].Text +" User", "Ban User", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var testDialog = new frmBan();
                var vb = new WebBrowser();
                if (testDialog.ShowDialog(this) == DialogResult.OK)
                    vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=ban&key=" + listView1.SelectedItems[0].SubItems[0].Text + "&reason=" + testDialog.textBox1.Text);
                Thread.Sleep(1000);
                RefreshListView1();
            }
            else if (dialogResult == DialogResult.No)
            {

            }


           
        }

        private void createKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var key = new genKey();
            var vb = new WebBrowser();
            if (key.ShowDialog(this) == DialogResult.OK)
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=add&expiry=" + key.comboBox1.Text + "&mask=XXXXX-XXXXX-XXXXX&level=1&amount=" + key.numericUpDown2.Value + "&format=json");
            Thread.Sleep(1000);             
            RefreshListView1();
        }

        private void deleteKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void deleteExpiredKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all expired keys? ", "Delete Expired Keys", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var vb = new WebBrowser();
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=delexp");
                Thread.Sleep(1000);
                RefreshListView1();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

            
        }

        private void extendUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var extenduser = new ExtendUser();
            var vb = new WebBrowser();
            if (extenduser.ShowDialog(this) == DialogResult.OK)
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=extend&user=" + listView3.SelectedItems[0].SubItems[0].Text + "&name=Test&expiry=" + extenduser.numericUpDown2.Value);
            Thread.Sleep(1000);
            RefreshListView3();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + listView3.SelectedItems[0].SubItems[0].Text +" user account?", "Delete User", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var vb = new WebBrowser();
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=deluser&user=" + listView3.SelectedItems[0].SubItems[0].Text);
                Thread.Sleep(1000);
                RefreshListView3();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
           
        }

        private void resetHwidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset hwid for " + listView3.SelectedItems[0].SubItems[0].Text + "User?", "Reset HWID", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var vb = new WebBrowser();
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=resetuser&user=" + listView3.SelectedItems[0].SubItems[0].Text);
                Thread.Sleep(1000);
                RefreshListView3();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void clipboardKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listView1.SelectedItems[0].SubItems[0].Text);
        }

        private void deleteKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + listView1.SelectedItems[0].SubItems[0].Text + " Key", "Delete Key", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var vb = new WebBrowser();
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=del&key=" + listView1.SelectedItems[0].SubItems[0].Text);
                Thread.Sleep(1000);
                RefreshListView1();
            }
            else if (dialogResult == DialogResult.No)
            {

            }


            
        }

        private void deleteUnusedKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all unused keys? ", "Delete all unused keys", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var vb = new WebBrowser();
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=delunused");
                Thread.Sleep(1000);
                RefreshListView1();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

           
        }

        private void deleteAllLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want too delete all licesne ?", "Delete All Licesne", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var vb = new WebBrowser();
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=delalllicenses");
                Thread.Sleep(1000);
                RefreshListView1();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

          

        }

        private void addSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddSubscription = new AddSub();
            var vb = new WebBrowser();
            if (AddSubscription.ShowDialog(this) == DialogResult.OK)
            vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=addsub&name=" + AddSubscription.subName.Text + "&level=" + AddSubscription.numericUpDown2.Value);
            Thread.Sleep(1000);
            RefreshListView1();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var keyinfo = await AsyncTools.Download($"https://keyauth.com/api/seller/?sellerkey{Properties.Settings.Default.key}");
            if (keyinfo.Contains("failed"))
            {
                //   msglogo.Image = new Bitmap(Properties.Resources.error);
                MessageBox.Show("Seller key was changed, invalid. Closing AdminAuth now...");
                //   msgpanel.Show(messagebox);
                //  timeformsg.Start();

                Properties.Settings.Default.key = "none";
                Properties.Settings.Default.name = "none";
                Properties.Settings.Default.Save();
            }
            else
            {
                //  msglogo.Image = new Bitmap(Properties.Resources.good);
                MessageBox.Show("Admin key is valid for " + Properties.Settings.Default.name + "");
                //   msgpanel.Show(messagebox);
                //  timeformsg.Start();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var uploadFile = new UploadFile();
            var vb = new WebBrowser();
            if (uploadFile.ShowDialog(this) == DialogResult.OK)
            vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=upload&url=" + uploadFile.textBox1.Text);
            Thread.Sleep(1000);
            RefreshListView1();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var addVariable = new AddVar();
            var vb = new WebBrowser();
            if (addVariable.ShowDialog(this) == DialogResult.OK)
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=addvar&name=" + addVariable.varName.Text + "&data=" + addVariable.varData.Text);
            Thread.Sleep(1000);
            RefreshListView1();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var editVariable = new EditVara();
            var vb = new WebBrowser();
            if (editVariable.ShowDialog(this) == DialogResult.OK)
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=editvar&varid=" + editVariable.varName.Text + "&data=" + editVariable.varData.Text);
            Thread.Sleep(1000);
            RefreshListView1();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all variables?", "Delete all Variables", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var vb = new WebBrowser();
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=delallvars");
                Thread.Sleep(1000);
                RefreshListView1();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            var AddSubscription = new AddSub();
            var vb = new WebBrowser();
            if (AddSubscription.ShowDialog(this) == DialogResult.OK)
                vb.Navigate(KeyAuth + Properties.Settings.Default.key + "&type=addsub&name=" + AddSubscription.subName.Text + "&level=" + AddSubscription.numericUpDown2.Value);
            Thread.Sleep(1000);
            RefreshListView1();
        }
    }
}
