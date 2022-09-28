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

            if (File.Exists("./LIBRO.txt"))
            {

            }
        }

        int IndiceRecorrido = 0;

        

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            StreamReader objLector = new StreamReader("./LIBRO.txt");

            
            
            string TextoCodigo = objLector.ReadLine();

            

            
            if (IndiceRecorrido < baseLibro.Length && baseLibro[IndiceRecorrido] != null)
            {
                
                lstNombreLibro.Items.Clear();
                lstNombreLibro.Items.Add(baseLibro[IndiceRecorrido].Substring(3, 20));

                lstCodigo.Items.Clear();
                lstCodigo.Items.Add(baseLibro[IndiceRecorrido].Substring(0,2));

                
                
                switch (txtCodigoEditorial.Text)
                {
                    case "EL SISTEMA OPERATIVO":
                        txtCodigoEditorial.Text = "7";
                        break;

                    case "2":
                        txtCodigoEditorial.Text = "CUSPIDE";
                        break;

                    case "3":
                        txtCodigoEditorial.Text = "RAMA";
                        break;

                    case "4":
                        txtCodigoEditorial.Text = "MAC GRAW HILL";
                        break;

                    case "5":
                        txtCodigoEditorial.Text = "ANAY MULTIMEDIA";
                        break;

                    case "6":
                        txtCodigoEditorial.Text = "PEUSER";
                        break;


                }




                IndiceRecorrido++;
            }
            objLector.Close();
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            IndiceRecorrido--;
            if (IndiceRecorrido < baseLibro.Length && baseLibro[IndiceRecorrido] != null)
            {
                lstNombreLibro.Items.Clear();
                lstNombreLibro.Items.Add(baseLibro[IndiceRecorrido].Substring(3, 19));
                
                
            }
        }
    }
}
