using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLib;



namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string komy = textBox1.Text;
            string tema = textBox2.Text;
            string sms=textBox3.Text;

             MLiB lib = new MLiB();
            lib.MailGo(komy,tema,sms);

        }
    
    }
}
