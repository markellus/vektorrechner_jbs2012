using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Ionic.Zip;

namespace Updater
{
    public partial class Form1 : Form
    {
        bool Updatefertig = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bwDownload.RunWorkerAsync();
        }

        private void bwDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            DelegateStatusTextAktualisieren textAktualisieren = new DelegateStatusTextAktualisieren(AktualisiereStatus);

            string curDir = Directory.GetCurrentDirectory();
            txtStatus.Invoke(textAktualisieren, "Prüfe auf Updates...");
            System.Net.WebClient client = new System.Net.WebClient();
            byte[] tmpB = client.DownloadData("http://127.0.0.1/status.txt");//Url einfügen
            txtStatus.Invoke(textAktualisieren, "Download wird gestartet");
            string downloadlink = System.Text.Encoding.ASCII.GetString(tmpB);
            downloadFile(downloadlink);
            while (!Updatefertig) { }
            ZipFile zip = ZipFile.Read(curDir + "/UpdatePacket.zip");
            File.Move(curDir + "/Updater.exe", curDir + "/Updater.old.exe");
            zip.ExtractAll(curDir);
            txtStatus.Invoke(textAktualisieren, "Update abgeschlossen.");
        }

        private void downloadFile(string addresse)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadDataAsync(new Uri(addresse));
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DelegateProgressbarAktualisieren myProgress = new DelegateProgressbarAktualisieren(AktualisiereProgressbar);           
            progressBar1.Invoke(myProgress, e.ProgressPercentage);
        }

        private void Completed(object sender, DownloadDataCompletedEventArgs e)
        {
            DelegateStatusTextAktualisieren textAktualisieren = new DelegateStatusTextAktualisieren(AktualisiereStatus);
            txtStatus.Invoke(textAktualisieren, "Download abgeschlossen");
            File.WriteAllBytes(Directory.GetCurrentDirectory() + "/UpdatePacket.zip", e.Result);
            txtStatus.Invoke(textAktualisieren, "Das Update wurde als \"UpdatePacket.zip\" gespeichert.");
            Updatefertig = true;
        }

        private delegate void DelegateStatusTextAktualisieren(string value);
        private void AktualisiereStatus(string value)
        {
            txtStatus.Text += value + "\r\n";
        }

        private delegate void DelegateProgressbarAktualisieren(int value);
        private void AktualisiereProgressbar(int value)
        {
            progressBar1.Value = value;
        }

        private delegate void Delegatefertig();
        private void fertig()
        {
            Updatefertig = true;
        }
    }
}
