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

namespace ST10059881_PROG6221_POE_P3
{
    /// <summary>
    /// Interaction logic for FilterRecipe.xaml
    /// </summary>
    public partial class FilterRecipe : Window
    {

        Data MyObject = Data.MyInstance;
        List<Ingredients> ingredients;
        List<Recipes> recipes;
        public FilterRecipe()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            string x = txtFilter.Text;
            recipes = MyObject.CallRecipes(x);

            if (recipes != null)
            {
                grdList.ItemsSource = recipes;
            }
            else
            {
                MessageBox.Show("Unable to find recipes with this ingredient!", "Alert", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
