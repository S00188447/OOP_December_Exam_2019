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

     static Random ran = new Random();

        public Player(string newfirstname, string newsurname, Position newpreferredposition)
        {

            FirstName = newfirstname;
            SurName = newsurname;
            PreferredPosition = newpreferredposition;
            //DOB = newDOB;
            //Age = newage;


        }



        //private Random gen = new Random();
        //DateTime RandomDay(string newdob)
        //{
        //    DateTime minagevalue = new DateTime(1900, 1, 1);
        //    int range = (DateTime.Today - minagevalue).Days;
        //    minagevalue.AddDays(gen.Next(range));

        //    int age = 0;
        //    age = DateTime.Now.Year - minagevalue.Year;
        //    if (DateTime.Now.DayOfYear < minagevalue.DayOfYear)
        //        age = age - 1;

        //    return age;
        //}


    }
}
