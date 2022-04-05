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

namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, RoutedEventArgs e)
        {
            string nome, senha;
            nome = txt_Nome.Text;
            senha = passwordbox_senha.Password.ToString();
            /*
             * Jeito de conferir a senha do usuário
             
            if (nome.Equals("Maria Eduarda") && senha.Equals("maria"))
            {
                MessageBox.Show("Usuário existente");
                HomeJanela principal = new HomeJanela();
                principal.ShowDialog();
            }
            else
            { 
                MessageBox.Show("Usuário inválido");
            }*/
            if ((nome != "") && (senha != ""))
            { 
                MessageBox.Show("Usuário existente");
            HomeJanela principal = new HomeJanela();
            principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário inválido");
            }
        }

        private void txt_Nome_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_Nome.Text = string.Empty;
        }

        private void txt_Nome_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txt_Nome.Text.Equals(""))
                txt_Nome.Text = "E-mail ou nome de usuário";
        }


        private void Btn_Sair_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /*
private void bt_Login_Click_1(object sender, RoutedEventArgs e)
{
   HomeJanela principal = new HomeJanela();

   if
   if (txt_Nome.Text.Equals(""))
      principal.ShowDialog();
   else
       MessageBox.Show("Usuário e senha errado");
}*/
    }
}
