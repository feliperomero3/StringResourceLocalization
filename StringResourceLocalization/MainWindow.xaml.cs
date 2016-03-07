using System.Globalization;
using System.Threading;
using System.Windows;

namespace StringResourceLocalization
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            InitializeComponent();
        }
    }
}
