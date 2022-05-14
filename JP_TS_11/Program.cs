using Newtonsoft.Json;
using JP_TS_11;






// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*int age = 0;
Console.WriteLine("input your age:");
///  (code=>copiled=>.net)=>comp

try
{
   age = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally {
    age = int.Parse(Console.ReadLine());
} */

Person.Print();



Person person1 = new Person(15) {  Name="John", Surname="Smith"};


//person1.TellMeYourAge();
/* რეკურსიის მაგალითები გასაკეთებელი!*/
//person1.Print();

Console.WriteLine($" {person1.Name}, is {person1.Age}, his id is {person1.MyIdIs()}");


Person person2 = new Person(20) {  Name = "Anna", Surname = "Grifind" };

person2.TellMeYourAge();







/*double kako =  9.1259654315;
Console.WriteLine( Math.Round(kako));*/

for (int i = 0; i < 3; i++)
{

}



Console.WriteLine(11 % 3);

int[] integers =  { 1,3,7, 2 ,8,5};


int GetRandom()
{
    return new Random().Next(0,999);
}


Console.WriteLine( GetRandom());
Console.WriteLine(GetRandom());
Console.WriteLine(GetRandom());

//(*,/,+,-)
int Calculator(int num1, int num2, string symbol)
{
    var result = 0;
    
    switch (symbol)
    {
        case "*": result= num1 * num2;
            break;


            default: return 0;
    }
    //dsadsadsadas
    //dsadsadsa
    return result; 
}

void PrintArray(int[] arr)
{
    foreach (int i in arr)
        Console.Write($"{i} ");
}

Console.WriteLine("this is console print array");
PrintArray(integers);
Console.WriteLine("---------------------------");

for (int i = 0; i < integers.Length; i++)
{
    for(int j = i+1; j < integers.Length; j++)
    {

        if (integers[i] + integers[j] == 10)
             Console.WriteLine($"{integers[i]} + {integers[j]} = {integers[i] + integers[j]}");
           
    }
    
}




int[,] arr1 = new int[5,10];

int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };


Console.WriteLine("------");

int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[4] { 1, 2, 3, 4 };


jaggedArray[1] = new int[5] { 1, 2, 3, 4, 5 };
jaggedArray[2] = new int[3] {  3, 4, 5 };


foreach (var i in jaggedArray)
{
    foreach (var j in i)
    {
        Console.Write($"{j} ");
    }
    Console.WriteLine();
}


//Console.WriteLine(JsonConvert.SerializeObject(arr1, Formatting.Indented));

/*for (int i = 0; i < arr1.GetLength(0); i++)
{
    arr1[i,i] = 10;
}



for (int i = 0; i < arr1.GetLength(0); i++)
{
    //Console.Write( arr1[i, i] +" ") ;
    for(int j = 0; j < arr1.GetLength(1); j++)
    {
        Console.Write(arr1[i, j] +" ");
    }
    Console.WriteLine();
}*/

List<int> ints = new List<int>();



/*
for (int i = 0; i < 10; i++)
{

    ints.Add(i);
}


foreach (int i in ints)
{
    Console.WriteLine(i);
}*/







//int age;

int price;


/*while (false)
{
    Console.WriteLine("new line");
}


do
{
    Console.WriteLine("new line");
} while (false);
*/
/*
for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"{i} ");

    for (int j = 0; j < 25; j++)
    {
        Console.Write($"{j} ");
    }
    Console.WriteLine();
}*/




/*Console.WriteLine("==================================");
foreach (int i in integers)
{
    Console.WriteLine(i);
}
*/


/*
Console.WriteLine($"your number is {integer}  ");

Console.Write("input apple price:");

var clientText =Console.ReadLine();

price = (int) double.Parse(clientText);

Console.WriteLine($"aple price  is about {price}");

//> < >= <= == '1' === 1

bool isExpensive = price>=5;

if (isExpensive)
{
    Console.WriteLine("apple is expensive");
}
else
{
    Console.WriteLine("apple is cheap");
}
*/

/*for (int i = 0; i < 15; i++)
{
    Console.WriteLine("new line");
}
*/

 

