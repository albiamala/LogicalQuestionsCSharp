using System.Linq.Expressions;

//ACCEPT PASSENGER NAMES AND MILES

Console.WriteLine("Enter your name : ");
string? passengerName = Console.ReadLine();

Console.WriteLine("Enter the total miles travelled : ");
double miles = Convert.ToDouble(Console.ReadLine());

   switch (miles)
   {
   
       case (>= 10000 and < 20000):
           Console.WriteLine("You are awarded 10 frequent flyer points ");
           break;
   
       case (>= 20000 and < 50000):
           Console.WriteLine("You are awarded 20 frequent flyer points ");
           break; 
   
       case ( >= 50000 and < 100000 ):
           Console.WriteLine("You are awarded 30 frequent flyer points ");
           break;
   
       case ( >= 100000  ):
           Console.WriteLine("You are awarded 50 frequent flyer points ");
           break;
   
           default:
           Console.WriteLine(miles + " is not right!");
           break;
   
   
   }