using PPE.DBLib.Class;
using PPE.Wpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace PPE.Wpf.Windows
{
    /// <summary>
    /// Logique d'interaction pour AddUtilisateur.xaml
    /// </summary>
    public partial class AddUtilisateur : Window
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="AddUtilisateur"/>.
        /// </summary>
        public AddUtilisateur()
        {
            InitializeComponent();
            this.DataContext = new UserVM();
        }

        /// <summary>
        ///  action pour l'ajout d'utilisateur dans la page utilisateurs
        /// </summary>
        private void Ajout_Click(object sender, RoutedEventArgs e)
        {
            
            using (PperemastoreContext Context = new())
            {
                User selectedRole = cmbRole.SelectedItem as User;

                if (txtNom.Text == "" || txtPrenom.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Vous devez remplir tous les champs.", "Attention");
                    return;
                }

                User utilisateur = new User
                {
                    LastName = txtNom.Text,
                    FirstName = txtPrenom.Text,
                    Addresse = txtAddresse.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Roles = selectedRole.Roles,

                };

                if (utilisateur != null)
                {
                    Context.Users.Add(utilisateur);
                    Context.SaveChanges();
                    MessageBox.Show("utilisateur Ajouté");
                    this.Close();
                }

            }
        }
    }
}
