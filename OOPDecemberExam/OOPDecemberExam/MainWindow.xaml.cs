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
        public MainWindow()
        {

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Player P1 = new Player("Jason", "Jordan", Position.Goalkeeper);
            Player P2 = new Player("Micael", "Burke", Position.Goalkeeper);
            Player P3 = new Player("Joe", "Gacquin", Position.Defender);
            Player P4 = new Player("Tim", "Fahy", Position.Defender);
            Player P5 = new Player("Tom", "Ruane", Position.Defender);
            Player P6 = new Player("Mary", "Coppinger", Position.Defender);
            Player P7 = new Player("John", "Burke", Position.Defender);
            Player P8 = new Player("David", "Fahy", Position.Defender);
            Player P9 = new Player("Jason", "Donnell", Position.Midfielder);
            Player P10 = new Player("Shauna", "Feeney", Position.Midfielder);
            Player P11 = new Player("Tomas", "Dally", Position.Midfielder);
            Player P12 = new Player("Rian", "Fahy", Position.Midfielder);
            Player P13 = new Player("Jonathan", "Que", Position.Midfielder);
            Player P14 = new Player("Shawn", "Carrols", Position.Midfielder);
            Player P15 = new Player("Sean", "Griffin", Position.Forward);
            Player P16 = new Player("Peter", "Rabbit", Position.Forward);
            Player P17 = new Player("Alex", "Cumber", Position.Forward);
            Player P18 = new Player("Timmy", "Tomato", Position.Forward);





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
            LBXallPlayers.ItemsSource = players; //tell listbox that the source of items is the list activitie

        }
    }
}
