using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DroidAppStar.commDS;

namespace DroidAppStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        commDS cm = new commDS();
        static string temp = Environment.GetEnvironmentVariable("temp");
        string adbDevice = string.Empty;
        private Timer timer1;

        private void btnRootCheck_Click(object sender, EventArgs e)
        {
            using (frmWait f = new frmWait(rootCheck))
            {
                f.ShowDialog(this);
            }
        }

        void rootCheck()
        {
            if (adbDevice != string.Empty)
            {
                if (isRooted())
                {
                    string version = cm.execCommand(adbDevice + " shell su - version");
                    label2.ForeColor = Color.Green;
                    label2.Text = "Root found, " + version;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Root not found!";
                }
                if (hasBusyBox())
                {
                    string date = cm.execCommand(adbDevice + " shell busybox date");
                    label4.ForeColor = Color.Green;
                    label4.Text = "BusyBox found!, " + date;
                }
                else
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "BusyBox not found!";
                }
            }
        }
        bool isRooted()
        {
            bool root = false;
            var checkRoot = cm.execCommand(adbDevice + " shell su -c exit");
            if ((checkRoot.ToLower().Contains("not found")) || (checkRoot.ToLower().Contains("permission denied")))
            {
                cm.execCommand(adbDevice + @" pull /system/bin/su");
                if (File.Exists("su"))
                {
                    File.Delete("su");
                    root = true;
                }
                else
                {
                    root = false;
                }             
            }
            else
            {
                root = true;
            }
            return root;
        }

        bool hasBusyBox()
        {
            bool busybox = false;
            var busyboxCheck = cm.execCommand(adbDevice + " shell busybox");
            if ((busyboxCheck.ToLower().Contains("permission denied")) || (busyboxCheck.ToLower().Contains("not found")))
            {
                busybox = false;
            }
            else
            {
                busybox = true;
            }
            return busybox;
        }

        void formLoad()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    tabPage4.BackColor = Color.Transparent;
                    tabPage5.BackColor = Color.Transparent;
                    transparentTabControl1.MakeTransparent();
                    cm.execCommand("adb kill-server");
                    cm.execCommand(@"taskkill /F /FI ""IMAGENAME eq adb.exe""");
                    cm.execCommand("adb.exe start-server");
                    refreshDevices();
                    //InitTimer();
                }));
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (frmWait f = new frmWait(formLoad))
            {
                f.ShowDialog(this);
            }
        }

        void getConnectedDeviceModels()
        {
            cmbModel.Items.Clear();
            if (adbDevice != string.Empty)
            {
                for (int i = 0; i < cmbDevices.Items.Count; i++)
                {
                    string devModel = cm.execCommand("adb.exe -s " + cmbDevices.Items[i].ToString() + " shell getprop ro.product.model");
                    devModel = cm.RemoveEmptyLines(devModel);
                    cmbModel.Items.Add(devModel);
                }               
            }
            else
            {
                cmbModel.Items.Add("No device detected");
            }
            cmbModel.SelectedIndex = cmbDevices.SelectedIndex;
        }

        void getBatteryP()
        {
            label5.Text = "---";
            if (adbDevice != string.Empty)
            {
                string batteryP = cm.execCommand(adbDevice + @" shell dumpsys battery | find ""level""");
                batteryP = batteryP.Replace("level: ", "");
                batteryP = cm.RemoveEmptyLines(batteryP);
                label5.Text = batteryP + " %";
            }
            else
            {
                label5.Text = "---";
            }
        }

        private void llbRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmWait f = new frmWait(refreshDevices))
            {
                f.ShowDialog(this);
            }
        }

        void refreshDevices()
        {
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
            rtxConsole.Clear();           
            label2.ForeColor = Color.White;
            label2.Text = "---";
            label4.ForeColor = Color.White;
            label4.Text = "---";
            File.Delete(temp + @"\adb_device.txt");
            cmbDevices.Items.Clear();
            cm.execCommand(@"adb.exe devices>""%temp%\adb_device.txt""");
            using (StreamReader sr = new StreamReader(temp + @"\adb_device.txt"))
            {
                string line;
                while (sr.EndOfStream != true)
                {
                    line = sr.ReadLine();
                    if (line.Trim() != string.Empty && line != "List of devices attached")
                    {
                        cmbDevices.Items.Add(line.Trim().Replace("device", ""));
                    }
                }
            }

            int count = cmbDevices.Items.Count;
            if (count < 1)
            {
                cmbDevices.Items.Add("No device detected");
                cmbDevices.SelectedIndex = 0;
                adbDevice = string.Empty;                               
            }
            else
            {
                    cmbDevices.SelectedIndex = 0;
                    adbDevice = "adb.exe -s " + cmbDevices.SelectedItem.ToString();
            }

            var groupBox1buttons = groupBox1.Controls.OfType<Button>();
            var groupBox4buttons = groupBox4.Controls.OfType<Button>();
            var groupBox5buttons = groupBox5.Controls.OfType<Button>();
            if (adbDevice == string.Empty)
            {              
                foreach (Button btn in groupBox1buttons) { btn.Enabled = false; }
                foreach (Button btn in groupBox4buttons) { btn.Enabled = false; }
                foreach (Button btn in groupBox5buttons) { btn.Enabled = false; }
            }
            else
            {
                foreach (Button btn in groupBox1buttons) { btn.Enabled = true; }
                foreach (Button btn in groupBox4buttons) { btn.Enabled = true; }
                foreach (Button btn in groupBox5buttons) { btn.Enabled = true; }
                btnUninstallApk.Enabled = false;
                label5.Text = cm.execCommand(adbDevice + " shell getprop ro.build.version.release");
            }
            getConnectedDeviceModels();
            //getBatteryP();
            File.Delete(temp + @"\adb_device.txt");
            System.Threading.Thread.Sleep(1000);
        }
        
        //public void InitTimer()
        //{
        //    timer1 = new Timer();
        //    timer1.Tick += new EventHandler(timer1_Tick);
        //    timer1.Interval = 5000;
        //    timer1.Start();
        //}

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    refreshDevices();
        //}

        private void rtxConsole_TextChanged(object sender, EventArgs e)
        {
            rtxConsole.SelectionStart = rtxConsole.Text.Length;
            rtxConsole.ScrollToCaret();
        }

        private void btnBrowseApk_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open APK file..";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "APK files|*.apk";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInstallApk.Text = openFileDialog1.FileName;
            }
        }

        void installApk()
        {
            if (adbDevice != string.Empty)
            {
                cm.execCommand(adbDevice + " install -r " + txtInstallApk.Text);
            }
        }

        private void btnInstallApk_Click(object sender, EventArgs e)
        {
            if (txtInstallApk.Text != string.Empty)
            {
                using (frmWait f = new frmWait(installApk))
                {
                    f.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("No apk file selected !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void uninstallApk()
        {
            if (adbDevice != string.Empty)
            {
                if (isRooted())
                {
                    for (int i = 0; i < listView1.CheckedItems.Count; i++)
                    {
                        cm.execCommand(adbDevice + " shell pm uninstall " + listView1.CheckedItems[i].Text);
                    }
                }
                else
                {
                    for (int i = 0; i < listView1.CheckedItems.Count; i++)
                    {
                        if (listView1.CheckedItems[i].ForeColor == Color.Blue)
                        {
                            cm.execCommand(adbDevice + " shell pm uninstall " + listView1.CheckedItems[i].Text);
                        }
                        else
                        {
                            cm.execCommand(adbDevice + " shell pm uninstall -k --user 0 " + listView1.CheckedItems[i].Text);
                        }

                    }
                }
            }
        }

        private void btnUninstallApk_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                using (frmWait f = new frmWait(uninstallApk))
                {
                    f.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Select minimum of 1 package to uninstall !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseZip_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "Open ZIP file..";
            openFileDialog2.FileName = "";
            openFileDialog2.Filter = "ZIP files|*.zip";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtSideloadZip.Text = openFileDialog2.FileName;
            }
        }

        void sideloadZip()
        {
            if (adbDevice != string.Empty)
            {
                cm.execCommand(adbDevice + @" sideload """ + txtSideloadZip.Text + @"""");           
            }
        }

        private void btnSideloadZip_Click(object sender, EventArgs e)
        {
            if (txtSideloadZip.Text != "")
            {
                using (frmWait f = new frmWait(sideloadZip))
                {
                    f.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("No zip file selected !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void readPackages()
        {
            listView1.Items.Clear();
            lblUserAppsCount.ForeColor = Color.White;
            lblUserAppsCount.Text = "---";
            lblSystemAppsCount.ForeColor = Color.White;
            lblSystemAppsCount.Text = "---";
            if (adbDevice != string.Empty)
            {
                cm.execCommand(adbDevice + @" shell ""pm list packages -3 -f"">""%temp%\adb-userapps.txt""");
                cm.execCommand(adbDevice + @" shell ""pm list packages -s -f"">""%temp%\adb-systemapps.txt""");

                //cm.execCommand(adbDevice + @" shell ""pm list packages -3"">""%temp%\adb-userapps.txt""");
                //cm.execCommand(adbDevice + @" shell ""pm list packages -s"">""%temp%\adb-systemapps.txt""");
                string[] adbUserApps = File.ReadLines(temp + @"\adb-userapps.txt").ToArray();
                string[] adbSystemApps = File.ReadLines(temp + @"\adb-systemapps.txt").ToArray();
                int countUserApps = adbUserApps.Count();
                int countSystemApps = adbSystemApps.Count();

                for (int i = 0; i < countUserApps; i++)
                {
                    int indexApk = adbUserApps[i].IndexOf(".apk=");
                    string apkPath = adbUserApps[i].Substring(0, indexApk).Replace("package:","")+".apk";

                    string padkage_data = cm.execCommand(adbDevice + @" shell /data/local/tmp/aapt-arm-pie d badging " + @"""" + apkPath + @"""" + @" | findstr ""application-label: versionName='""");
                    int pkg_name_From = padkage_data.IndexOf("name='") + "name='".Length;
                    int pkg_name_To = padkage_data.LastIndexOf("' versionCode");
                    int pkg_version_From = padkage_data.IndexOf("versionName='") + "versionName='".Length;
                    int pkg_version_To = padkage_data.LastIndexOf("' plat");
                    int pkg_label_From = padkage_data.IndexOf("application-label:'") + "application-label:'".Length;
                    int pkg_label_To = padkage_data.LastIndexOf("'");
                    string pkg_name = padkage_data.Substring(pkg_name_From, pkg_name_To - pkg_name_From);
                    string pkg_version = padkage_data.Substring(pkg_version_From, pkg_version_To - pkg_version_From);
                    string pkg_label = padkage_data.Substring(pkg_label_From, pkg_label_To - pkg_label_From);

                    string[] row = { pkg_label, pkg_version };
                    listView1.Items.Add(pkg_name).SubItems.AddRange(row);
                    //adbUserApps[i] = adbUserApps[i].Replace("package:", "");
                    //listView1.Items.Add(adbUserApps[i]);
                    listView1.Items[i].ForeColor = Color.Blue;
                }

                for (int i = 0; i < countSystemApps; i++)
                {
                    int indexApk = adbSystemApps[i].IndexOf(".apk=");
                    string apkPath = adbSystemApps[i].Substring(0, indexApk).Replace("package:", "") + ".apk";

                    string padkage_data = cm.execCommand(adbDevice + @" shell /data/local/tmp/aapt-arm-pie d badging " + @"""" + apkPath + @"""" + @" | findstr ""application-label: versionName='""");
                    int pkg_name_From = padkage_data.IndexOf("name='") + "name='".Length;
                    int pkg_name_To = padkage_data.LastIndexOf("' versionCode");
                    int pkg_version_From = padkage_data.IndexOf("versionName='") + "versionName='".Length;
                    int pkg_version_To = padkage_data.LastIndexOf("' plat");
                    int pkg_label_From = padkage_data.IndexOf("application-label:'") + "application-label:'".Length;
                    int pkg_label_To = padkage_data.LastIndexOf("'");
                    string pkg_name = padkage_data.Substring(pkg_name_From, pkg_name_To - pkg_name_From);
                    string pkg_version = padkage_data.Substring(pkg_version_From, pkg_version_To - pkg_version_From);
                    string pkg_label = padkage_data.Substring(pkg_label_From, pkg_label_To - pkg_label_From);

                    string[] row = { pkg_label, pkg_version };
                    listView1.Items.Add(pkg_name).SubItems.AddRange(row);
                    //adbSystemApps[i] = adbSystemApps[i].Replace("package:", "");
                    //listView1.Items.Add(adbSystemApps[i]);
                    int i2 = countUserApps + i;
                    listView1.Items[i2].ForeColor = Color.Red;
                }
                //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                txtSearch.Enabled = true;
                btnUninstallApk.Enabled = true;
                lblUserAppsCount.ForeColor = Color.MediumSlateBlue;
                lblUserAppsCount.Text =  countUserApps.ToString();
                lblSystemAppsCount.ForeColor = Color.IndianRed;
                lblSystemAppsCount.Text =  countSystemApps.ToString();
            }
            else
            {
                listView1.Items.Clear();
                txtSearch.Enabled = false;
                btnUninstallApk.Enabled = false;
            }
            File.Delete(temp + @"\adb-userapps.txt");
            File.Delete(temp + @"\adb-systemapps.txt");
        }
        private void btnReadApps_Click(object sender, EventArgs e)
        {
            readPackages();
            //using (frmWait f = new frmWait(readPackages))
            //{
            //    f.ShowDialog(this);
            //}
        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbModel.SelectedIndex = cmbDevices.SelectedIndex;
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDevices.SelectedIndex = cmbModel.SelectedIndex;
            if (cmbDevices.SelectedItem.ToString() != "No device detected")
            { adbDevice = "adb.exe -s " + cmbDevices.SelectedItem.ToString(); }
            else { adbDevice = string.Empty; }
            //getBatteryP();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.Text.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        //item.BackColor = SystemColors.Highlight;
                        //item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else
            {
                btnReadApps_Click(sender, e);
            }
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            if (adbDevice != string.Empty)
            {
                cm.execCommand(adbDevice + " reboot");
            }
        }

        private void btnRebootRecovery_Click(object sender, EventArgs e)
        {
            if (adbDevice != string.Empty)
            {
                cm.execCommand(adbDevice + " reboot recovery");
            }
        }

        private void btnRebootBootloader_Click(object sender, EventArgs e)
        {
            if (adbDevice != string.Empty)
            {
                cm.execCommand(adbDevice + " reboot bootloader");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string padkage_data=cm.execCommand(adbDevice+@" shell /data/local/tmp/aapt-arm-pie d badging "+ @""""+ "/data/app/com.google.android.GoogleCameraTele-RtL8ZvClEGn1zRPlXaQ9xg==/base.apk"+@""""+ @" | findstr ""application-label: versionName='""");
            int pkg_name_From = padkage_data.IndexOf("name='") + "name='".Length;
            int pkg_name_To = padkage_data.LastIndexOf("' versionCode");
            int pkg_version_From = padkage_data.IndexOf("versionName='") + "versionName='".Length;
            int pkg_version_To = padkage_data.LastIndexOf("' plat");
            int pkg_label_From = padkage_data.IndexOf("application-label:'") + "application-label:'".Length;
            int pkg_label_To = padkage_data.LastIndexOf("'");
            string pkg_name = padkage_data.Substring(pkg_name_From, pkg_name_To - pkg_name_From);
            string pkg_version = padkage_data.Substring(pkg_version_From, pkg_version_To - pkg_version_From);
            string pkg_label = padkage_data.Substring(pkg_label_From, pkg_label_To - pkg_label_From);
            MessageBox.Show(pkg_name + pkg_version + pkg_label);
        }
    }
}
