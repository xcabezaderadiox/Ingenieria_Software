using System;
using System.Collections.Generic;
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
using System.IO;

namespace WpfApp3
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

        //voy al lado del xaml boton derecho ir definicion y me crea el metodo del boton
        private void CargarArchivos(object sender, RoutedEventArgs e)
        {
            //con el var adivina el tipo de dato que va devolver el getfile
            //var archivos = Directory.GetFiles("c:/");
            //Explorer.ItemsSource = archivos;
            //Explorer.Ite
            LeerDirectorio("c:/");

        }

        private void Presionar_tecla(object sender, KeyEventArgs e)
        {
            //lo q escribo en textbox va pasar x aca hasta que toque el ENTER
            if (e.Key != Key.Enter)
                return;

            LeerDirectorio(Ruta.Text);
        }

        //CREAMOS METODO QUE LEE EL DIRECTORIO INGRESADO EN EL TEXTBOX
        private void LeerDirectorio(string path)
        {
            if (!Directory.Exists(path))
            {
                //mostrar mensaje en el label del status bar
                Mensaje.Content = ("Ingrese bien el directorio,el path " + path + " es incorrecto!" );
                return;
            }
            //leo archivos y directorios,los guardo en lista y los muestro
            var archivos = Directory.GetFiles(path);
            var directorios = Directory.GetDirectories(path);
            List<string> files = new List<string>();
            foreach (var item in directorios)
            {
                files.Add(System.IO.Path.GetFileName(item));
            }
            foreach (var item in archivos)
            {
                files.Add(System.IO.Path.GetDirectoryName(item));
            }
            //files.AddRange(directorios);
            //files.AddRange(archivos);
            Explorer.ItemsSource = files;
            Ruta.Text = path;
        }

        private void click(object sender, MouseButtonEventArgs e)
        {
            string item = Explorer.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(item))
                return;
            //if (Directory.Exists())
            string enlace = Ruta.Text;
            if (!enlace.EndsWith("/"))
                enlace += "/";
            LeerDirectorio(enlace + item);
        }
    }
}
