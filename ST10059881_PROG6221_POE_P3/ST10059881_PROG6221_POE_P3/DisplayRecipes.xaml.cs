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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace ST10059881_PROG6221_POE_P3
{
    /// <summary>
    /// Interaction logic for DisplayRecipes.xaml
    /// </summary>
    public partial class DisplayRecipes : Window
    {
        Data MyObject = Data.MyInstance;
        public DisplayRecipes()
        {
            InitializeComponent();
            grdRecipeNames.ItemsSource = MyObject.GetRecipes();
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
