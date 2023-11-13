using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Productos
{
    public partial class frmClientes : Form
    {
        public int N;
        public int i;
        public double[,] mInformacion;
        public  String[] vNombres;


        public frmClientes()
        {
            InitializeComponent();
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btmIngresar_Click(object sender, EventArgs e)
        {
            dgvFactura.RowCount = 0;
            N = Convert.ToInt32(Interaction.InputBox("Ingrese el número de clientes: "));
            vNombres = new String[N];
            mInformacion = new double[N, 7];
            //Agregar filas al dgv
            dgvFactura.RowCount = (N + 4);
            //ocultar filas que no se utilizan
            dgvFactura.Rows[N ].Cells[0].Style.BackColor = Color.Transparent;
            dgvFactura.Rows[N + 1].Cells[0].Style.BackColor = Color.Transparent;
            dgvFactura.Rows[N + 2].Cells[0].Style.BackColor = Color.Transparent;
            dgvFactura.Rows[N + 3].Cells[0].Style.BackColor = Color.Transparent;

            dgvFactura.Rows[N ].Cells[1].Style.BackColor = Color.Transparent;
            dgvFactura.Rows[N + 1].Cells[1].Style.BackColor = Color.Transparent;
            dgvFactura.Rows[N + 2].Cells[1].Style.BackColor = Color.Transparent;
            dgvFactura.Rows[N + 3].Cells[1].Style.BackColor = Color.Transparent;


            dgvFactura.Rows[N ].Cells[2].Style.BackColor = Color.Transparent;
            dgvFactura.Rows[N + 1].Cells[2].Style.BackColor = Color.Transparent;
            dgvFactura.Rows[N + 2].Cells[2].Style.BackColor = Color.Transparent;
            dgvFactura.Rows[N + 3].Cells[2].Style.BackColor = Color.Transparent;

            //titular promedio ,mayor, menor..
            dgvFactura.Rows[N].Cells[3].Value = "total";
            dgvFactura.Rows[N].Cells[3].Style.BackColor = Color.SkyBlue;
            dgvFactura.Rows[N + 1].Cells[3].Value = "promedio";
            dgvFactura.Rows[N + 1].Cells[3].Style.BackColor = Color.SkyBlue;
            dgvFactura.Rows[N + 2].Cells[3].Value = "Valor mayor";
            dgvFactura.Rows[N + 2].Cells[3].Style.BackColor = Color.SkyBlue;
            dgvFactura.Rows[N + 3].Cells[3].Value = "Valor menor";
            dgvFactura.Rows[N + 3].Cells[3].Style.BackColor = Color.SkyBlue;


            for (i = 0; i <= N-1; i++)
            {   //ingresar los nombres
                vNombres[i] = Convert.ToString(Interaction.InputBox("Ingrese el nombre del cliente: "));
                dgvFactura.Rows[i].Cells[0].Value=vNombres[i];

                mInformacion[i, 0] = Convert.ToDouble(Interaction.InputBox("ingrese el codigo de clasificación : "));
                dgvFactura.Rows[i].Cells[1].Value = mInformacion[i, 0];
                mInformacion[i, 1] = Convert.ToDouble(Interaction.InputBox("ingrese la antiguedad: "));
                dgvFactura.Rows[i].Cells[2].Value = mInformacion[i, 1];
                mInformacion[i, 2] = Convert.ToDouble(Interaction.InputBox("ingrese el valor: "));
                dgvFactura.Rows[i].Cells[3].Value = mInformacion[i, 2];
                //calculando descuento y subtotal en ingresar en dgv
                if (mInformacion[i,0]==1 && mInformacion[i, 1] >= 2 && mInformacion[i,2]>20000000 )
                {
                    mInformacion[i, 3] = mInformacion[i, 2] * 0.253;
                    dgvFactura.Rows[i].Cells[4].Value = mInformacion[i, 3];
                    mInformacion[i, 4] = mInformacion[i, 2] - mInformacion[i, 3];
                    dgvFactura.Rows[i].Cells[5].Value = mInformacion[i, 4];
                }else if (mInformacion[i, 0] == 2 && mInformacion[i, 1] >= 5 && mInformacion[i, 2] > 30000000)
                {
                    mInformacion[i, 3] = mInformacion[i, 2] * 0.18;
                    dgvFactura.Rows[i].Cells[4].Value = mInformacion[i, 3];
                    mInformacion[i, 4] = mInformacion[i, 2] - mInformacion[i, 3];
                    dgvFactura.Rows[i].Cells[5].Value = mInformacion[i, 4];
                }
                else if (mInformacion[i, 0] == 3  && mInformacion[i, 2] >= 17500000)
                {
                    mInformacion[i, 3] = mInformacion[i, 2] * 0.1;
                    dgvFactura.Rows[i].Cells[4].Value = mInformacion[i, 3];
                    mInformacion[i, 4] = mInformacion[i, 2] - mInformacion[i, 3];
                    dgvFactura.Rows[i].Cells[5].Value = mInformacion[i, 4];
                }
                else
                {
                    mInformacion[i, 3] = 0;
                    dgvFactura.Rows[i].Cells[4].Value = mInformacion[i, 3];
                    mInformacion[i, 4] = mInformacion[i, 2] - mInformacion[i, 3];
                    dgvFactura.Rows[i].Cells[5].Value = mInformacion[i, 4];
                }
                //calcular la retencion de fuente
                if (mInformacion[i, 4] > 30000000) 
                {
                    mInformacion[i, 5] = mInformacion[i, 4] * 0.028;
                    dgvFactura.Rows[i].Cells[6].Value = mInformacion[i, 5];
                }
                else if (mInformacion[i,4]>10000000)
                {
                    mInformacion[i, 5] = mInformacion[i, 4] * 0.017;
                    dgvFactura.Rows[i].Cells[6].Value = mInformacion[i, 5];
                }
                else if(mInformacion[i,4]<10000000)
                {
                    mInformacion[i, 5] = mInformacion[i, 4] * 0.0045;
                    dgvFactura.Rows[i].Cells[6].Value = mInformacion[i, 5];
                }
                //calcular el total a pagar
                mInformacion[i, 6] = mInformacion[i, 4] + mInformacion[i, 5];
                dgvFactura.Rows[i].Cells[7].Value = mInformacion[i, 6];



            }
            btmCalcular.Enabled = true;
            btmIngresar.Enabled = false;

        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            double[,] vtotales = new double[4, 4];
            int c;
            double acum = 0, vMayor = 0, vMenor = 0;

            for (c=3;c<=6; c++)
            {
                for (i = 0; i <= N - 1; i++)
                {
                    acum = acum + mInformacion[i, c];
                    if (i==0)
                    {
                        vMayor = mInformacion[i,c ];
                        vMenor = mInformacion[i, c];
                    }
                    else 
                    {
                        if (mInformacion[i,c]>vMayor)
                        {
                            vMayor = mInformacion[i, c];
                        }
                        else
                        {
                            if (mInformacion[i,c]<vMenor)
                            {
                                vMenor = mInformacion[i, c];
                            }
                        }
                    }
                }
                vtotales[0, c - 3] = acum;
                dgvFactura.Rows[N].Cells[c + 1].Value = vtotales[0, c - 3];
                vtotales[1, c - 3] = acum / N;
                dgvFactura.Rows[N + 1].Cells[c + 1].Value = vtotales[1, c - 3];
                vtotales[2, c - 3] = vMayor;
                dgvFactura.Rows[N + 2].Cells[c + 1].Value = vtotales[2, c - 3];
                vtotales[3, c - 3] = vMenor;
                dgvFactura.Rows[N + 3].Cells[c + 1].Value = vtotales[3, c - 3];
                acum = 0;
                btmIngresar.Enabled = true;
                btmCalcular.Enabled = false;
            }

        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            DialogResult Salir= MessageBox.Show("¿está seguro de salir de la aplicación?", "Salir", MessageBoxButtons.YesNo);
            if (Salir == DialogResult.Yes) Close();
        }
    }
}
