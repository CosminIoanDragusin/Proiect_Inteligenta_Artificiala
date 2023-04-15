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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            IntPtr prefCont=new IntPtr();
            IntPtr variabila=WinApiClass.OpenSemaphore(0x0002,false, "Semafor");
            WinApiClass.ReleaseSemaphore(variabila,1, prefCont);
        }
    }
}
