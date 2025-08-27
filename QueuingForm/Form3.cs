using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class Form3 : Form
    {
        private Timer timer;
        public Form3()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                lblStudentNum.Text = CashierClass.CashierQueue.Peek();
            }
            else
            {
                lblStudentNum.Text = "No students in queue.";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
    }
}
