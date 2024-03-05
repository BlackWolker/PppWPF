using PPE.Wpf.ViewModels;
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
    /// Logique d'interaction pour UniteView.xaml
    /// </summary>
    public partial class UniteView : UserControl
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="UniteVM"/>.
        /// </summary>
        public UniteView()
        {
            InitializeComponent();
            this.DataContext = new UniteVM();
        }
    }
}
