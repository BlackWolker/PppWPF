using Microsoft.EntityFrameworkCore;
using PPE.DBLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace PPE.Wpf.ViewModels
{
    class ReservationVM 
    {
        #region Attributs
        /// <summary>
        /// Collection observable des réservation
        /// </summary>
        private ObservableCollection<Reservation> _Reservations;

        /// <summary>
        /// réservation sélectionné
        /// </summary>
        private Reservation _SelectedReservation;


        /// <summary>
        /// liste des packs
        /// </summary>
        private List<Pack> _Packs;


        /// <summary>
        /// liste des utilisateurs
        /// </summary>
        private List<User> _Users;


        #endregion

        #region Proprietes
        public ObservableCollection<Reservation> Reservations
        {
            get { return _Reservations; }
            set { _Reservations = value; }
        }

        public Reservation SelectedReservation
        {
            get => _SelectedReservation;
            set => _SelectedReservation = value;
        }

       

        public List<Pack> Packs
        {
            get { return _Packs; }
            set { _Packs = value; }
        }

        

        public List<User> Users
        {
            get { return _Users; }
            set { _Users = value; }
        }


        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur du ViewModel réservation.
        /// Initialise la collection des réservations à partir de la base de données en incluant les packs et les utilisateurs.
        /// </summary>
        public ReservationVM()
        {
            using (PperemastoreContext context = new())
            {
                this.Reservations = new ObservableCollection<Reservation>(context.Reservations.Include(res => res.Pack).Include(res => res.Customer));
                this.Packs = context.Packs.ToList();
                this.Users = context.Users.ToList();
            }
        }
        #endregion

        #region Methodes

        /// <summary>
        /// 
        /// </summary>
        internal void AddReservations(object parameter = null)
        {
            //using (PperemastoreContext ctx = new())
            //{
            //    Reservation? newPack = ctx.Reservations.FirstOrDefault(p => p.Name.Equals("Nouvel"));

            //    ctx.Add(newPack);
            //    Packs.Add(newPack);
            //    ctx.SaveChanges();
            //}

        }
        #endregion
    }
}
