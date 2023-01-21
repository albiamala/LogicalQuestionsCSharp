
//ACCEPT NAMES AND DESTINATION AND MERGE INTO SINGLE ARRAY

Console.WriteLine("Enter the number of passengers: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] PssName = new string[n];

    for (int i = 0; i < n; i++)
    {

       Console.WriteLine("Enter passenger names : ");
       PssName[i] = Console.ReadLine();
    
    }



string[] Destination = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter the destination : ");
    Destination[i] = Console.ReadLine();

}

//Console.WriteLine("/nMerging into passenger Array");

//var arr = PssName.Union(Destination).ToArray();

//foreach (var item in arr)
//{ 
//Console.WriteLine(item);
//}


int m = n + n ;

string[] MergedArr = new string[m];

Console.WriteLine("\nMerging arrays a & b into c in alternate position\n");
    
    for (int i = 0, k = 0; i < n; i++, k += 2)
    {
    
        MergedArr[k] = PssName[i];
    
    }
    
    
    for (int i = 0, k = 1; i < n; i++, k += 2)
    {
    
        MergedArr[k] = Destination[i];
    
    }
    
    
    Console.WriteLine("Array elements of c is:\n"); ;
    
    
    foreach (var item in MergedArr)
    {
        Console.WriteLine(item);
    }