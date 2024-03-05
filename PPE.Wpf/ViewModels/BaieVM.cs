using Microsoft.EntityFrameworkCore;
using PPE.DBLib.Class;
using PPE.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PPE.Wpf.ViewModels
{
    class BaieVM
    {
        #region Attributs
        /// <summary>
        /// Collection observable des baie
        /// </summary>
        private ObservableCollection<Baie> _Baies;

        /// <summary>
        /// baie sélectionné
        /// </summary>
        private Baie _SelectedBaie;


        #endregion

        #region Proprietes
        public ObservableCollection<Baie> Baies
        {
            get { return _Baies; }
            set { _Baies = value; }
        }

        public Baie SelectedBaie
        {
            get => _SelectedBaie;
            set => _SelectedBaie = value;
        }

        #endregion

        #region Constructeur

        /// <summary>
        /// 
        /// </summary>
        public BaieVM()
        {
            using (PperemastoreContext context = new())
            {
                this.Baies = new ObservableCollection<Baie>(context.Baies);
            }
        }
        #endregion

        #region Methodes

        #endregion
    }
}
