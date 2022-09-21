using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pry.LopezV.SPBiblioteca
{
    public partial class frmConsultaLibros : Form
    {
        public frmConsultaLibros()
        {
            InitializeComponent();
        }

        public string[,] baseLibro = new string[20,5];
        public int contador = 0;

        private void frmConsultaLibros_Load(object sender, EventArgs e)
        {

            char separador = Convert.ToChar(",");
            int i = 0;

            StreamReader objLector = new StreamReader("./LIBRO.txt");
            

            //Mientras el no esté en la posicion final del archivo leer y separar cada linea
            while(!objLector.EndOfStream)
            {
                string[] vecLibro = objLector.ReadLine().Split(separador);


                if (i < 20)
                {
                    //EL vector carga la informacion del libro en las columnas de la mat

                    baseLibro[i, 0] = vecLibro[0];
                    baseLibro[i, 1] = vecLibro[1];
                    baseLibro[i, 2] = vecLibro[2];
                    baseLibro[i, 3] = vecLibro[3];
                    baseLibro[i, 4] = vecLibro[4];

                    i++;

                }

            }
            objLector.Close();

            //Cargar en los txt la informacion de la matriz
            txtCodigo.Text = baseLibro[0, 0];
            txtNombre.Text = baseLibro[0,1];
            txtCodigoEdit.Text = baseLibro[0,2];
            txtCodigoAut.Text = baseLibro[0,3];
            txtCodigoDistr.Text = baseLibro[0,4];

            cmdRetroceder.Enabled = false;
            
        }

        //Posicionar la lectura en el array
        int indiceRecorrido = 0;

        private void cmdAvanzar_Click(object sender, EventArgs e)
        {
            //Incrementar el contador para recorrer la base de datos
            contador++;


            txtCodigo.Text = baseLibro[contador, 0];
            txtNombre.Text = baseLibro[contador, 1];
            txtCodigoEdit.Text = baseLibro[contador, 2];
            txtCodigoAut.Text = baseLibro[contador, 3];
            txtCodigoDistr.Text = baseLibro[contador, 4];

            cmdRetroceder.Enabled = true;

            if (contador == baseLibro.GetLength(0)-1)
            {
                cmdAvanzar.Enabled = false;
            }


        }

        private void cmdRetroceder_Click(object sender, EventArgs e)
        {
            //Decremento del contador para regresar hacia atras
            contador--;

            if (contador >= 0)
            {
                txtCodigo.Text = baseLibro[contador, 0];
                txtNombre.Text = baseLibro[contador, 1];
                txtCodigoEdit.Text = baseLibro[contador, 2];
                txtCodigoAut.Text = baseLibro[contador, 3];
                txtCodigoDistr.Text = baseLibro[contador, 4];

                //si el contador esta en 0 deshabilitar control de retroceder
                if (contador == 0)
                {
                    cmdRetroceder.Enabled = false;
                }
            }
            else
            {
                cmdRetroceder.Enabled = true;
            }
        }
    }
}
