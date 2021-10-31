using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                string link = @"http://www.africau.edu/images/default/sample.pdf";
                string downloadFileName = Path.GetFileName("sample.pdf");
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri(link), folderBrowserDialog1.SelectedPath + "\\" + downloadFileName);

            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                string link = @"http://www.africau.edu/images/default/sample.pdf"; 
                string downloadFileName = Path.GetFileName("sample2.pdf");
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri(link), folderBrowserDialog1.SelectedPath + "\\" + downloadFileName); 
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                string link = @"http://www.africau.edu/images/default/sample.pdf";
                string downloadFileName = Path.GetFileName("sample2.pdf");
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri(link), folderBrowserDialog1.SelectedPath + "\\" + downloadFileName);
            }

            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                string link = @"http://www.africau.edu/images/default/sample.pdf";
                string downloadFileName = Path.GetFileName("sample3.pdf");
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri(link), folderBrowserDialog1.SelectedPath + "\\" + downloadFileName);
            }

        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                string error = e.Error.ToString();

                MessageBox.Show(error);
                return;
            }
            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                MessageBox.Show("Download completed!");
            }
        }
    }
}
