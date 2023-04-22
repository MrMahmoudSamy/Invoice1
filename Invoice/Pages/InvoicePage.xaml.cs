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

namespace Invoice.Pages
{
    /// <summary>
    /// Interaction logic for InvoicePage.xaml
    /// </summary>
    public partial class InvoicePage : Page
    {
        private MainWindow _mainWindow;

        public InvoicePage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _mainWindow.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if(printDialog.ShowDialog()==true)
                {
                    printDialog.PrintVisual(printPage,"Invoice");
                }

            }
            catch (Exception)
            {
               
                
            }
            finally
            {
                _mainWindow.IsEnabled = true;
            }
        }
    }
}
