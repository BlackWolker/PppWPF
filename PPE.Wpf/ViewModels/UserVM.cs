using Microsoft.EntityFrameworkCore;
using PPE.DBLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace PPE.Wpf.ViewModels
{
    /// <summary>
    /// ViewModel pour la gestion des Utilisateurs.
    /// </summary>
    class UserVM
    {
        #region Attributs

        /// <summary>
        ///     Collection observable des Utilisateurs
        /// </summary>
        private ObservableCollection<User> _Users;

        /// <summary>
        ///  Utilisateur sélectionné
        /// </summary>
        private User _SelectedUser;

        /// <summary>
        /// Ajout d'utilisateur
        /// </summary>
        private User _AddUser;

        #endregion

        #region Proprietes
        public ObservableCollection<User> Users
        {
            get { return _Users; }
            set { _Users = value; }
        }

        public User SelectedUser
        {
            get => _SelectedUser;
            set => _SelectedUser = value;
        }

        public User AddUser
        {
            get { return _AddUser; }
            set { _AddUser = value; }
        }

        public List<string> Roles { get; set; }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur du ViewModel User.
        /// création de la liste de Role;
        /// Initialise la collection des Utilisateurs à partir de la base de données.
        /// </summary>
        public UserVM()
        {
            Roles = new List<string>();
            Roles.Add("ADMIN");
            Roles.Add("ClIENT");
            using (PperemastoreContext context = new())
            {
                this.Users = new ObservableCollection<User>(context.Users);
            }
        }
        #endregion

        #region Methodes

        /// <summary>
        /// supprimer un utiisateur
        /// </summary>
        internal void RemoveUser(object parameter = null)
        {
            using (PperemastoreContext Context = new())
            {
                if (SelectedUser != null)
                {
                    MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet User?", "Attention", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.No)
                    {
                        return;
                    }
                    else
                    {
                        // Supprimer les réservations associées à l'employé
                        Context.Reservations.RemoveRange(SelectedUser.Reservations);

                        Context.Users.Remove(SelectedUser);
                        Context.SaveChanges();
                    }
                }
            }
        }
        #endregion

    }


}
