using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3_4_Coffee_WPF
{
    public partial class MainWindow : Window
    {
        // ObservableCollection will automatically notify the UI of any changes
        public ObservableCollection<Coffee> Coffees { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            // Initialize the collection of coffees
            Coffees = new ObservableCollection<Coffee>(CoffeeDataSource.GetInitialCoffees());
            // Set the DataContext to this instance, allowing binding in XAML
            DataContext = this;
        }

        // Event handler for the Add Coffee button
        private void AddCoffee_Click(object sender, RoutedEventArgs e)
        {
            // Create a new Coffee object with default values
            Coffee newCoffee = new Coffee
            {
                Name = "Cup O Joe",
                Price = 1.99,
                Size = "16oz (M)",
                RoastLevel = "Medium",
                HasMilk = false
            };
            // Add the new coffee to the collection
            // This will auto update the UI due to ObservableCollection
            Coffees.Add(newCoffee);
        }

        // Event handler for the Delete Coffee button
        private void DeleteCoffee_Click(object sender, RoutedEventArgs e)
        {
            // Check if a coffee is selected in the DataGrid
            if (coffeeDataGrid.SelectedItem is Coffee selectedCoffee)
            {
                // Remove the selected coffee from the collection
                // This will automatically update the UI due to the ObservableCollection
                Coffees.Remove(selectedCoffee);
            }
        }
    }
}