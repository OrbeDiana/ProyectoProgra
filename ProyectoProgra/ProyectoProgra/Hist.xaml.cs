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
using System.Windows.Shapes;
using System.IO;
using SQLite;

namespace ProyectoProgra
{
    /// <summary>
    /// Lógica de interacción para Hist.xaml
    /// </summary>
    public partial class Hist : Window
    {
        public Hist()
        {
            InitializeComponent();
            LeerDatos();
        }
        private void LeerDatos()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string rutaBaseDeDatos = Directory.GetParent(workingDirectory).Parent.FullName + "\\Historial.db";
            using (SQLiteConnection conn = new SQLiteConnection(rutaBaseDeDatos))
            {
                conn.CreateTable<History>();
                HistoryList.ItemsSource = conn.Table<History>();
            }
        }
    }
}
