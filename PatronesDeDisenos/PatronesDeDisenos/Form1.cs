using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatronesDeDisenos.StateMethod;
using PatronesDeDisenos.TemplateMethod;

namespace PatronesDeDisenos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static RichTextBox salida;

        private void button1_Click(object sender, EventArgs e)
        {
            this.OutPut.Text = "";
            String entrada = Entrada.Text;

            salida = OutPut;
            Estatico.t = salida;
            Context contexto = new Context();

            Estado_0 e0 = new Estado_0(0, entrada, "");

            e0.Reconocer(contexto); //RECONOCE

            

        }

        private void Entrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
