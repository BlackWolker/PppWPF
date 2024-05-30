using System;
using PPE.DBLib.Class;
using PPE.Wpf.ViewModels;
using System.Windows;


namespace PPE.Wpf.Windows
{
    /// <summary>
    /// Logique d'interaction pour AddPack.xaml
    /// </summary>
    public partial class AddPack : Window
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="AddPack"/>.
        /// </summary>
        public AddPack()
        {
            InitializeComponent();
            this.DataContext = new PackVM();
        }

        /// <summary>
        ///  action pour l'ajout de pack dans la page packs
        /// </summary>
        private void Ajout_Click(object sender, RoutedEventArgs e)
        {

            using (PperemastoreContext Context = new())
            {
                if (txtName.Text == "" || txtType.Text == "" || txtPrice.Text == "" || txtNbSlot.Text == "")
                {
                    MessageBox.Show("Vous devez remplir tous les champs.", "Attention");
                    return;
                }

                Pack pack = new Pack
                {
                    Name = txtName.Text,
                    Type = txtType.Text,
                    Price = int.Parse(txtPrice.Text),
                    NbSlot = int.Parse(txtNbSlot.Text)
                };

                if (pack != null)
                {
                    Context.Packs.Add(pack);
                    Context.SaveChanges();
                    MessageBox.Show("Pack Ajouté");
                    this.Close();
                }

            }

        }

    }
}
