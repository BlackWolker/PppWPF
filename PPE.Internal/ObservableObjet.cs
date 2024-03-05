using System.ComponentModel;

namespace PPE.Internal
{
    public class ObservableObjet : INotifyPropertyChanged, INotifyPropertyChanging
    {

        #region Events

        /// <summary>
        /// se produit qunand une propriété a été changer
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;


        /// <summary>
        /// se produit quand une propriété va etre changer
        /// </summary>
        public event PropertyChangingEventHandler? PropertyChanging;
        #endregion

        #region Methodes

        /// <summary>
        /// Déclenche l'evènement PropertyChanged <see cref="PrpertyChanged"/>
        /// </summary>
        /// <param name="propertyName">Nom de la propriété qui va changé</param>
        protected void OnPropertyChanging(string propertyName) => this.PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

        /// <summary>
        /// Déclenche l'evènement PropertyChanged <see cref="PrpertyChanged"/>
        /// </summary>
        /// <param name="propertyName">Nom de la propriété qui va à changé</param>
        protected void OnPropertyChanged(string propertyName) => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));



        /// <summary>
        /// Assigne une propriété et déclenche les évènements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName">Nom de la propriété</param>
        /// <param name="field">reference de l'attribut à assigné</param>
        /// <param name="value">VAleur</param>
        protected void SetProperty<T>(string propertyName, ref T field, T value) where T : class
        {
            if ((field == null && value != null) || field?.Equals(value) == false)
            {
                OnPropertyChanging(propertyName);
                field = value;
                OnPropertyChanged(propertyName);
            }
        }
        #endregion
    }
}