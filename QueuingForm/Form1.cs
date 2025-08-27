using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class Queui : Form
    {
        private CashierClass cashier;

        public Queui()
        {
            InitializeComponent();

            cashier = new CashierClass();

            Form2 cashierForm = new Form2();
            cashierForm.Show();

            Form3 customerForm = new Form3();
            customerForm.Show();

        }

        private void Queui_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashierClass cashier = new CashierClass();

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }
    }
}
