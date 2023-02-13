using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fat32System
{
    public partial class Form1 : Form
    {
        //Variable que contiene la direccion en la que estamos dentro del sistema de archivos
        private string direccion = @"C:\";
        //Variable que usaremos como la direccion que vamos a copiar o pegar
        private string direccionACopiar = "";
        private string itemSeleccionado = "";
        //Indica si estamos en una direccion de archivo o en una carpeta
        private bool esArchivo = false;
        
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Igualamos la variable que contiene la direccion al textbox que nos mostrara la direccion en la que estamos
            txtDireccion.Text = direccion;
            cargarDirectorios();
        }

        /// <summary>
        /// Carga la direccion y los archivos en la lista donde miramos los archivos
        /// </summary>
        private void cargarDirectorios()
        {

            DirectoryInfo listaArchivos;
            FileAttributes atributosDelArchivo;
            string direccionTemporal = "";
            
            try
            {
                if (esArchivo)
                {
                    //Mostrar Datos del archivo
                    direccionTemporal = direccion + itemSeleccionado + @"\";
                    FileInfo detallesDelArchivo = new FileInfo(direccionTemporal);
                    lblNombre.Text = detallesDelArchivo.FullName;
                    lblTamanio.Text = Convert.ToString(detallesDelArchivo.Length);
                    lblTipo.Text = detallesDelArchivo.Extension;
                    atributosDelArchivo = File.GetAttributes(direccionTemporal);
                    //Ejecutar el archivo
                    Process.Start(direccionTemporal);
                }
                else
                {
                    atributosDelArchivo = File.GetAttributes(direccion);                    
                }

                if ((atributosDelArchivo & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    direccion = txtDireccion.Text;
                    listaArchivos = new DirectoryInfo(direccion);
                    //Arreglos en los que se contendran los archivos a mostrar
                    FileInfo[] archivos = listaArchivos.GetFiles(); //trae archivos
                    DirectoryInfo[] dirs = listaArchivos.GetDirectories(); //trae los carpetas
                    vistaArchivos.Items.Clear();

                    TraerDirectoriosEIconos(archivos, dirs);
                }
                else
                {
                    lblNombre.Text = this.itemSeleccionado;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
               
        }

        private void TraerDirectoriosEIconos(FileInfo[] archivos, DirectoryInfo[] dirs)
        {
            string extension = "";
            //For para traer todos los archivos del directorio
            for (int i = 0; i < archivos.Length; i++)
            {
                extension = archivos[i].Extension.ToUpper();
                switch (extension)
                {
                    case ".MP3":
                    case ".MP2":
                        vistaArchivos.Items.Add(archivos[i].Name, 5);
                        break;
                    case ".EXE":
                    case ".COM":
                        vistaArchivos.Items.Add(archivos[i].Name, 7);
                        break;

                    case ".MP4":
                    case ".AVI":
                    case ".MKV":
                        vistaArchivos.Items.Add(archivos[i].Name, 6);
                        break;
                    case ".PDF":
                        vistaArchivos.Items.Add(archivos[i].Name, 4);
                        break;
                    case ".DOC":
                    case ".DOCX":
                        vistaArchivos.Items.Add(archivos[i].Name, 3);
                        break;
                    case ".PNG":
                    case ".JPG":
                    case ".JPEG":
                        vistaArchivos.Items.Add(archivos[i].Name, 9);
                        break;

                    default:
                        vistaArchivos.Items.Add(archivos[i].Name, 8);
                        break;
                }

            }

            //For para traer todas las carpetas del directorio
            for (int i = 0; i < dirs.Length; i++)
            {
                vistaArchivos.Items.Add(dirs[i].Name, 10);
            }

        }

        /// <summary>
        /// Cada que cambie la seleccion de un archivo
        /// </summary>        
        private void vistaArchivos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            itemSeleccionado = e.Item.Text;
            //Concatenamos para que cambie la barra de direcciones
            FileAttributes atributos = File.GetAttributes(direccion + @"\" + itemSeleccionado);

            //Si es igual es porque lo seleccionamos
            if ((atributos & FileAttributes.Directory) == FileAttributes.Directory)
            {
                //al no ser archivo no hay que ejecutarlo, solo hay que actualizar la direccion a mostrar
                esArchivo = false;                
                txtDireccion.Text = direccion + itemSeleccionado + @"\";                
            }
            else
            {
                //si es archivo debemos ejecutarlo
                esArchivo = true;
            }
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            cargarDirectorios();
        }

        private void vistaArchivos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cargarDirectorios();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            IrAnterior();
            cargarDirectorios();
        }

        /// <summary>
        /// Funcion para ir a la pestania anterior
        /// </summary>
        private void IrAnterior()
        {
            try
            {
                string DireccionActual = txtDireccion.Text;
                //Borramos hasta al ultimo slash, hacemos dos veces el proceso porque en la direccion se pone un slash al final
                DireccionActual = DireccionActual.Substring(0, (DireccionActual.LastIndexOf(@"\")));
                DireccionActual = DireccionActual.Substring(0, (DireccionActual.LastIndexOf(@"\")+1));
                this.esArchivo = false;
                txtDireccion.Text = DireccionActual;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            //Variable con la direcciona a pegar
            string direccionAPegar = "";
            direccionACopiar = direccion + itemSeleccionado;
            
        }
    }
}
