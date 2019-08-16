using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Logica;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void TxtFuncion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnObtener_1_Click(object sender, EventArgs e)
        {
            Resultado nuevo = Logica.Unidad1.Actividad1.Biseccion(int.Parse(txt_Iter.Text), double.Parse(txt_Tole.Text),
                    float.Parse(txt_LI.Text), float.Parse(txt_LD.Text));
            if (!nuevo.SePudo)
            {
                MessageBox.Show(nuevo.Mensaje);
            }
            else
            {
                lbl_Iter_1.Text = nuevo.Iter.ToString();
                lbl_Tole_1.Text = nuevo.Tole.ToString();
                lbl_Solucion_1.Text = nuevo.Solucion.ToString();
            }
        }

        private void BtnObtener_2_Click(object sender, EventArgs e)
        {
            Resultado nuevo = Logica.Unidad1.Actividad1.ReglaFalsa(int.Parse(txt_Iter.Text), double.Parse(txt_Tole.Text),
                    float.Parse(txt_LI.Text), float.Parse(txt_LD.Text));
            if (!nuevo.SePudo)
            {
                MessageBox.Show(nuevo.Mensaje);
            }
            else
            {
                lbl_Ite_2.Text = nuevo.Iter.ToString();
                lbl_Tole_2.Text = nuevo.Tole.ToString();
                lbl_Solu_2.Text = nuevo.Solucion.ToString();
            }
        }
    }
}
