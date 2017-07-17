using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı;
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {

            int mesajsayısı = 0;
            mesajsayısı = int.Parse(textBox6.Text);
            for (int i = 0; i < mesajsayısı; i++)
            {
                sayı = r.Next(10000, 90000);
                MailMessage mesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential(textBox3.Text, textBox4.Text);
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                mesaj.To.Add(textBox2.Text);
                mesaj.From = new MailAddress("sinanacar14654@hotmail.com");
                mesaj.Subject = textBox5.Text;
                mesaj.Body = textBox1.Text;
                istemci.Send(mesaj);
            }

        }
    }
}
