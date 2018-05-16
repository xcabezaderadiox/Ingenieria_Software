using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;


namespace Wpf_Editor_de_Texto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //tengo que declarar la variable de ruta por fuera para poder usar
        string Ruta { get; set; }

        private void Velez_Click(object sender, RoutedEventArgs e)
        {
            StreamReader reader = File.OpenText("C:/Users/IFTS 18/source/repos/Wpf Editor de Texto/velez.txt");
            txteditor.Text = reader.ReadToEnd();
            reader.Close();
        }


        private void AbrirArchivo(object sender, System.EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:/Users/IFTS 18/source/repos/Wpf Editor de Texto";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader reader = new StreamReader(myStream);
                            txteditor.Text = reader.ReadToEnd();
                            //guardo la ruta del archivo abierto
                            Ruta = openFileDialog1.FileName;
                            //dejo deshabilitado el boton de guardar el file editado
                            boton.IsEnabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void GuardarArchivo(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:/Users/IFTS 18/source/repos/Wpf Editor de Texto/velez_editable.txt");
            writer.Write(txteditor.Text);
            writer.Close();
        }

        private void GuardarEditado(object sender, RoutedEventArgs e)
        {
            // si la ruta no existe que arroje error en ventana
            //if (Ruta is null)
            //    System.Windows.Forms.MessageBox.Show("Error");
            //else
            //    File.WriteAllText(Ruta, txteditor.Text);
            //escribe el archivo y lo guarda en la ruta
            File.WriteAllText(Ruta, txteditor.Text);
        }

        //guardar como usan savefiledialog creo variable con esa funcion
        private void GuardarComo(object sender, RoutedEventArgs e)
        {
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            if (savefiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                File.WriteAllText(savefiledialog1.FileName, txteditor.Text);

        }
    }

}

