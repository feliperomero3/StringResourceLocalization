using System;
using System.Diagnostics;
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
            InitializeComponent();
        }

        private void menuItemEn_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            ResetMainWindow();

            Debug.Print("en-US");
        }

        private void menuItemEs_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es-ES");
            ResetMainWindow();

            Debug.Print("es-ES");
        }

        private void menuItemFr_Click(object sender, RoutedEventArgs e)
        {            
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR");
            ResetMainWindow();

            Debug.Print("fr-FR");
        }

        private void menuItemDe_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE");
            ResetMainWindow();

            Debug.Print("de-DE");
        }

        private void menuItemPr_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pt-BR");
            ResetMainWindow();

            Debug.Print("pt-BR");
        }

        private void ResetMainWindow()
        {
            Window oldWindow = Application.Current.MainWindow;

            Application.Current.MainWindow = new MainWindow();
            Application.Current.MainWindow.Show();

            oldWindow.Close();
        }
    }
}
