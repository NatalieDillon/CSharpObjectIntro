using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpObjectIntro.Classes.Diary;
using CSharpObjectIntro.Classes.BankAccount;
using System.Diagnostics;

namespace CSharpObjectIntro
{
    internal class OOPExercises
    {
        internal static void Run()
        {
            UseDiary();
        }

        internal static void UseDiary()
        {            
            // Create a new diary 
            Diary book = new Diary("Bob Smith");
            Console.WriteLine(book.Name);
            DateOnly eventDate = new DateOnly(2022, 10, 10);                      

            // Add some events to your diary
            book.AddEvent(eventDate, 19, "Party", "Barnes");
            book.AddEvent(eventDate, 10, "Hockey Training", "Barn Elms");

            // Now check how many events you have on a particular day
            int numEvents = book.CheckDiary(eventDate);
            Console.WriteLine(numEvents);
            Debug.Assert(numEvents == 2);

            // Implement a new method in the Diary class to return the number of morning events on a particular day
            // Call this method
            int numMorningEvents = book.CheckMorningEvents(eventDate);
            Console.WriteLine(numMorningEvents);
            Debug.Assert(numMorningEvents == 1);
        }

        internal static void UseBankAccount()
        {
            // Implement your bank account class following the instructions in the BankAccount class

            // Write calling code from here
        }
    }
}

