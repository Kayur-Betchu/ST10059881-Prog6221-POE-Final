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
    /// Interaction logic for AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Window
    {
        Data MyObject = Data.MyInstance;
        public AddRecipe()
        {
            InitializeComponent();
            
        }

        private void btnAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            String RecipeName=txtRecipeName.Text;

            Recipes r = new Recipes(RecipeName,MyObject.GetSteps(),MyObject.GetIngredients());
            MyObject.AddRecipe(r);
            MessageBox.Show("RECIPE WAS ADDED SUCCESSFULLY!!!");

            MyObject.ReinitializeIngredients();
            MyObject.ReinitializeSteps(); 

            //Ingredients ingredients = new Ingredients(RecipeName, IngredientName, Calories, Quantity, UnitOfMeasurement, FoodGroup /*Steps*/);


        }

        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            String IngredientName = txtIngredientName.Text;
            int Calories = int.Parse(txtCalories.Text);
            double Quantity = Convert.ToInt32(txtQuantity.Text);
            String UnitOfMeasurement = txtUnit.Text;
            String FoodGroup = txtFoodGroup.Text;
            

            //Ingredients ingredients = new Ingredients(IngredientName, Calories, Quantity, UnitOfMeasurement, FoodGroup);
            MyObject.AddIngredient(new Ingredients(IngredientName, Calories, Quantity, UnitOfMeasurement, FoodGroup));
            MessageBox.Show("INGREDIENT WAS ADDED TO RECIPE!!!");
        }

        private void btnAddStep_Click(object sender, RoutedEventArgs e)
        {
            String Steps = txtSteps.Text;
            MyObject.GetSteps().Add(Steps);
            MessageBox.Show("STEP WAS ADDED TO RECIPE!!!");
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
