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
            string msg;
            long nota = estudiantes(out msg);
            if (msg.Length == 0)
            {
                this.textBox2.Text = nota.ToString();
            }
            else
                this.textBox2.Text = msg;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lstNotas.Text = "";
        }
        private long estudiantes(out string msg)
        {
            msg = "";
            Random r = new Random();
            this.lstNotas.Sorted = false;
            this.lstNotas.Items.Clear();
            int suma = 0,pro;
            for (int i = 0; i <= 30; i++)
            {
                int num = r.Next(20, 50);
                this.lstNotas.Items.Add(i+1+". "+num);
                suma = suma + num;
            }
            msg = "La suma es: " + suma;
            pro = suma / 30;
            this.textBox1.Text = pro.ToString();
            return pro;
        }
}
}
