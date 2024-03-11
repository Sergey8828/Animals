// **********************************************************************************************
// * Author      : Sergey Mukosiei                                                              *
// * Description : This program contains several classes of animals, displays animals and then  *
//                  has filters on whether they are herbivores or carnivores. Other animal      *
//                  features are also shown.                                                    *
// **********************************************************************************************
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

namespace Project_Animals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Animal> animals = new List<Animal>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_loaded(object sender, RoutedEventArgs e)
        {
            Giraffe g1 = new Giraffe() { Continent = "Africa", Gender = "Male", Description = "A 5 year old bred in captivity", SpeciesName = "Giraffa", FoodKgPerWeightKg = 0.04, NeckLength = 1.8, Name = "Gary" };
            Elephant e1 = new Elephant() { Continent = "Africa", Gender = "Female", Description = "A beautiful speciman of African Elephant", ElephantType = Elephant.TypeOfElephant.African, FoodKgPerWeightKg = 0.1, SpeciesName = "Elephantidae", TuskLength = 6.1, Name = "Nelly" };
            BigCat bc1 = new BigCat() { Continent = "Africa", Description = "One of two males transferred from Paris Zoo in 2015", Gender = "Male", KillsWith = "Claws and Teeth", SpeciesName = "Panthera leo", TypeOfOrganisation = BigCat.OrganisationType.Pride, Name = "Lenny" };
            Bear b1 = new Bear() { Continent = "North America", SpeciesName = "Ursidae", Description = "Brown Bear rescued from the wild and brought back to full health", Endangered = true, Name = "Benny", KillsWith = "Claws", Gender = "Male" };

            animals.Add(g1);
            animals.Add(b1);
            animals.Add(bc1);
            animals.Add(e1);

            lbxAnimals.ItemsSource = animals;
        }

        //method to add details of the animal
        private void lbxAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Animal selectedAnimal = lbxAnimals.SelectedItem as Animal;

            if (selectedAnimal != null)
            {
                if (selectedAnimal.GetType().Name.Equals("Bear"))
                    imgDetailsAnimal.Source = new BitmapImage(new Uri("/Images/bear.png", UriKind.Relative));

                if (selectedAnimal.GetType().Name.Equals("BigCat"))
                    imgDetailsAnimal.Source = new BitmapImage(new Uri("/Images/lion.png", UriKind.Relative));

                if (selectedAnimal.GetType().Name.Equals("Elephant"))
                    imgDetailsAnimal.Source = new BitmapImage(new Uri("/Images/elephant.png", UriKind.Relative));

                if (selectedAnimal.GetType().Name.Equals("Giraffe"))
                    imgDetailsAnimal.Source = new BitmapImage(new Uri("/Images/giraffe.png", UriKind.Relative));

                tblkDetails.Text = selectedAnimal.GetDetail();
            }
        }

        //method to filter animals
        private void Radiobtn_Checked(object sender, RoutedEventArgs e)
        {
            lbxAnimals.SelectedIndex = -1;
            imgDetailsAnimal.Source = null;
            tblkDetails.Text = "";

            // Determine which radio button was checked

            RadioButton selectedRadioButton = sender as RadioButton;
            string selected = selectedRadioButton.Tag.ToString();      // Will get one of the tags - All, Carnivores, Herbivores

            // Filter based on this

            if (selected.Equals("All"))
                lbxAnimals.ItemsSource = animals;
            else
            {
                if (selected.Equals("Carnivore"))
                {
                    lbxAnimals.ItemsSource =
                        animals.Where(anim => anim.GetType().Name.Equals("Bear") || anim.GetType().Name.Equals("BigCat"));
                }
                else if (selected.Equals("Herbivore"))
                {
                    lbxAnimals.ItemsSource =
                        animals.Where(anim => anim.GetType().Name.Equals("Giraffe") || anim.GetType().Name.Equals("Elephant"));
                }
            }
        }
    }
}
