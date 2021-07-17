using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace pp
{
    
    
    public partial class Form1 : Form
    {
        Mem m = new Mem();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { m.WriteMemory("Battles-Win.exe+0x50D1F9", "byte", "0"); }
            if (checkBox1.Checked == false) { m.WriteMemory("Battles-Win.exe+0x50D1F9", "byte", "1"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName("Battles-Win");
            if (PID > 0) { m.OpenProcess(PID); }
        }
    }
}
