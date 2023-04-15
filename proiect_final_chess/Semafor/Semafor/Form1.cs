using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafor
{
    public partial class Form1 : Form
    {
        static WinApiClass.SECURITY_ATTRIBUTES secAtri = new WinApiClass.SECURITY_ATTRIBUTES();
        static IntPtr handlerSemafor=WinApiClass.CreateSemaphore(ref secAtri, 5, 5, "Semafor");
        static uint dwmiliseconds = 300;
        static IntPtr dwSemCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttForm_Click(object sender, EventArgs e)
        {
            UInt32 dwWaitResult;
            dwWaitResult = WinApiClass.WaitForSingleObject(handlerSemafor, dwmiliseconds);
            switch (dwWaitResult)
            {
                case WinApiClass.WAIT_OBJECT_0:
                   
                    var f2 = new Form2();
                    f2.Show();
                    break;
                case WinApiClass.WAIT_TIMEOUT:
                    MessageBox.Show("e maxim");
                    break;
            }
        
    }

        private void buttForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(textBox1.Text);
            WinApiClass.SECURITY_ATTRIBUTES atribut = new WinApiClass.SECURITY_ATTRIBUTES();
            IntPtr semafor = WinApiClass.CreateSemaphore(ref atribut, count, count, "semafor");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
