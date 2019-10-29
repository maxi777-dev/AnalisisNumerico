using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Logica;
using Logica.Unidad2;
using Logica.Unidad4;
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
            cmb_Lagrange.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_metodos_tp4.DropDownStyle = ComboBoxStyle.DropDownList;
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
                                    if (cantincognitas == 2)
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

                Resultado_2 nuevo = new Resultado_2(true, "", cantincognitas, 0);

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
                lbl.Location = new Point(25, 250);
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

        const int max_grado = 5;

        public void MostrarResultadosMC(Resultado_2 rdos)
        {
            string[] v = new string[6] { "a0 = ", "a1 = ", "a2 = ", "a3 = ", "a4 = ", "a5 = " };
            lbl_textoMC.Visible = true;
            lbl_textoMC.Text = rdos.Mensaje;
            lbl_textoMC.Font = new Font(lbl_textoMC.Font.Name, 10);
            panel3.Controls.Add(lbl_textoMC);
            int pointX = 25;
            int pointY = 55;
            if (rdos.SePudo != false)
            {
                for (int i = 0; i < rdos.Resultados.Length; i++)
                {
                    Label lbl = new Label();
                    lbl.Name = "lbl_Resultado_" + i;
                    lbl.AutoSize = false;
                    lbl.Size = new System.Drawing.Size(80, 17);
                    lbl.Font = new Font(lbl.Font.Name, 8);
                    lbl.Location = new Point(pointX, pointY);
                    lbl.Text = v[i] + Math.Round(rdos.Resultados[i], 6);
                    lbl.ForeColor = Color.Red;
                    panel3.Controls.Add(lbl);
                    panel3.Show();
                    pointX += 100;
                }
                lbl_coeficiente.Text = "Coeficiente de correlación = " + rdos.valorcoeficiente;
                lbl_coeficiente.Visible = true;
            }
        }
        public void MostrarResultadosLagrange(Resultado_2 rdos, double x)
        {
            lbl_coeficiente.Text = $"El valor de Lagrange obtenido, con un valor de {x} para X es:";
            lbl_coeficiente.Visible = true;
            //panel3.Controls.Add(label6);
            lbl_textoMC.AutoSize = false;
            lbl_textoMC.Size = new System.Drawing.Size(120, 17);
            lbl_textoMC.Font = new Font(label5.Font.Name, 10);
            //lbl_textoMC.Location = new Point(25,55);
            lbl_textoMC.Text = $"P({x}): " + Math.Round(rdos.Resultados[0], 6);
            lbl_textoMC.ForeColor = Color.Red;
            lbl_textoMC.Visible = true;
            panel3.Controls.Add(lbl_textoMC);
            panel3.Show();
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            for (int i = panel3.Controls.Count - 1; i >= 0; i--)
            {
                Label label = panel3.Controls[i] as Label;
                if ((label != null) && (label.Name != "lbl_textoMC"))
                {
                    panel3.Controls.RemoveAt(i);
                    label.Dispose();
                }
            }

            lbl_coeficiente.Visible = false;
            panel3.Update();
            panel3.Refresh();

            double[] vectorX = new double[15];
            double[] vectorY = new double[15];

            //Vector de valores x
            int contador = -1;
            foreach (DataGridViewRow row in dgvXeY.Rows)
            {
                contador += 1;
                string codigo = Convert.ToString(row.Cells["X"].Value);
                if (codigo != "")
                { vectorX[contador] = double.Parse(codigo); }
            }
            int grad = contador - 1;

            //Vector de valores y
            contador = -1;
            foreach (DataGridViewRow row in dgvXeY.Rows)
            {
                contador += 1;
                string codigo = Convert.ToString(row.Cells["Y"].Value);
                if (codigo != "")
                { vectorY[contador] = double.Parse(codigo); }
            }

            bool bandera_lagrange = false;
            double valor_lagrange = 0;
            
            if (cmb_Lagrange.Text == "Si")
            {
                bandera_lagrange = true;
                valor_lagrange = double.Parse(txt_valor_lagrange.Text);
            }
            else
            { grad = int.Parse(txt_Grado.Text); }

            if (bandera_lagrange)
            {
                Resultado_2 res = Logica.Unidad3.Practico3.Lagrange(vectorX, vectorY, valor_lagrange, grad);
                MostrarResultadosLagrange(res, valor_lagrange);
            }
            else
            {
                Resultado_2 res = new Resultado_2(true, "Ajuste no aceptable para polinomios de grado mayor a " + (max_grado), 0, 50);
                while (grad < max_grado + 1 & (res.valorcoeficiente < int.Parse(txt_TP3_Tolerancia.Text)) & res.SePudo == true)
                {
                    res = Logica.Unidad3.Practico3.ResolucionMC(vectorX, vectorY, contador, grad + 1, max_grado);
                    if (res.valorcoeficiente >= int.Parse(txt_TP3_Tolerancia.Text))
                    { res.Mensaje = "Los valores son:"; }
                    else { grad += 1; }
                }
                if (grad == max_grado + 1)
                { res.SePudo = false; }
                MostrarResultadosMC(res);
            }
        }


        private void Cmb_Lagrange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Lagrange.Text == "No")
            {
                lbl_valor_lagrange.Visible = false;
                txt_valor_lagrange.Visible = false;
                label5.Visible = true;
                txt_Grado.Visible = true;
                label10.Visible = true;
                txt_TP3_Tolerancia.Visible = true;
            }
            else
            {
                lbl_valor_lagrange.Visible = true;
                txt_valor_lagrange.Visible = true;
                label5.Visible = false;
                txt_Grado.Visible = false;
                label10.Visible = false;
                txt_TP3_Tolerancia.Visible = false;
            }
        }
        private void Txt_Grado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
        private void Txt_TP3_Tolerancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44) // Cambiar por el 44 por 46 para que sea un .
            {
                e.Handled = true;
            }
        }
        private void Txt_valor_lagrange_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44 && chr != 45)
            {
                e.Handled = true;
            }
        }

        // -----------------------------------------   PRÁCTICO 4   -------------------------------------------------------//
        private void Btn_obtener_tp4_Click(object sender, EventArgs e)
        {
            if (txt_funcion_TP4.Text.Trim() == string.Empty || txt_a_tp4.Text.Trim() == string.Empty ||
                        txt_b_tp4.Text.Trim() == string.Empty || ((cmb_metodos_tp4.Text == "Trapecio Múltiple" ||
                                cmb_metodos_tp4.Text == "Simpson 1/3 Múltiple") && txt_n_tp4.Text.Trim() == string.Empty))
            {
                if (txt_funcion_TP4.Text.Trim() == string.Empty)
                    txt_funcion_TP4.BackColor = Color.Red;
                if (txt_a_tp4.Text.Trim() == string.Empty)
                    txt_a_tp4.BackColor = Color.Red;
                if (txt_b_tp4.Text.Trim() == string.Empty)
                    txt_b_tp4.BackColor = Color.Red;
                if (txt_n_tp4.Text.Trim() == string.Empty)
                    txt_n_tp4.BackColor = Color.Red;
                MessageBox.Show("Por favor ingrese todos los datos");
            }
            else
            {
                string funcion = txt_funcion_TP4.Text;
                double a = double.Parse(txt_a_tp4.Text);
                double b = double.Parse(txt_b_tp4.Text);
                int n = 0;
                if (txt_n_tp4.Text.Trim() != string.Empty)
                { n = int.Parse(txt_n_tp4.Text); }

                Resultado_4 nuevo = new Resultado_4("",true);
                switch (cmb_metodos_tp4.SelectedIndex)
                {
                    case 0:
                        nuevo = Practico4.Trapecio_Simple(funcion, a, b);
                        break;
                    case 1:
                        nuevo = Practico4.Trapecio_Multiple(funcion, a, b, n);
                        break;
                    case 2:
                        nuevo = Practico4.Un_Tercio_Simple(funcion, a, b);
                        break;
                    case 3:
                        if (n % 2 != 0)
                        {
                            double h = (b - a) / n;
                            double Xnmenos3 = b - (3 * h);
                            nuevo = Practico4.Un_Tercio_Multiple(funcion, a, Xnmenos3, n - 3);
                            Resultado_4 nuevo2 = Practico4.Tres_Octavos(funcion, Xnmenos3, b);
                            nuevo.Solucion += nuevo2.Solucion;
                        }
                        else
                        { nuevo = Practico4.Un_Tercio_Multiple(funcion, a, b, n); }                        
                        break;
                    case 4:
                        nuevo = Practico4.Tres_Octavos(funcion, a, b);
                        break;
                }
                MostrarResultadoTP4(nuevo);
            }
        }
        public void MostrarResultadoTP4(Resultado_4 rdos)
        {
            lbl_mensaje_tp4.Visible = true;
            lbl_mensaje_tp4.Text = rdos.Mensaje;
            lbl_mensaje_tp4.Font = new Font(lbl_textoMC.Font.Name, 10);
            panel_tp4.Controls.Add(lbl_mensaje_tp4);
            lbl_rdo_tp4.AutoSize = false;
            lbl_rdo_tp4.Size = new System.Drawing.Size(120, 17);
            lbl_rdo_tp4.Font = new Font(lbl_rdo_tp4.Font.Name, 10);
            //lbl_rdo_tp4.Location = new Point(pointX, pointY);
            lbl_rdo_tp4.Text = Math.Round(rdos.Solucion, 5).ToString() + " V.A";
            lbl_rdo_tp4.ForeColor = Color.Red;
            lbl_rdo_tp4.Visible = true;
            panel_tp4.Controls.Add(lbl_rdo_tp4);
            panel_tp4.Update();
            panel_tp4.Refresh();
            panel_tp4.Show();
        }



        private void Cmb_metodos_tp4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_metodos_tp4.Text == "Trapecio Simple" || cmb_metodos_tp4.Text == "Simpson 1/3 Simple" || 
                            cmb_metodos_tp4.Text == "Simpson 3/8 Simple")
            {
                lbl_n_tp4.Visible = false;
                txt_n_tp4.Visible = false;
            }
            else
            {
                lbl_n_tp4.Visible = true;
                txt_n_tp4.Visible = true;
                txt_n_tp4.BackColor = Color.White;
            }
        }
        private void Txt_n_tp4_Click(object sender, EventArgs e)
        {
            txt_n_tp4.BackColor = Color.White;
        }
        private void Txt_funcion_TP4_Click(object sender, EventArgs e)
        {
            txt_funcion_TP4.BackColor = Color.White;
        }
        private void Txt_a_tp4_Click(object sender, EventArgs e)
        {
            txt_a_tp4.BackColor = Color.White;
        }
        private void Txt_b_tp4_Click(object sender, EventArgs e)
        {
            txt_b_tp4.BackColor = Color.White;
        }
        private void Txt_a_tp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44 && chr != 45)
            {
                e.Handled = true;
                //MessageBox.Show("Solo Numeros");
            }
        }
        private void Txt_b_tp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 44 && chr != 45)
            {
                e.Handled = true;
                //MessageBox.Show("Solo Numeros");
            }
        }
        private void Txt_n_tp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_funcion_TP4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 44)
            {
                e.Handled = true;
            }
        }
    }
}
