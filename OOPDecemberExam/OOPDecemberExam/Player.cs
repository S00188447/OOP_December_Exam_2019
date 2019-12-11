using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDecemberExam
{

    public enum Position
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Forward
    }
    class Player
    {

     public string FirstName { get; set; }
     public string SurName { get; set; }
     public Position PreferredPosition { get; set; }
     public DateTime DOB { get; set; }
     public int Age { get; set; }

        public Player(string newfirstname, string newsurname, Position newpreferredposition, DateTime newDOB, int newage)
        {

            FirstName = newfirstname;
            SurName = newsurname;
            PreferredPosition = newpreferredposition;
            DOB = newDOB;
            Age = newage;

        }
    }
}
