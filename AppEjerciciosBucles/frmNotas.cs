using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosBucles
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.lstNotas.Sorted = false;
            this.lstNotas.Items.Clear();
            for (int i = 0; i <= 30; i++)
            {
                int num = r.Next(20, 50);
                this.lstNotas.Items.Add(num);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lstNotas.Text = "";
        }
    }
}
