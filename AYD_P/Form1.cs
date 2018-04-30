using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AYD_P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean validado = false;
            Console.WriteLine("hola que hace");
            MessageBox.Show("hola que hace x2");

            validado =  validar_login("usuario", "contraseña");

        }

        public Boolean validar_login(string a, string b)
        {

            if(a=="usuario"&& b == "contraseña")
            {
                return true;

            }
            return false;
        }

        public double consultar_saldo(string nombre)
        {
            if (nombre == "usuario")
            {

                return 800;
            }
            else {

                return -1;
            }


        }
    }
}
