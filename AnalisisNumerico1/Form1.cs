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
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// ------------------------------------------     PRACTICO 1    ----------------------------------------------------------// 

        private void btnObtener_1_Click(object sender, EventArgs e)
        {
            if ((txt_Iter.Text.Trim() == string.Empty) || (txt_Tole.Text.Trim() == string.Empty) ||
                (txt_LI.Text.Trim() == string.Empty) || (txt_LD.Text.Trim() == string.Empty) || (txt_Funcion.Text.Trim() == string.Empty))
            {
                if ((txt_Iter.Text.Trim() == string.Empty))
                    txt_Iter.BackColor = Color.Red;
                if ((txt_Tole.Text.Trim() == string.Empty))
                    txt_Tole.BackColor = Color.Red;
                if ((txt_LI.Text.Trim() == string.Empty))
                    txt_LI.BackColor = Color.Red;
                if ((txt_LD.Text.Trim() == string.Empty))
                    txt_LD.BackColor = Color.Red;
                if ((txt_Funcion.Text.Trim() == string.Empty))
                    txt_Funcion.BackColor = Color.Red;
                MessageBox.Show("Campos Vacios");
            }
            else
            {
                Resultado nuevo = Logica.Unidad1.Actividad1.Biseccion(txt_Funcion.Text, int.Parse(txt_Iter.Text),
                        double.Parse(txt_Tole.Text), float.Parse(txt_LI.Text), float.Parse(txt_LD.Text));
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
        }  // OBTENER CON EL METODO DE BISECCION

        private void BtnObtener_2_Click_1(object sender, EventArgs e)
        {
            if ((txt_Iter.Text.Trim() == string.Empty) || (txt_Tole.Text.Trim() == string.Empty) ||
                (txt_LI.Text.Trim() == string.Empty) || (txt_LD.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Campos Vacios");
                if ((txt_Iter.Text.Trim() == string.Empty))
                    txt_Iter.BackColor = Color.Red;
                if ((txt_Tole.Text.Trim() == string.Empty))
                    txt_Tole.BackColor = Color.Red;
                if ((txt_LI.Text.Trim() == string.Empty))
                    txt_LI.BackColor = Color.Red;
                if ((txt_LD.Text.Trim() == string.Empty))
                    txt_LD.BackColor = Color.Red;
            }
            else
            {
                Resultado nuevo = Logica.Unidad1.Actividad1.ReglaFalsa(txt_Funcion.Text, int.Parse(txt_Iter.Text), double.Parse(txt_Tole.Text),
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
        } //OBTENER CON EL METODO DE LA REGLA FALSA.
        
        private void BtnObtener_3_Click_1(object sender, EventArgs e)
        {
            if ((txt_Iter.Text.Trim() == string.Empty) || (txt_Tole.Text.Trim() == string.Empty) ||
                (txt_LI.Text.Trim() == string.Empty) || (txt_Funcion.Text.Trim() == string.Empty))
            {
                if ((txt_Iter.Text.Trim() == string.Empty))
                    txt_Iter.BackColor = Color.Red;
                if ((txt_Tole.Text.Trim() == string.Empty))
                    txt_Tole.BackColor = Color.Red;
                if ((txt_LI.Text.Trim() == string.Empty))
                    txt_LI.BackColor = Color.Red;
                if ((txt_LD.Text.Trim() == string.Empty))
                    txt_LD.BackColor = Color.Red;
                if ((txt_Funcion.Text.Trim() == string.Empty))
                    txt_Funcion.BackColor = Color.Red;
                MessageBox.Show("Campos Vacios");
            }
            else
            {
                Resultado nuevo = Logica.Unidad1.Actividad1.Tangente(txt_Funcion.Text, int.Parse(txt_Iter.Text),
                        double.Parse(txt_Tole.Text), float.Parse(txt_LI.Text));
                if (!nuevo.SePudo)
                {
                    MessageBox.Show(nuevo.Mensaje);
                }
                else
                {
                    lbl_Ite_3.Text = nuevo.Iter.ToString();
                    lbl_Tole_3.Text = nuevo.Tole.ToString();
                    lbl_Solu_3.Text = nuevo.Solucion.ToString();
                }
            }
        }//OBTENER CON EL METODO DE LA TANGENTE

        private void BtnObtener_4_Click_1(object sender, EventArgs e) //OBTENER CON EL METODO DE LA SECANTE
        {
            if ((txt_Iter.Text.Trim() == string.Empty) || (txt_Tole.Text.Trim() == string.Empty) ||
                (txt_LI.Text.Trim() == string.Empty) || (txt_LD.Text.Trim() == string.Empty) || (txt_Funcion.Text.Trim() == string.Empty))
            {
                if ((txt_Iter.Text.Trim() == string.Empty))
                    txt_Iter.BackColor = Color.Red;
                if ((txt_Tole.Text.Trim() == string.Empty))
                    txt_Tole.BackColor = Color.Red;
                if ((txt_LI.Text.Trim() == string.Empty))
                    txt_LI.BackColor = Color.Red;
                if ((txt_LD.Text.Trim() == string.Empty))
                    txt_LD.BackColor = Color.Red;
                if ((txt_Funcion.Text.Trim() == string.Empty))
                    txt_Funcion.BackColor = Color.Red;
                MessageBox.Show("Campos Vacios");
            }
            else
            {
                Resultado nuevo = Logica.Unidad1.Actividad1.Secante(txt_Funcion.Text, int.Parse(txt_Iter.Text),
                        double.Parse(txt_Tole.Text), float.Parse(txt_LI.Text), float.Parse(txt_LD.Text));
                if (!nuevo.SePudo)
                {
                    MessageBox.Show(nuevo.Mensaje);
                }
                else
                {
                    lbl_Iter_4.Text = nuevo.Iter.ToString();
                    lbl_Tole_4.Text = nuevo.Tole.ToString();
                    lbl_Solucion_4.Text = nuevo.Solucion.ToString();
                }
            }
        }


        private void Txt_LI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44 && chr != 45)
            {
                e.Handled = true;
                //MessageBox.Show("Solo Numeros");
            }
        } //CON ESTO CONTROLO QUE SOLO SE INGRESEN NUMEROS
        private void Txt_LD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44 && chr != 45)
            {
                e.Handled = true;
            }
        } //SOLO NUMEROS
        private void Txt_Tole_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44) // Cambiar por el 44 por 46 para que sea un .
            {
                e.Handled = true;
            }
        }//SOLO NUMEROS
        private void Txt_Iter_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }//SOLO NUMEROS



        private void Txt_Tole_Click(object sender, EventArgs e)
        {
            txt_Tole.BackColor = Color.White;
        } //PONE EL TEXTBOX EN BLANCO
        private void Txt_Iter_Click(object sender, EventArgs e)
        {
            txt_Iter.BackColor = Color.White;
        } //PONE EL TEXTBOX EN BLANCO
        private void Txt_LI_Click(object sender, EventArgs e)
        {
            txt_LI.BackColor = Color.White;
        }  //PONE EL TEXTBOX EN BLANCO
        private void Txt_LD_Click(object sender, EventArgs e)
        {
            txt_LD.BackColor = Color.White;
        }  //PONE EL TEXTBOX EN BLANCO
        private void Txt_Funcion_Click(object sender, EventArgs e)
        {
            txt_Funcion.BackColor = Color.White;
        }  // PONE EL TEXTBOX EN BLANCO



        // ------------------------------------------     PRACTICO 2     ----------------------------------------------------------// 

        private void button1_Click(object sender, EventArgs e) //ACA SE GENERAN LAS ECUACIONES
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("No se ha ingresado un numero de ecuaciones.");
            }
            else
            {
                int cantincognitas = int.Parse(textBox1.Text);
                int pointX = 30;
                int pointY = 40;
                panel2.Controls.Clear();
                if ((cantincognitas >= 2) && (cantincognitas <= 5))
                {
                    for (int i = 1; i <= cantincognitas + 1; i++)
                    {
                        pointY = 40;
                        for (int x = 1; x <= cantincognitas; x++)
                        {
                            string nombretxt = "txt" + x + i;
                            string nombrelabel = "lbl" + x + i;
                            TextBox a = new TextBox();
                            a.AutoSize = false;
                            a.Size = new System.Drawing.Size(50, 22);
                            a.Name = nombretxt;
                            //a.Text = (x + 1).ToString() + (i + 1).ToString();
                            a.Location = new Point(pointX, pointY);
                            Label lbl = new Label();
                            lbl.Name = nombrelabel;
                            switch(i)
                            {
                                case 1:
                                    lbl.Text = "x +";
                                    lbl.Location = new Point(pointX + 55, pointY);
                                    break;
                                case 2:
                                    lbl.Text = "y +";
                                    break;
                                case 3:
                                    lbl.Text = "z +";
                                    break;
                                case 4:
                                    lbl.Text = "t +";
                                    break;
                                case 5:
                                    lbl.Text = "s =";
                                    break;
                            }
                            panel2.Controls.Add(a);
                            panel2.Controls.Add(lbl);
                            panel2.Show();

                            pointY += 30;
                            a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
                        }
                        pointX += 90;
                    }
                    btn_Resolver.Visible = true;
                }
                else
                    MessageBox.Show("Ingrese una cantidad de incognitas adecuada");
            }
            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }//INGRSAR SOLO NUMEROS

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }//PONE EL TEXTBOX EN BLANCO
    }
}
