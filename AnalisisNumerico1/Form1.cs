using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Logica;
using Logica.Unidad2;
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
            cmb_Metodos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Pivoteo.DropDownStyle = ComboBoxStyle.DropDownList;
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
                            a.Location = new Point(pointX, pointY);
                            panel2.Controls.Add(a);
                            Label lbl = new Label();
                            lbl.Name = nombrelabel;
                            lbl.AutoSize = false;
                            lbl.Size = new System.Drawing.Size(30, 22);
                            switch (i)
                            {
                                case 1:
                                    lbl.Text = "x   +";
                                    lbl.Location = new Point(pointX + 55, pointY + 2);
                                    break;
                                case 2:
                                    lbl.Text = "y   +";
                                    lbl.Location = new Point(pointX + 55, pointY + 2);
                                    if (cantincognitas==2)
                                    {
                                        lbl.Text = "y   =";
                                    }
                                    break;
                                case 3:
                                    lbl.Text = "z   +";
                                    lbl.Location = new Point(pointX + 55, pointY + 2);
                                    if (cantincognitas == 3)
                                    {
                                        lbl.Text = "z   =";
                                    }
                                    if (cantincognitas == 2)
                                    {
                                        lbl.Visible = false;
                                    }
                                    break;
                                case 4:
                                    lbl.Text = "t   +";
                                    lbl.Location = new Point(pointX + 55, pointY + 2);
                                    if (cantincognitas == 4)
                                    {
                                        lbl.Text = "t   =";
                                    }
                                    if (cantincognitas == 3)
                                    {
                                        lbl.Visible = false;
                                    }
                                    break;
                                case 5:
                                    lbl.Text = "s   =";
                                    lbl.Location = new Point(pointX + 55, pointY + 2);
                                    if (cantincognitas == 4)
                                    {
                                        lbl.Visible = false;
                                    }
                                    break;
                            }
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
        private void Btn_Resolver_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            int cantincognitas = int.Parse(textBox1.Text);
            for (int i = 1; i <= cantincognitas + 1; i++)
            {
                for (int x = 1; x <= cantincognitas; x++)
                {
                    string nombre = "txt" + x + i;
                    Control[] m = panel2.Controls.Find(nombre, true);
                    if (m[0].Text.Trim() == string.Empty)
                    {
                        //m[0].BackColor = Color.Red;
                        bandera = false;
                    }
                }
            }
            if (!bandera)
                MessageBox.Show("campos en las ecuaciones vacios");
            else
            {
                string[] aux;
                double[,] matriz = new double[cantincognitas, cantincognitas + 1];
                for (int i = 0; i < cantincognitas; i++)
                {
                    for (int j = 0; j < cantincognitas + 1; j++)
                    {
                        string nom = "txt";
                        int x = j + 1;
                        int y = i + 1;
                        nom = nom + y + x;
                        Control[] m = panel2.Controls.Find(nom, true);
                        if (m[0].Text.Contains("/"))
                        {
                            aux = m[0].Text.Split(new char[] { '/' }, 2);
                            matriz[i, j] = double.Parse(aux[0]) / double.Parse(aux[1]);
                        }
                        else
                        {
                            matriz[i, j] = double.Parse(m[0].Text);
                        }
                    }
                }

                bool pivot = false;
                if (cmb_Pivoteo.Text == "Si")
                    pivot = true;

                Resultado_2 nuevo = new Resultado_2(true, "",cantincognitas,0);

                if (cmb_Metodos.SelectedIndex == 0)
                {
                    nuevo = Logica.Unidad2.Practico2.Gauss_Jordan(matriz, cantincognitas, pivot);
                }
                else
                {
                    if ((txt_Iter_Practico2.Text.Trim() == string.Empty))
                    {
                        MessageBox.Show("Por favor, ingrese un maximo de iteraciones");
                        txt_Iter_Practico2.BackColor = Color.Red;
                        nuevo.SePudo = false;
                    }
                    else
                    {
                        if (txt_Tole_Practico2.Text.Trim() == string.Empty)
                        {
                            MessageBox.Show("Por favor, ingrese una tolerancia");
                            txt_Tole_Practico2.BackColor = Color.Red;
                            nuevo.SePudo = false;
                        }
                        else
                            nuevo = Logica.Unidad2.Practico2.Gauss_Seidel(matriz, cantincognitas, 
                                        int.Parse(txt_Iter_Practico2.Text), double.Parse(txt_Tole_Practico2.Text), pivot);
                    }
                }

                if (nuevo.SePudo)
                    MostrarResultados(nuevo);
                else
                {
                    lbl_texto.Visible = true;
                    lbl_texto.Text = nuevo.Mensaje;
                    lbl_texto.Font = new Font(lbl_texto.Font.Name, 10);
                    panel2.Controls.Add(lbl_texto);
                }
                    
                
            }
        }  //ACA SE RESUELVEN LAS ECUACIONES
        public void MostrarResultados(Resultado_2 rdos)
        {
            string[] v = new string[5] { "x = ", "y = ", "z = ", "t = ", "s = " };
            lbl_texto.Visible = true;
            lbl_texto.Text = rdos.Mensaje;
            lbl_texto.Font = new Font(lbl_texto.Font.Name, 10);
            panel2.Controls.Add(lbl_texto);
            int pointX = 25;
            int pointY = 225;
            for (int i = 0; i < rdos.Resultados.Length; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl_Resultado_" + i;
                lbl.AutoSize = false;
                lbl.Size = new System.Drawing.Size(120, 17);
                lbl.Font = new Font(lbl.Font.Name, 10);
                lbl.Location = new Point(pointX, pointY);
                lbl.Text = v[i] + Math.Round(rdos.Resultados[i], 6);
                lbl.ForeColor = Color.Red;
                panel2.Controls.Add(lbl);
                panel2.Show();
                pointX += 120;
            }
            if (rdos.Iter != 0)
            {
                Label lbl = new Label();
                lbl.Name = "lbl_Iteraciones";
                lbl.AutoSize = false;
                lbl.Size = new System.Drawing.Size(200, 17);
                lbl.Font = new Font(lbl.Font.Name, 10);
                lbl.Location = new Point(25,250);
                lbl.Text = "Iteraciones Realizadas: " + rdos.Iter;
                lbl.ForeColor = Color.Green;
                panel2.Controls.Add(lbl);
                panel2.Show();
            }
        }   //ACA MOSTRAMOS LOS RESULTADOS OBTENIDOS EN PANTALLA


        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 47 && chr != 44 && chr != 45) //Cambiar el 44 por un 46 para que sea un .
            {
                e.Handled = true;
            }
        }//INGRSAR SOLO NUMEROS
        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }//PONE EL TEXTBOX EN BLANCO
        private void Txt_Iter_Practico2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }  //Solo numeros en iter 
        private void Cmb_Metodos_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Metodos.SelectedIndex == 0)
            {
                lbl_iteraciones_Practico2.Visible = false;
                txt_Iter_Practico2.Visible = false;
                lbl_Tole_Practico2.Visible = false;
                txt_Tole_Practico2.Visible = false;
            }
            else
            {
                lbl_iteraciones_Practico2.Visible = true;
                txt_Iter_Practico2.Visible = true;
                lbl_Tole_Practico2.Visible = true;
                txt_Tole_Practico2.Visible = true;
            }
            lbl_texto.Text.Replace(lbl_texto.Text, "");

        }//hacer visible el lbl y el txt de iter
        private void Txt_Iter_Practico2_Click(object sender, EventArgs e)
        {
            txt_Iter_Practico2.BackColor = Color.White;
        } //Pone el txt_iter en blanco
        private void Txt_Tole_Practico2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44)
            {
                e.Handled = true;
            }
        }
        private void Txt_Tole_Practico2_Click(object sender, EventArgs e)
        {
            txt_Tole_Practico2.BackColor = Color.White;
        }




        // ----------------------------------------------   PRACTICO 3    --------------------------------------------------//

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double[] vectorX = new double[100];
            double[] vectorY = new double[100];


            int sum2x = 0; //SUMATORIA DE X AL CUADRADO
            int sumx = 0; //SUMATORIA DE X
            int x = 0;
            int contador = 0;
            foreach (DataGridViewRow row in dgvXeY.Rows)
            {
                contador += 1;
                string codigo = Convert.ToString(row.Cells["X"].Value);
                vectorX[contador] = double.Parse(codigo);
                sumx += x;
                sum2x += x * x;
            }

            int sumy = 0; //SUMATORIA DE Y
            int y = 0;
            contador = 0;
            foreach (DataGridViewRow row in dgvXeY.Rows)
            {
                contador += 1;
                string codigo = Convert.ToString(row.Cells["Y"].Value);
                vectorY[contador] = double.Parse(codigo);
                sumy += y;
            }

            double promy = sumy / dgvXeY.Columns.Count;
            double promx = sumx / dgvXeY.Columns.Count;

            double sum_multi = 0; //SUMATORIA DE X * Y

            foreach (DataGridViewRow row in dgvXeY.Rows)
            {
                string codigo = Convert.ToString(row.Cells["X"].Value);
                x = int.Parse(codigo);
                foreach (DataGridViewRow row2 in dgvXeY.Rows)
                {
                    
                    string codigo_2 = Convert.ToString(row2.Cells["Y"].Value);
                    y = int.Parse(codigo);

                    if (row2 == row)
                    {
                        double multiplicacion = x * y;
                        sum_multi += multiplicacion;
                    }
                    
                }

            }
        }
    }
}
