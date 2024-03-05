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
    /// Logique d'interaction pour ReservationView.xaml
    /// </summary>
    public partial class ReservationView : UserControl
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="ReservationVM"/>.
        /// </summary>
        public ReservationView()
        {
            InitializeComponent();
            this.DataContext = new ReservationVM();
        }
    }
}
