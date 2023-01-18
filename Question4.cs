//ACCEPT PASSENGERS DATE OF BIRTH
//-------------------------------

Console.WriteLine("Enter the Date of Birth: ");
DateTime DOB = Convert.ToDateTime(Console.ReadLine());

var year = DOB.Year;
Console.WriteLine(year);

DateTime today = DateTime.Now;
Console.WriteLine(today);   

int age = today.Year - year;
Console.WriteLine("Your age is " + age);

Console.WriteLine("Your age in hours is " + (age* 8760));

Console.WriteLine("Your age in days is " + (age*365) );

Console.WriteLine("Your age in weeks is " + (age*52));

Console.WriteLine("Your age in months is " + (age*12));

if (year % 4 ==0 )
{
    Console.WriteLine("You are born in leap year.");
}

else
{
    Console.WriteLine("Not born in leap year");
}






