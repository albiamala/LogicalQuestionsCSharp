﻿//QUESTION 3 :- ACCEPT FLIGHT FARE IN DECIMAL FORMAT

using System;

int flag = 0;
double[] flightfare = new double[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter flight fare : ");
    double fare = Convert.ToDouble(Console.ReadLine());
    flightfare[i] = fare;
}

 // PRINT ASCENDING ORDER

  Array.Sort(flightfare);
  foreach (double fare in flightfare)
   
  Console.WriteLine(fare);


// PRINT DESCENDING ORDER

  Array.Reverse(flightfare);
  foreach (double fare in flightfare)

  Console.WriteLine(fare);


// SEARCH IN ARRAY

Console.WriteLine("Enter the fare to search: ");
double search = Convert.ToDouble(Console.ReadLine());


for (int i = 0; i < 10; i++)
{
    if (flightfare[i] == search)
    {
        flag = 1;
        Console.WriteLine("Element found " + search);
        break;
    }
}
if (flag == 0)
    Console.WriteLine("Element not found.");


 // PRINT MINIMUM FARE
 Array.Sort(flightfare);
 Console.WriteLine("Minimum fare is " + flightfare[0]);


 // PRINT MAXIMUM FARE
 Array.Reverse(flightfare);
 Console.WriteLine("Maximum fare is " + flightfare[0]);


// PRINT DUPLICATE ELEMENTS

   Boolean f = false;


   for (int i = 0; i < 10; i++)
   {
       for (int j = i + 1; j <= 9; j++)
       {
           if (flightfare[i] == flightfare[j])
           {
               f = true;
            Console.WriteLine("Duplicate Found : " + flightfare[i]);
   
           }
       }
   }
   if (!f)
  {
    Console.WriteLine("No duplicates");
  }
   
   