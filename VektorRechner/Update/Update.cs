using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;

namespace VektorRechner.Update
{
    public static class Update
    {   //prüft auf Updates und fragt, ob diese installiert weren sollen.
        public static void AufUpdatesPrüfen(int version)
        {
            WebClient client = new WebClient();
            try
            {
                byte[] neueVersion = client.DownloadData("");//TODO: Link einfügen
                int neueVersionKonvertiert = Convert.ToInt32(Encoding.ASCII.GetString(neueVersion));

                if (neueVersionKonvertiert > version)
                {
                    if (MessageBox.Show("Es ist eine neue Version verfügbar. Downloaden?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("Updater.exe");
                        Application.Exit();
                    }
                }
            }
            catch (WebException ex)
            {
                //sinnvoll?
                MessageBox.Show("Überprüfung auf Updates fehlgeschlagen");
            }
        }
    }
}
