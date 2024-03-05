using System;
using PPE.DBLib.Class;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

namespace PPE.Wpf.Windows
{
    /// <summary>
    /// Logique d'interaction pour LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="LoginWindow"/>.
        /// </summary>
        public LoginWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  le focus de l'application est déplacé vers le champ de texte
        /// </summary>
        private void TextEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }

        /// <summary>
        /// Texte de vérifiaction si le champ est null
        /// </summary>
        private void TxtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 0)
            {
                textEmail.Visibility = Visibility.Collapsed;
            }
            else
            {
                textEmail.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        ///  le focus de l'application est déplacé vers le champ de texte
        /// </summary>
        private void TextPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        /// <summary>
        /// Texte de vérifiaction si le champ est null
        /// </summary>
        private void TxtPassword_TextChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }


        /// <summary>
        /// Action du bouton de connexion
        /// </summary>
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string useremail = txtEmail.Text;
            string password = txtPassword.Password;

            bool isValidUser = false;
            using (PperemastoreContext context = new ())
            {
                User user = context.Users.FirstOrDefault(u => u.Email == useremail);
                if (user != null && user.Roles.Contains("ROLE_ADMIN"))
                {
                    ((App)Application.Current).Utilisateur = user;
                    user.Password = user.Password.Replace("$Password", "$2a$");
                    isValidUser = BCrypt.Net.BCrypt.Verify(password, user.Password);

                }
            }

            if (isValidUser)
            {
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou mot de passe incorrect.");
            }
        }

        /// <summary>
        /// action avec le bouton gauche de la souris la page de connexion
        /// </summary>
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        /// <summary>
        /// action avec le bouton close de la page de connexion
        /// </summary>
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
