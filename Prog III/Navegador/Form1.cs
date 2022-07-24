using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + buscar.Text + "&hl=es-419&sxsrf=ALeKk033KFFPgIz8QyGYMW_hZOBm0JDvhg%3A1618246288807&source=hp&ei=kHp0YPe7L_TB5OUP74yp2AM&iflsig=AINFCbYAAAAAYHSIoN1Lwn2LzhUEBN9CKv2lTuDiYLiB&oq=" + buscar.Text + "&gs_lcp=Cgdnd3Mtd2l6EAMyBAgjECcyCgguEIcCELEDEBQyBAguEEMyBQgAELEDMgcILhCxAxBDMgcILhCxAxBDMgUIABCxAzIFCC4QsQMyBQguELEDMgUILhCxAzoHCCMQ6gIQJzoHCC4Q6gIQJzoECAAQQzoHCC4QhwIQFFD8FlijJWDcJ2gGcAB4AIABYIgBmwOSAQE1mAEAoAEBqgEHZ3dzLXdperABCg&sclient=gws-wiz&ved=0ahUKEwj3w86ZlfnvAhX0ILkGHW9GCjsQ4dUDCAc&uact=5");
        }

        private void AzulVB_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            AzulVB.BackColor = Color.Gray;
            RojoVB.BackColor = Color.Red;
            VerdeVB.BackColor = Color.Green;
        }

        private void RojoVB_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            RojoVB.BackColor = Color.Gray;
            AzulVB.BackColor = Color.Blue;
            VerdeVB.BackColor = Color.Green;
        }

        private void VerdeVB_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            RojoVB.BackColor = Color.Red;
            AzulVB.BackColor = Color.Blue;
            VerdeVB.BackColor = Color.Gray;
        }

        private void buttonver_Click(object sender, EventArgs e)
        {
            button1.Visible = !button1.Visible;
        }

        private void buttonir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(buscar.Text)) return;
            if (buscar.Equals("about:blank")) return;
            if (!buscar.Text.StartsWith("http://") &&
            !buscar.Text.StartsWith("https://"))
            {
                buscar.Text = "http://" + buscar.Text;
            }
            try
            {
                webBrowser1.Navigate(new Uri(buscar.Text));
            }
            catch
            {
                MessageBox.Show("Se produjo un error.");
            }

        }
    }
}
