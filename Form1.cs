using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Individual_Simulacion
{
    public partial class Form1 : Form
    { 
        // Eliam Jesus Vazquez Parra a 07 de Junio del 2022
        //Variables
        int Cont = 1; // Contador para los Intentos
        int Turno;
        float Apuesta;
        float ganancia;
        float PorBN;// % Bolas Negras
        float ProbaBN; // Probabilidad de Bolas Negras
        float PorBR; // % Bolas Rojas 
        float ProbaBR; // Probabilidad de Bolas Rojas

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxBolasRojas.Focus();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //Se limpian los Textbox y el DataGridView
            Cont = 1;
            dgvMain.Rows.Clear();
            tbxBolasRojas.Text = "";
            tbxBolasNegras.Text = "";
            tbxApuesta.Text = "";
            tbxDinero.Text = "";
            tbxResTurno.Text = "";
            tbxTurno.Text = "";
            tbxGanancia.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float a, c, Xo, M, n, Pseudoaleatorio, PseudoPasado;
            int BolasNegras, BolasRojas, TotalBolas;

            // Asignacion de Variables
            Turno = Convert.ToInt32(tbxTurno.Text);
            Apuesta = Convert.ToSingle(tbxApuesta.Text);
            BolasRojas = Convert.ToInt32(tbxBolasRojas.Text);
            BolasNegras = Convert.ToInt32(tbxBolasNegras.Text);
            TotalBolas = BolasRojas + BolasNegras;
            a = Convert.ToSingle(tbxA.Text);
            c = Convert.ToSingle(tbxC.Text);
            M = Convert.ToSingle(tbxM.Text);
            Xo = Convert.ToSingle(tbxXo.Text);
            

            // Calcular porcentaje de que salgan las bolas
            PorBR = BolasRojas * 100 / TotalBolas;
            PorBN = BolasNegras * 100 / TotalBolas;

            // Calcular probabilidad de que salgan las bolas
            ProbaBR = BolasRojas / TotalBolas;
            ProbaBN = BolasNegras / TotalBolas;

            // Primer intento
            n = (a * Xo + c) % M;
            Pseudoaleatorio = n / M;

            // Condicion de que bolas hay mas
            if (BolasRojas >= BolasNegras)
            {
                if (Pseudoaleatorio <= ProbaBN)
                {
                    //Se resta la bola extraida
                    TotalBolas = TotalBolas - 1;
                    BolasNegras = BolasNegras - 1;
                    // Se calcula el nuevo porcentaje de las bolas.
                    PorBR = BolasRojas * 100 / TotalBolas;
                    PorBN = BolasNegras * 100 / TotalBolas;
                    dgvMain.Rows.Add(Cont.ToString(), Math.Round(Pseudoaleatorio, 5).ToString(), TotalBolas.ToString(), BolasRojas.ToString(), PorBR.ToString() + " %", BolasNegras.ToString(), PorBN.ToString() + " %", "Bola Negra");
                }
                else
                {
                    //Se resta la bola extraida
                    TotalBolas = TotalBolas - 1;
                    BolasRojas = BolasRojas - 1;
                    // Se calcula el nuevo porcentaje de las bolas.
                    PorBR = BolasRojas * 100 / TotalBolas;
                    PorBN = BolasNegras * 100 / TotalBolas;
                    dgvMain.Rows.Add(Cont.ToString(), Math.Round(Pseudoaleatorio, 5).ToString(), TotalBolas.ToString(), BolasRojas.ToString(), PorBR.ToString() + " %", BolasNegras.ToString(), PorBN.ToString() + " %", "Bola Roja");
                }
            }
            else if (BolasRojas <= BolasNegras)
            {
                if (Pseudoaleatorio <= ProbaBR)
                {
                    //Se resta la bola extraida
                    TotalBolas = TotalBolas - 1;
                    BolasRojas = BolasRojas - 1;
                    // Se calcula el nuevo porcentaje de las bolas.
                    PorBR = BolasRojas * 100 / TotalBolas;
                    PorBN = BolasNegras * 100 / TotalBolas;
                    dgvMain.Rows.Add(Cont.ToString(), Math.Round(Pseudoaleatorio, 5).ToString(), TotalBolas.ToString(), BolasRojas.ToString(), PorBR.ToString() + " %", BolasNegras.ToString(), PorBN.ToString() + " %", "Bola Roja");
                }
                else
                {
                    //Se resta la bola extraida
                    TotalBolas = TotalBolas - 1;
                    BolasNegras = BolasNegras - 1;
                    // Se calcula el nuevo porcentaje de las bolas.
                    PorBR = BolasRojas * 100 / TotalBolas;
                    PorBN = BolasNegras * 100 / TotalBolas;
                    dgvMain.Rows.Add(Cont.ToString(), Math.Round(Pseudoaleatorio, 5).ToString(), TotalBolas.ToString(), BolasRojas.ToString(), PorBR.ToString() + " %", BolasNegras.ToString(), PorBN.ToString() + " %", "Bola Negra");
                }
            }
            PseudoPasado = n;
            Cont++;

            // Intentos restantes
            do
            {
                n = (a * PseudoPasado + c) % M;
                Pseudoaleatorio = n / M;


                if (BolasRojas > BolasNegras) // Verificar si hay mas Rojas que Negras
                {
                    if (Pseudoaleatorio <= ProbaBN)
                    {
                        //Se resta la bola extraida
                        TotalBolas = TotalBolas - 1;
                        BolasNegras = BolasNegras - 1;
                        // Se calcula el nuevo porcentaje de las bolas.
                        PorBR = BolasRojas * 100 / TotalBolas;
                        PorBN = BolasNegras * 100 / TotalBolas;
                        dgvMain.Rows.Add(Cont.ToString(), Math.Round(Pseudoaleatorio, 5).ToString(), TotalBolas.ToString(), BolasRojas.ToString(), PorBR.ToString() + " %", BolasNegras.ToString(), PorBN.ToString() + " %", "Bola Negra");
                    }
                    else
                    {
                        //Se resta la bola extraida
                        TotalBolas = TotalBolas - 1;
                        BolasRojas = BolasRojas - 1;
                        // Se calcula el nuevo porcentaje de las bolas.
                        PorBR = BolasRojas * 100 / TotalBolas;
                        PorBN = BolasNegras * 100 / TotalBolas;
                        dgvMain.Rows.Add(Cont.ToString(), Math.Round(Pseudoaleatorio, 5).ToString(), TotalBolas.ToString(), BolasRojas.ToString(), PorBR.ToString() + " %", BolasNegras.ToString(), PorBN.ToString() + " %", "Bola Roja");
                    }
                }
                else if (BolasRojas < BolasNegras) // Verificar si hay mas Negras que Rojas
                {
                    if (Pseudoaleatorio <= ProbaBR)
                    {
                        //Se resta la bola extraida
                        TotalBolas = TotalBolas - 1;
                        BolasRojas = BolasRojas - 1;
                        // Se calcula el nuevo porcentaje de las bolas.
                        PorBR = BolasRojas * 100 / TotalBolas;
                        PorBN = BolasNegras * 100 / TotalBolas;
                        dgvMain.Rows.Add(Cont.ToString(), Math.Round(Pseudoaleatorio, 5).ToString(), TotalBolas.ToString(), BolasRojas.ToString(), PorBR.ToString() + " %", BolasNegras.ToString(), PorBN.ToString() + " %", "Bola Roja");
                    }
                    else
                    {
                        //Se resta la bola extraida
                        TotalBolas = TotalBolas - 1;
                        BolasNegras = BolasNegras - 1;
                        // Se calcula el nuevo porcentaje de las bolas.
                        PorBR = BolasRojas * 100 / TotalBolas;
                        PorBN = BolasNegras * 100 / TotalBolas;
                        dgvMain.Rows.Add(Cont.ToString(), Math.Round(Pseudoaleatorio, 5).ToString(), TotalBolas.ToString(), BolasRojas.ToString(), PorBR.ToString() + " %", BolasNegras.ToString(), PorBN.ToString() + " %", "Bola Negra");
                    }
                }
                else if (BolasRojas == BolasNegras) //En caso de que haya la misma cantidad de bolas
                {
                    if (Pseudoaleatorio >= 0.5)
                    {
                        //Se resta la bola extraida
                        TotalBolas = TotalBolas - 1;
                        BolasNegras = BolasNegras - 1;
                        // Se calcula el nuevo porcentaje de las bolas.
                        PorBR = BolasRojas * 100 / TotalBolas;
                        PorBN = BolasNegras * 100 / TotalBolas;
                        dgvMain.Rows.Add(Cont.ToString(), Math.Round(Pseudoaleatorio, 5).ToString(), TotalBolas.ToString(), BolasRojas.ToString(), PorBR.ToString() + " %", BolasNegras.ToString(), PorBN.ToString() + " %", "Bola Negra");
                    }
                    else
                    {
                        //Se resta la bola extraida
                        TotalBolas = TotalBolas - 1;
                        BolasRojas = BolasRojas - 1;
                        // Se calcula el nuevo porcentaje de las bolas.
                        PorBR = BolasRojas * 100 / TotalBolas;
                        PorBN = BolasNegras * 100 / TotalBolas;
                        dgvMain.Rows.Add(Cont.ToString(), Math.Round(Pseudoaleatorio, 5).ToString(), TotalBolas.ToString(), BolasRojas.ToString(), PorBR.ToString() + " %", BolasNegras.ToString(), PorBN.ToString() + " %", "Bola Roja");
                    }
                }

                PseudoPasado = n;
                Cont++;
            }while (BolasRojas > 0 && BolasNegras > 0);

            Cont--;

            // Resultado de la apuesta
            if (Cont == Turno)
            {
                ganancia = Apuesta;
                Apuesta = Apuesta * 2;
            }
            else if (Turno <= Cont + 2 && Turno >= Cont - 2)
            {
                ganancia = Apuesta / 2;
                Apuesta = Apuesta + Apuesta / 2;
            }
            else
            {
                ganancia = Apuesta * -1;
                Apuesta = 0;

            }
            tbxResTurno.Text = Cont.ToString();
            tbxDinero.Text = Apuesta.ToString();
            tbxGanancia.Text = ganancia.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
