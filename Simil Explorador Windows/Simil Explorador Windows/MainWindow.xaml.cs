using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Simil_Explorador_Windows
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public object lbcar { get; set; }
        public object SelectedItem { get; private set; }


        // El form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Iniciamos el txtRuta
            txtRuta.Text = Directory.GetDirectoryRoot(Directory.GetCurrentDirectory());

            // Listamos las carpetas
            carpetas(txtRuta.Text);

            // Listamos los archivos
            archivos(txtRuta.Text);
        }

        // El botón para explorar rutas
        private void PC(object sender, EventArgs e)
        {
            // Listamos las carpetas
            carpetas(txtRuta.Text);

            // Listamos los archivos
            archivos(txtRuta.Text);
        }

        // Al hacer doble click sobre una ruta la colocamos en txtRuta
        private void lbcar_DoubleClick(object sender, EventArgs e)
        {
            Object selectedItem = SelectedItem;
            txtRuta.Text = lbcar.SelectedItem.ToString();

            // Listamos las carpetas
            carpetas(txtRuta.Text);

            // Listamos los archivos
            archivos(txtRuta.Text);
        }

        // Metodo que coloca las carpetas de la ruta indicada en el list
        // box correspondiente
        private void carpetas(string ruta)
        {
            lbcar.Items.Clear();

            string[] carpeta = Directory.GetDirectories(ruta);

            foreach (string car in carpeta)
                lbcar.Items.Add(car);
        }

        // Metodo que coloca los archivos de la ruta indicada en el list
        // box correspondiente
        private void archivos(string ruta)
        {
            lbar.Items.Clear();

            string[] archivo = Directory.GetFiles(ruta);

            foreach (string ar in archivo)
                lbar.Items.Add(ar);
        }
    }
}
