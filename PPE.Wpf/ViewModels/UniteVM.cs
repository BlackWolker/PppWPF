using Microsoft.EntityFrameworkCore;
using PPE.DBLib.Class;
using PPE.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace PPE.Wpf.ViewModels
{
    /// <summary>
    /// ViewModel pour la gestion des Unités.
    /// </summary>
    class UniteVM
    {
        #region Attributs
        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<Unite> _Unites;

        /// <summary>
        /// l'unité sélectionné
        /// </summary>
        private Unite _SelectedUnite;


        /// <summary>
        /// la liste des réservation pour les unités
        /// </summary>
        private List<Reservation> _Reservations;


        /// <summary>
        /// la liste des baie pour les unités
        /// </summary>
        private List<Baie> _Baies;


        #endregion

        #region Proprietes
        public ObservableCollection<Unite> Unites
        {
            get { return _Unites; }
            set { _Unites = value; }
        }

        public Unite SelectedUnite
        {
            get => _SelectedUnite;
            set => _SelectedUnite = value;
        }


        public List<Reservation> Reservations
        {
            get { return _Reservations; }
            set { _Reservations = value; }
        }



        public List<Baie> Baies
        {
            get { return _Baies; }
            set { _Baies = value; }
        }


        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur du ViewModel Unité.
        /// Initialise la collection des Unités à partir de la base de données en incluant les réservation et les baies.
        /// </summary>
        public UniteVM()
        {
            using (PperemastoreContext context = new())
            {
                this.Unites = new ObservableCollection<Unite>(context.Unites.Include(uni => uni.ReservationId).Include(uni => uni.BaieId));
                this.Reservations = context.Reservations.ToList();
                this.Baies = context.Baies.ToList();
            }
        }
        #endregion

        #region Methodes

        #endregion
    }
}