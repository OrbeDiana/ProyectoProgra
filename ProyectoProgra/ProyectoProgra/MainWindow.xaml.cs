using System.IO;
using SQLite;
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

namespace ProyectoProgra
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string rutaBaseDeDatos = Environment.CurrentDirectory + "//Historial.db";
        double n;
        string op, coin, result;
        public MainWindow()
        {
            InitializeComponent();
           LeerDatos();
        }
        private void LeerDatos()
        {
            using (SQLiteConnection conn = new SQLiteConnection(rutaBaseDeDatos))
            {
                conn.CreateTable<History>();
                HistoryList.ItemsSource = conn.Table<History>();
            }
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            ProyectoProgra.Hist form = new ProyectoProgra.Hist();
            form.ShowDialog();
        }

        private void SwitchBtn_Click(object sender, RoutedEventArgs e)
        {
            string i, t;
            //string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            i = comboBox1.Text;
            t = comboBox2.Text;
            comboBox2.Text = i;
            comboBox1.Text = t;
            textBox3.Clear();
            double o, res;
            string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            coin = comboBox1.Text;
            op = comboBox2.Text;
            n = float.Parse(textBox1.Text);
            if (coin == "Dollar USD")
            {
                if (op == "Dollar USD")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 19.51;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.91;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 107.43;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 3.34;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 71.87;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.809251;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 7.68075;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 3365.41;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 6.90516;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Mexican Peso MXN")
            {
                if (op == "Dollar USD")
                {
                    o = 0.051;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Euro EUR")
                {
                    o = 0.0464174;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 5.52;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.17;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 3.68647;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.0415030;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 0.395351;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 173.175;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.355286;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Euro EUR")
            {
                if (op == "Dollar USD")
                {
                    o = 1.10;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 21.5436;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Yen JPY")
                {
                    o = 118.79;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 3.69;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 79.386;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.894153;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 8.49866;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 3724.04;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 7.64082;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Yen JPY")
            {
                if (op == "Dollar USD")
                {
                    o = 0.0093;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.18132;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.00842;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Soles PEN")
                {
                    o = 0.031070;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 0.668590;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.007529;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 0.0710064;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 31.1200;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.063885;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Soles PEN")
            {
                if (op == "Dollar USD")
                {
                    o = 0.299081;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 5.83099;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.270749;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 32.1631;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Rupias INR")
                {
                    o = 21.4953;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.242018;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 2.31031;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 1012.31;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 2.07702;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Rupias INR")
            {
                if (op == "Dollar USD")
                {
                    o = 0.0139140;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.271263;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.0125967;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 1.49568;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.0465217;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Libras GBP")
                {
                    o = 0.0112627;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 0.08214;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 47.4069;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.0972411;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Libras GBP")
            {
                if (op == "Dollar USD")
                {
                    o = 1.23571;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 24.0946;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 1.11838;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 132.856;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 4.13192;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 88.7889;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 9.47663;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 4152.26;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 8.51800;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Quetzal GTQ")
            {
                if (op == "Dollar USD")
                {
                    o = 0.130196;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 2.53121;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.117665;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 14.0805;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.432843;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 9.24152;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.105518;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 438.184;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.899022;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Colombian Peso COP")
            {
                if (op == "Dollar USD")
                {
                    o = 0.000297140;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.00577450;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.000268526;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 0.0321337;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.000987838;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 0.0210940;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.000240833;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 0.00228214;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.00205186;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Bolivars BOB")
            {
                if (op == "Dollar USD")
                {
                    o = 0.144819;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 2.81463;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.130876;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 15.6531;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.481459;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 10.2837;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.117398;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 1.11232;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 487.362;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
            }
        }

        private void TransformBtn_Click(object sender, RoutedEventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;

            string rutaBaseDeDatos = Directory.GetParent(workingDirectory).Parent.FullName + "\\Historial.db";

            double o, res;
            string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            coin = comboBox1.Text;
            op = comboBox2.Text;
            n = float.Parse(textBox1.Text);
            if (coin == "Dollar USD")
            {
                if (op == "Dollar USD")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 19.51;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.91;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 107.43;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 3.34;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 71.87;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.809251;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 7.68075;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 3365.41;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 6.90516;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Mexican Peso MXN")
            {
                if (op == "Dollar USD")
                {
                    o = 0.051;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Euro EUR")
                {
                    o = 0.0464174;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 5.52;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.17;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 3.68647;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.0415030;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 0.395351;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 173.175;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.355286;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Euro EUR")
            {
                if (op == "Dollar USD")
                {
                    o = 1.10;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 21.5436;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Yen JPY")
                {
                    o = 118.79;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 3.69;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 79.386;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.894153;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 8.49866;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 3724.04;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 7.64082;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Yen JPY")
            {
                if (op == "Dollar USD")
                {
                    o = 0.0093;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.18132;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.00842;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Soles PEN")
                {
                    o = 0.031070;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 0.668590;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.007529;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 0.0710064;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 31.1200;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.063885;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Soles PEN")
            {
                if (op == "Dollar USD")
                {
                    o = 0.299081;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 5.83099;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.270749;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 32.1631;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Rupias INR")
                {
                    o = 21.4953;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.242018;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 2.31031;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 1012.31;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 2.07702;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Rupias INR")
            {
                if (op == "Dollar USD")
                {
                    o = 0.0139140;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.271263;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.0125967;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 1.49568;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.0465217;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Libras GBP")
                {
                    o = 0.0112627;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 0.08214;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 47.4069;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.0972411;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Libras GBP")
            {
                if (op == "Dollar USD")
                {
                    o = 1.23571;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 24.0946;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 1.11838;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 132.856;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 4.13192;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 88.7889;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 9.47663;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 4152.26;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 8.51800;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Quetzal GTQ")
            {
                if (op == "Dollar USD")
                {
                    o = 0.130196;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 2.53121;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.117665;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 14.0805;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.432843;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 9.24152;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.105518;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 438.184;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.899022;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Colombian Peso COP")
            {
                if (op == "Dollar USD")
                {
                    o = 0.000297140;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 0.00577450;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.000268526;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 0.0321337;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.000987838;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 0.0210940;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.000240833;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 0.00228214;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
                else if (op == "Bolivars BOB")
                {
                    o = 0.00205186;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
            }
            else if (coin == "Bolivars BOB")
            {
                if (op == "Dollar USD")
                {
                    o = 0.144819;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Mexican Peso MXN")
                {
                    o = 2.81463;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Euro EUR")
                {
                    o = 0.130876;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Yen JPY")
                {
                    o = 15.6531;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Soles PEN")
                {
                    o = 0.481459;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Rupias INR")
                {
                    o = 10.2837;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Libras GBP")
                {
                    o = 0.117398;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Quetzal GTQ")
                {
                    o = 1.11232;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Colombian Peso COP")
                {
                    o = 487.362;
                    res = n * o;
                    result = res.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> " + o;
                }
                else if (op == "Bolivars BOB")
                {
                    result = n.ToString();
                    textBox2.Text = result;
                    textBox3.Text = "1 ---> 1";
                }
            }
            /*Agregar
            History historial = new History()
            {
                coin1 = comboBox1.Text,
                change1 = Convert.ToDecimal(textBox1.Text),
                coin2 = comboBox2.Text,
                change2 = Convert.ToDecimal(textBox2.Text)

            };

            using (SQLiteConnection conexion = new SQLiteConnection(rutaBaseDeDatos))
            {
                conexion.CreateTable<History>();
                conexion.Insert(historial);
            }
            Close();*/
        }
       
            
        
    }
}