//ACCEPT FLIGHT FARE AND DESTINATIONS

 
   //array to accept destination
    String[] Destination = new string[5];
    
    for (int i = 0; i < Destination.Length; i++)
    {
        Console.WriteLine("Enter the destination : ");
        Destination[i] = Console.ReadLine();
    }
    
 
   //array to accept flightfare  
    Double[] flightFare = new double[5];
    
    for (int i = 0; i < flightFare.Length ; i++)
    {
        Console.WriteLine("Enter flight fares: ");
        flightFare[i] = Convert.ToDouble(Console.ReadLine());
    }
    
    
    Console.WriteLine("Enter nth number to display corresponding destination and fare: ");
    int index = int.Parse(Console.ReadLine());
    
    if (index > Destination.Length)
    {
        Console.WriteLine("Enter valid number");
    }
    
    else
    {
        Console.WriteLine($" Destination : {Destination[index]} | Fare : {flightFare[index]}");
    }
    
    
    
    
