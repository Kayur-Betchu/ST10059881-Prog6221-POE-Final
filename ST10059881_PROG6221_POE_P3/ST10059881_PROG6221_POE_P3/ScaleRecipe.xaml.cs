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
    /// Interaction logic for ScaleRecipe.xaml
    /// </summary>
    public partial class ScaleRecipe : Window
    {
        Data MyObject = Data.MyInstance;
        public ScaleRecipe()
        {
            InitializeComponent();
            cmbScale.Items.Add("0.5");
            cmbScale.Items.Add("2");
            cmbScale.Items.Add("3");   

            List<string> list = new List<string>(); 

            foreach (var item in MyObject.GetRecipes())
            {
                list.Add(item.RecipeName);
            }
            list.Sort();

            foreach(var item in list)
            {
                cmbRecipeSelect.Items.Add(item);
            }
        }

        private void btnScale_Click(object sender, RoutedEventArgs e)
        {
            Recipes r = MyObject.GetRecipes().Find(x => x.RecipeName.Equals(cmbRecipeSelect.SelectedItem.ToString()));
            if (r != null )
            {
                grdScale.ItemsSource = MyObject.CallScale(r, Convert.ToInt32(cmbScale.SelectedItem));
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
