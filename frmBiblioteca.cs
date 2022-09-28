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

namespace pryParedesBiblioteca
{
    public partial class frmBiblioteca : Form
    {



        public string[] baseLibro = new string[27];

        public int[] vecCodigo = new int[27];





        public frmBiblioteca()
        {
            InitializeComponent();
        }

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            StreamReader objLector = new StreamReader("./LIBRO.txt");

            int indice = 0;

            while (!objLector.EndOfStream)
            {
                
                baseLibro[indice] = objLector.ReadLine();


                indice++;
            }

            objLector.Close();
        }

        int IndiceRecorrido = 0;

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            StreamReader objLector = new StreamReader("./LIBRO.txt");

            string TextoCodigo = objLector.ReadLine();

            

            
            if (IndiceRecorrido < baseLibro.Length && baseLibro[IndiceRecorrido] != null)
            {
                txtNombreLibro.Text = baseLibro[IndiceRecorrido].ToString();

                
                
                //txtCodigo.Text = baseLibro[IndiceRecorrido].ToString((TextoCodigo.Substring(0, 2)));

                
                /*lstLibros.Items.Add(baseLibro[IndiceRecorrido]);*/
                
                IndiceRecorrido++;
            }
            objLector.Close();
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            IndiceRecorrido--;
            if (IndiceRecorrido < baseLibro.Length && baseLibro[IndiceRecorrido] != null)
            {
                lstLibros.Items.Add(baseLibro[IndiceRecorrido]);
            }
        }
    }
}
