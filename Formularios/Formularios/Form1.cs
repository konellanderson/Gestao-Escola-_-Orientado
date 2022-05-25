using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidade;
using CapaDeNegocio;

namespace Formularios
{
    public partial class Form1 : Form
    {
        ClasseNegocio clsuser = new ClasseNegocio();
        ClasseEntidade clsent = new ClasseEntidade();
        public static string usuario_nome;
        public static string id_tipo;
        public static string usuario_geral;
        public static string usuario_Codigo;

        Frmprincipal f = new Frmprincipal();
                public Form1()
        {
            InitializeComponent();
        }
        
        private void Limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
