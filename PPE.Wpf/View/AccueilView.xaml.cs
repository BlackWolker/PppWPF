using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace PPE.Wpf.View
{
    /// <summary>
    /// Logique d'interaction pour AccueilView.xaml
    /// </summary>
    public partial class AccueilView : UserControl
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="BaieVM"/>.
        /// </summary>
        public AccueilView()
        {
            InitializeComponent();
        }
        
        //private void LoginButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string useremail = txtUser.Text;
        //    string password = txtPass.Password;


        //    bool isValidUser = AuthenticateUser(useremail, password);

        //    if (isValidUser)
        //    {
        //        Window Homewindow = new Window();
        //        {
        //            Content = new Home();
        //            Title = "Home";
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
        //    }
        //}

        //private bool AuthenticateUser(string useremail, string password)
        //{
        //    using (PpeContext context = new PpeContext())
        //    {

        //        DBLib.Class.User user = context.Users.FirstOrDefault(u => u.Email == useremail);

        //        return true;
        //        //return user != null;
        //    }
        //}
    }
}
