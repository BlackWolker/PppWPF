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
    /// Logique d'interaction pour PackView.xaml
    /// </summary>
    public partial class PackView : UserControl
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="PackVM"/>.
        /// </summary>
        public PackView()
        {
            InitializeComponent();
            this.DataContext = new PackVM();
        }

        /// <summary>
        /// Événement déclenché lors du clic pour ajouter un pack.
        /// </summary>
        private void Button_AjoutPack(object sender, RoutedEventArgs e)
        {
            AddPack fenetre = new();
            fenetre.ShowDialog();
        }

        /// <summary>
        /// Événement déclenché lors du clic pour supprimer un pack.
        /// </summary>
        private void SupprimerPack_Click(object sender, RoutedEventArgs e)
        {
            ((PackVM)this.DataContext).RemovePack();
        }
    }
}
