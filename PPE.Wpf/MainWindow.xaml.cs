using PPE.Wpf.View;
using PPE.Wpf.Windows;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PPE.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();

            LoginWindow login = new LoginWindow();
            login.ShowDialog();

            if (login.DialogResult == false)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Événement déclenché lors du double clic pour l'application.
        /// </summary>
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
            }
        }

        /// <summary>
        /// Événement déclenché lors du clic pour la fermeture de l'application.
        /// </summary>
        private void CloseMain_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment quitter?", "Attention", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }


        /// <summary>
        /// Événement déclenché lors du clic sur le bouton Accueil du menu.
        /// </summary>
        private void Acceuil_Click(object sender, RoutedEventArgs e)
        {
            DockPanel.Children.Clear();
            DockPanel.Children.Add(new AccueilView());
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton utilisateurs du menu.
        /// </summary>
        private void Utilisateurs_Click(object sender, RoutedEventArgs e)
        {
            DockPanel.Children.Clear();
            DockPanel.Children.Add(new UserView());
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton Réservations du menu.
        /// </summary>
        private void Reservation_Click(object sender, RoutedEventArgs e)
        {
            DockPanel.Children.Clear();
            DockPanel.Children.Add(new ReservationView());
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton Packs du menu.
        /// </summary>
        private void Packs_Click(object sender, RoutedEventArgs e)
        {
            DockPanel.Children.Clear();
            DockPanel.Children.Add(new PackView());
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton Unités du menu.
        /// </summary>
        private void Unite_Click(object sender, RoutedEventArgs e)
        {
            DockPanel.Children.Clear();
            DockPanel.Children.Add(new UniteView());
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton Baies du menu.
        /// </summary>
        private void Baies_Click(object sender, RoutedEventArgs e)
        {
            DockPanel.Children.Clear();
            DockPanel.Children.Add(new BaieView());
        }

    }
}
