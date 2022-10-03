using ThiagoDonasVieira_d7_avaliacao.Data;
using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace ThiagoDonasVieira_d7_avaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context context;
        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
        }
       
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool autenticado = false;
            string userLogin = TextBox1.Text;
            string senha = TextBox2.Text;
            var users = context.Users.ToList();
            foreach(var user in users)
            {
                if(user.UserLogin == userLogin)
                {
                    if(user.Password == senha)
                    {
                        autenticado = true;
                    }
                }
               
            }
            if (autenticado)
            {
                MessageBox.Show("Usuário autenticado!");
            }
            else
            {
                MessageBox.Show("Credenciais inválidas");
            }
            
        }
    }
}
