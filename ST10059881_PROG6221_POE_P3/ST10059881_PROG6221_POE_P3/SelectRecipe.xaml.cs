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
    /// Interaction logic for SelectRecipe.xaml
    /// </summary>
    public partial class SelectRecipe : Window
    {
        Data MyObject = Data.MyInstance;
        public SelectRecipe()
        {
            InitializeComponent();
            List<string> RecipeNameList = new List<string>();

            foreach (var item in MyObject.GetRecipes())
            {
                RecipeNameList.Add(item.RecipeName);
            }

            RecipeNameList.Sort();

            foreach (var recipeName in RecipeNameList)
            {
                cmbRecipe.Items.Add(recipeName);
            }


        }

        private void SelectRecipe_Load(object sender, RoutedEventArgs e)
        {
            List<string> RecipeNameList = new List<string>();
            
            foreach (var item in MyObject.GetRecipes())
            {
                RecipeNameList.Add(item.RecipeName);
                cmbRecipe.Items.Add(item.RecipeName);
            }
            
           
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            string recipeNames = cmbRecipe.SelectedItem.ToString();
            Recipes r = MyObject.GetRecipes().Find(x => x.RecipeName.Equals(recipeNames));

            if(recipeNames.Equals(r.RecipeName))
            {
                grdIngredients.ItemsSource = r.ingredients;
                grdSteps.ItemsSource = r.Steps;
            }
            
            //grdIngredients.ItemsSource = MyObject.GetIngredients();
            //grdSteps.ItemsSource = MyObject.GetSteps();
        }
    }
}
