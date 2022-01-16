using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;


namespace WinTaskbarEditor
{
    public partial class Form1 : Form
    {

        RegistryKey RegistryKey;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Top")
            {
                try
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3", true);

                    key.SetValue("Settings", "30 00 00 00 fe ff ff ff 02 00 00 00 01 00 00 00 00 00 3c 00 00 00 28 00 00 00 78 00 00 00 01 00 00 00 ", RegistryValueKind.Binary);
                    key.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
      
            if(comboBox2.SelectedItem == "Small")
            {

                RegistryKey xkey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
                xkey.SetValue("TaskbarSi", "0", RegistryValueKind.DWord);

            }
            if (comboBox2.SelectedItem == "Medium (Windows 11 Default)")
            {

                RegistryKey xkey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
                xkey.SetValue("TaskbarSi", "1", RegistryValueKind.DWord);

            }
            if (comboBox2.SelectedItem == "Big")
            {

                RegistryKey xkey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
                xkey.SetValue("TaskbarSi", "2", RegistryValueKind.DWord);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process xtx = new Process();
            xtx.StartInfo.FileName = "k.bat";
            xtx.Start();


        }


        public void button3_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process x = new Process();
            x.StartInfo.FileName = @"C:\\windows\\explorer.exe";
            x.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
