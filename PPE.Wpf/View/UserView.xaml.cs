using PPE.Wpf.ViewModels;
using PPE.Wpf.Windows;
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

namespace PPE.Wpf.View
{
    /// <summary>
    /// Logique d'interaction pour UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="UserView"/>.
        /// </summary>
        public UserView()
        {
            InitializeComponent();
            this.DataContext = new UserVM();
        }

        /// <summary>
        /// Événement déclenché lors du clic pour ajouter un utilisateur.
        /// </summary>
        private void Button_AjoutUser(object sender, RoutedEventArgs e)
        {
            AddUtilisateur fenetre = new();
            fenetre.ShowDialog();
        }

        /// <summary>
        /// Événement déclenché lors du clic pour supprimer un utilisateur.
        /// </summary>
        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            ((UserVM)this.DataContext).RemoveUser();
        }
    }
}
