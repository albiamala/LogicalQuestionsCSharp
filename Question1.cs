//CODING CHALLENGE

//QUESTION 1:- ACCEPT 10 PASSENGER NAMES


using System;
using System.ComponentModel;

String[] passengernames = new string[5];
int flag = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter passenger name: ");
    string name = Console.ReadLine();
    passengernames[i] = name;
}   

foreach(string name in passengernames)
    Console.WriteLine(name);


//  PRINT ALPHABETIC ORDER

 Array.Sort(passengernames);
foreach (string name in passengernames)
    Console.WriteLine(name);

//  REVERSE THE ARRAY

 Array.Reverse(passengernames);
foreach (string name in passengernames)
    Console.WriteLine(name);

// FIND A NAME FROM ARRAY

Console.WriteLine("Enter the name to search: ");
var search = Console.ReadLine();


for (int i = 0; i < 5; i++)
{
    if (passengernames[i] == search)
    {
        flag = 1;
        Console.WriteLine("Element found " + search);
        break;
    }
}
if (flag == 0)
    Console.WriteLine("Element not found.");



// LENGTH OF EACH ELEMENT

foreach (var name in passengernames)
{
    Console.WriteLine("Length of " + name + " is " + name.Length);
}


// FIND DUPLICATES IN AN ARRAY
 
Boolean f = false;
string pud = null;

    for (int i = 0; i < 5; i++)
    {
        for (int j = i + 1 ; j <= 4; j++)
        {
            if (passengernames[i] == passengernames[j])
            {
                f = true;
                pud = passengernames[i];
                break;
    
            }
        }
    }
    if (f == true)
    {
        Console.WriteLine("Duplicate element : " + pud);
    }
    else
    {
        Console.WriteLine("No duplicate element");
    }



//SPLIT NAMES AT SPACE

for (int i = 0; i < 5; i++)
{
    string[] splited = passengernames[i].Split(" ");

    foreach (var name in splited)
    {

        Console.WriteLine(name);
    }
}










