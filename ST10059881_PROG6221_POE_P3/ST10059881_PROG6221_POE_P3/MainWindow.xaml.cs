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

namespace ST10059881_PROG6221_POE_P3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Data MyObject = Data.MyInstance;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipe addRecipe= new AddRecipe();
            addRecipe.Show();
            this.Close();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            DisplayRecipes displayRecipes = new DisplayRecipes();
            displayRecipes.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure that you want to clear all recipes?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            { 
                MyObject.ReinitializeRecipes();
                MessageBox.Show("RECIPES DELETED SUCCESSFULLY !!!");
                // Recipe list top be reinitialized
            }
            else if (result == MessageBoxResult.No)
            {
                // Nothing to be done
            }
            
            
            
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            SelectRecipe selectRecipe = new SelectRecipe();
            selectRecipe.Show();
            this.Close();
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            FilterRecipe filterRecipe = new FilterRecipe();
            filterRecipe.Show();
            this.Close();
        }

        private void btnScale_Click(object sender, RoutedEventArgs e)
        {
            ScaleRecipe scaleRecipe = new ScaleRecipe();
            scaleRecipe.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
