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

namespace OOPDecemberExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creating lists
        List<Player> players = new List<Player>();
        List<Player> selectedPlayers = new List<Player>();
        List<Player> filteredPlayers = new List<Player>();
        int spaces = 11;
        public MainWindow()
        {



            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Player P1 = new Player("Jason", "Jordan", Position.Goalkeeper, 22);
            Player P2 = new Player("Micael", "Burke", Position.Goalkeeper, 21);
            Player P3 = new Player("Joe", "Gacquin", Position.Defender, 23);
            Player P4 = new Player("Tim", "Fahy", Position.Defender, 30);
            Player P5 = new Player("Tom", "Ruane", Position.Defender, 23);
            Player P6 = new Player("Mary", "Coppinger", Position.Defender, 27);
            Player P7 = new Player("John", "Burke", Position.Defender, 28);
            Player P8 = new Player("David", "Fahy", Position.Defender, 29);
            Player P9 = new Player("Jason", "Donnell", Position.Midfielder, 28);
            Player P10 = new Player("Shauna", "Feeney", Position.Midfielder, 22);
            Player P11 = new Player("Tomas", "Dally", Position.Midfielder, 21);
            Player P12 = new Player("Rian", "Fahy", Position.Midfielder, 23);
            Player P13 = new Player("Jonathan", "Que", Position.Midfielder, 24);
            Player P14 = new Player("Shawn", "Carrols", Position.Midfielder, 24);
            Player P15 = new Player("Sean", "Griffin", Position.Forward, 24);
            Player P16 = new Player("Peter", "Rabbit", Position.Forward, 22);
            Player P17 = new Player("Alex", "Cumber", Position.Forward, 20);
            Player P18 = new Player("Timmy", "Tomato", Position.Forward,21);

            //add to list
            players.Add(P1);
            players.Add(P2);
            players.Add(P3);
            players.Add(P4);
            players.Add(P5);
            players.Add(P6);
            players.Add(P7);
            players.Add(P8);
            players.Add(P9);
            players.Add(P10);
            players.Add(P11);
            players.Add(P12);
            players.Add(P13);
            players.Add(P14);
            players.Add(P15);
            players.Add(P16);
            players.Add(P17);
            players.Add(P18);

            //display in listbox
            LBXallPlayers.ItemsSource = players; //tell listbox that the source of items is the list players

            //sorting by players first name
            players.Sort();

        }

        private void BTNadd_Click(object sender, RoutedEventArgs e)
        {
            //figure out what item is selected
            Player selectedCourse = LBXallPlayers.SelectedItem as Player;
            //if selected activity is not null executes code
            if (selectedCourse != null)
            {
                //move a player from left to right
                players.Remove(selectedCourse);
                selectedPlayers.Add(selectedCourse);

                //If a player is added the amount of space is deceeased
                spaces--;
                TBLspaces.Text = spaces.ToString();

                //method to refresh screen
                RefreshScreen();
            }
            //if nothing is selected error message displays
            else
            {
                ErrorMessage();
            }

        }

        private void BTNremove_Click(object sender, RoutedEventArgs e)
        {
            //figure out what item is selected
            Player selectedPlayer = LBXselectedPlayers.SelectedItem as Player;
            //null check
            if (selectedPlayer != null)
            {
                //move a player from right to left
                players.Add(selectedPlayer);
                selectedPlayers.Remove(selectedPlayer);


                //If a player is removed the amount of space is increased
                spaces++;
                TBLspaces.Text = spaces.ToString();

                //method to refresh screen
                RefreshScreen();


            }
            //if nothing is selected error message displays
            else
            {
                ErrorMessage();
            }


        }

        private void RefreshScreen()
        {
            //Makes list box null and then fills it with activities again,
            LBXallPlayers.ItemsSource = null;
            LBXallPlayers.ItemsSource = players;

            //same as above but with a different list box, this is to prevent overlapping
            LBXselectedPlayers.ItemsSource = null;
            LBXselectedPlayers.ItemsSource = selectedPlayers;
            
        }

        private void ErrorMessage()
        {
            //if nothing is selected an error message will display
            //Creating an error message and giving the text block it's value (if the if statement is true)
            string errorMessage = "ERROR: You didn't select a player";
            TBLspaces.Text = errorMessage;

        }
    }
}
