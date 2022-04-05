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

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para HomeJanela.xaml
    /// </summary>
    public partial class HomeJanela : Window
    {
        public HomeJanela()
        {
            InitializeComponent();
        }

        private void Btn_Adicao_Click(object sender, RoutedEventArgs e)
        {
            double n1, n2, resultado;

            n1 = Convert.ToDouble(txt_N1.Text);
            n2 = Convert.ToDouble(txt_N2.Text);

            resultado = n1 + n2;
            MessageBox.Show($"Do resultado de {n1} + {n2} é: {resultado}");
            txt_N1.Clear();
            txt_N2.Clear();
        }

        private void bt_Subtracao_Click(object sender, RoutedEventArgs e)
        {
            double n1, n2, resultado;

            n1 = Convert.ToDouble(txt_N1.Text);
            n2 = Convert.ToDouble(txt_N2.Text);
            resultado = n1 - n2;
            MessageBox.Show($"Do resultado de {n1} - {n2} é: {resultado}");
            txt_N1.Clear();
            txt_N2.Clear();
        }

        private void bt_Divisao_Click(object sender, RoutedEventArgs e)
        {
            double n1, n2, resultado;

            n1 = Convert.ToDouble(txt_N1.Text);
            n2 = Convert.ToDouble(txt_N2.Text);
            resultado = n1 / n2;
            MessageBox.Show($"Do resultado de {n1} / {n2} é: {resultado}");
            txt_N1.Clear();
            txt_N2.Clear();
        }

        private void bt_Multiplicacao_Click(object sender, RoutedEventArgs e)
        {

            double n1, n2, resultado;

            n1 = Convert.ToDouble(txt_N1.Text);
            n2 = Convert.ToDouble(txt_N2.Text);
            resultado = n1 * n2;
            MessageBox.Show($"Do resultado de {n1} x {n2} é: {resultado}");
            txt_N1.Clear();
            txt_N2.Clear();
        }

        private void Btn_Sair2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
