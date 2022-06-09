using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIndividualSimulacion
{
    public partial class Form1 : Form
    {
        //DECLARACION DE VARIABLES 
        double A, C, M, X0, XR, XN, AUX = 0, MEDIA;
        int Hora1 = 0;
        int Hora2 = 0;
        int Hora3 = 0;
        int Hora4 = 0;
        int Hora5 = 0;
        int Hora6 = 0;
        int Hora7 = 0;
        int Hora8 = 0;
        int Hora9 = 0;
       
        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < NUM; i++)
            {
                int n = DGV1.Rows.Add();

                DGV1.Rows[n].Cells[0].Value = i + 1;
                DGV1.Rows[n].Cells[1].Value = Numeros[i];

                if (Numeros[i] < 0.11)
                {
                    
                    DGV1.Rows[n].Cells[2].Value = Numeros[i].ToString("♥" );
                    Hora1++;

                }
                else if (Numeros[i] > 0.12 && Numeros[i] < 0.22)
                {
                   
                    DGV1.Rows[n].Cells[3].Value = Numeros[i].ToString("♥");
                    Hora2++;

                }
                
                else if (Numeros[i] > 0.23 && Numeros[i] < 0.33)
                {
                    
                    DGV1.Rows[n].Cells[4].Value = Numeros[i].ToString("♥");
                    Hora3++;

                }
                else if (Numeros[i] > 0.34 && Numeros[i] < 0.44)
                {
                   
                    DGV1.Rows[n].Cells[5].Value = Numeros[i].ToString("♥");
                    Hora4++;

                }
                else if (Numeros[i] > 0.45 && Numeros[i] < 0.55)
                {
                    
                    DGV1.Rows[n].Cells[6].Value = Numeros[i].ToString("♥");
                    Hora5++;

                }
                else if (Numeros[i] > 0.56 && Numeros[i] < 0.66)
                {
                    
                    DGV1.Rows[n].Cells[7].Value = Numeros[i].ToString("♥");
                    Hora6++;

                }
                else if (Numeros[i] > 0.67 && Numeros[i] < 0.77)
                {

                    DGV1.Rows[n].Cells[8].Value = Numeros[i].ToString("♥");
                    Hora7++;

                }
                else if (Numeros[i] > 0.78 && Numeros[i] < 0.88)
                {

                    DGV1.Rows[n].Cells[9].Value = Numeros[i].ToString("♥");
                    Hora8++;

                }
                else
                {

                    DGV1.Rows[n].Cells[10].Value = Numeros[i].ToString("♥");
                    Hora9++;

                }

            }
            
            label1.Text = Hora1.ToString();
            label2.Text = Hora2.ToString();
            label3.Text = Hora3.ToString();
            label4.Text = Hora4.ToString();
            label5.Text = Hora5.ToString();
            label6.Text = Hora6.ToString();
            label7.Text = Hora7.ToString();
            label8.Text = Hora8.ToString();
            label9.Text = Hora9.ToString();

            int HoraMayor = 0;

            if (Hora1 >= Hora2 && Hora1 >= Hora3 && Hora1 >= Hora4 && Hora1 >= Hora5 && Hora1 >= Hora6 && Hora1 >= Hora7 && Hora1 >= Hora8 && Hora1 >= Hora9)
            {

                HoraMayor = Hora1;

            }
            else
            {

                if (Hora2 >= Hora1 && Hora2 >= Hora3 && Hora2 >= Hora4 && Hora2 >= Hora5 && Hora2 >= Hora6 && Hora2 >= Hora7 && Hora2 >= Hora8 && Hora2 >= Hora9)
                {

                    HoraMayor = Hora2;

                }
                else
                {

                    if (Hora3 >= Hora1 && Hora3 >= Hora2 && Hora3 >= Hora4 && Hora3 >= Hora5 && Hora3 >= Hora6 && Hora3 >= Hora7 && Hora3 >= Hora8 && Hora3 >= Hora9)
                    {

                        HoraMayor = Hora3;

                    }
                    else
                    {

                        if (Hora4 >= Hora1 && Hora4 >= Hora2 && Hora4 >= Hora3 && Hora4 >= Hora5 && Hora4 >= Hora6 && Hora4 >= Hora7 && Hora4 >= Hora8 && Hora4 >= Hora9)
                        {

                             HoraMayor = Hora4;

                        }
                        else
                        {

                            if (Hora5 >= Hora1 && Hora5 >= Hora2 && Hora5 >= Hora3 && Hora5 >= Hora4 && Hora5 >= Hora6 && Hora5 >= Hora7 && Hora5 >= Hora8 && Hora5 >= Hora9)
                            {

                                 HoraMayor = Hora5;

                            }
                            else
                            {

                                if (Hora6 >= Hora1 && Hora6 >= Hora2 && Hora6 >= Hora3 && Hora6 >= Hora4 && Hora6 >= Hora5 && Hora6 >= Hora7 && Hora6 >= Hora8 && Hora6 >= Hora9)
                                {

                                     HoraMayor = Hora6;

                                }
                                else
                                {

                                    if (Hora7 >= Hora1 && Hora7 >= Hora2 && Hora7 >= Hora3 && Hora7 >= Hora4 && Hora7 >= Hora5 && Hora7 >= Hora8 && Hora7 >= Hora8 && Hora7 >= Hora9)
                                    {

                                         HoraMayor = Hora7;

                                    }
                                    else
                                    {

                                        if (Hora8 >= Hora1 && Hora8 >= Hora2 && Hora8 >= Hora3 && Hora8 >= Hora4 && Hora8 >= Hora5 && Hora8 >= Hora6 && Hora8 >= Hora7 && Hora7 >= Hora9)
                                        {

                                             HoraMayor = Hora8;

                                        }
                                        else
                                        {

                                            if (Hora9 >= Hora1 && Hora9 >= Hora2 && Hora9 >= Hora3 && Hora9 >= Hora4 && Hora9 >= Hora5 && Hora9 >= Hora6 && Hora9 >= Hora7 && Hora9 >= Hora8)
                                            {

                                                 HoraMayor = Hora9;

                                            }

                                        }

                                    }

                                }

                            }

                        }
                    }

                }

            }

            label11.Text = HoraMayor.ToString();
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int NUM;
        public static double[] Numeros;

        public Form1()
        {

            InitializeComponent();

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            //Asignacion de variables 
            A = Double.Parse(txtValorA.Text);
            C = Double.Parse(txtValorC.Text);
            M = Double.Parse(txtValorM.Text);
            X0 = Double.Parse(txtValorXo.Text);
            NUM = int.Parse(txtCantidadGenerar.Text);
            Numeros = new double[NUM];

            for (int i = 0; i < NUM; i++)
            {

                //Almacena los numeros 
                int n = dgvPruebas.Rows.Add();
                dgvPruebas.Rows[n].Cells[0].Value = i + 1;
               
                //formula para generar numeros 
                XN = (((A * X0) + C) % M);
                XR = (XN / M);
                
                //Redondeo de decimales 
                XR = Math.Round(XR, 5);
                double d = XR;
                X0 = Convert.ToInt32(XR * M);
                Numeros[i] = XR;
                
                //variable para acumular los numeros 
                AUX = AUX + XR;
                
                //mostar los datos en la tabla 
                dgvPruebas.Rows[n].Cells[1].Value = XR.ToString();

            }

            MEDIA = AUX / NUM;

        }
    }
}
