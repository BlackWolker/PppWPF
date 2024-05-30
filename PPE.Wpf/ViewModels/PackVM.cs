using Microsoft.EntityFrameworkCore;
using PPE.DBLib.Class;
using PPE.Internal;
using System.Collections.ObjectModel;
using System.Windows;

namespace PPE.Wpf.ViewModels
{
    class PackVM : ObservableObjet
    {
        #region Attributs
        /// <summary>
        /// Collection observable des pack
        /// </summary>
        private ObservableCollection<Pack> _Packs;

        /// <summary>
        /// Pack sélectionné
        /// </summary>
        private Pack _SelectedPack;

        /// <summary>
        /// Ajout de pack
        /// </summary>
        private Pack _AddPack;

        #endregion

        #region Proprietes
        public ObservableCollection<Pack> Packs
        {
            get { return _Packs; }
            set { SetProperty(nameof(Packs), ref _Packs, value); }
        }

        public Pack SelectedPack
        {
            get => _SelectedPack;
            set => SetProperty(nameof(SelectedPack), ref _SelectedPack, value);
        }

        public Pack AddPack
        {
            get { return _AddPack; }
            set { SetProperty(nameof(AddPack), ref _AddPack, value); }
        }

        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur du ViewModel réservation.
        /// Initialise la collection des réservations à partir de la base de données.
        /// </summary>
        public PackVM()
        {
            using (PperemastoreContext context = new ())
            {
                this.Packs = new ObservableCollection<Pack>(context.Packs);
            }
        }
        #endregion

        #region Methodes

        /// <summary>
        /// supression d'un pack
        /// </summary>
        internal void RemovePack(object parameter = null)
        {
            using (PperemastoreContext Context = new())
            {
                if (SelectedPack != null)
                {
                    MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet Pack?", "Attention", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.No)
                    {
                        return;
                    }
                    else
                    {
                        // Supprimer les réservations associées à l'employé
                        Context.Reservations.RemoveRange(SelectedPack.Reservations);

                        Context.Packs.Remove(SelectedPack);
                        Context.SaveChanges();
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        //public void updatePack()
        //{
        //    using (PperemastoreContext ctx = new())
        //    {
        //        if (this.SelectedPack != null)
        //        {
        //            var packToUpdate = ctx.Packs.Find(SelectedPack.Id);

        //            if (packToUpdate != null)
        //            {

        //                packToUpdate.Reduction = this.SelectedPack.Reduction;
        //                packToUpdate.Nom = this.SelectedPack.Nom;
        //                packToUpdate.Prix = this.SelectedPack.Prix;
        //                packToUpdate.NombreEmplacement = this.SelectedPack.NombreEmplacement;

        //                ctx.SaveChanges();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Erreur veuillez sélectionner un champ valide");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Erreur veuillez sélectionner un champ");
        //        }
        //    }
        //}

        //internal bool updatePack(object? parameter = null) => this.SelectedPack != null;
    }
        #endregion
    
}
