using System; 
 
namespace ConsoleApp 
{ 
class Program 
{ 
static void Main(string[] args) 
{ 
 
Console.Write("Введи цифру, обозначающую день недели: "); 
int day = Convert.ToInt32(Console.ReadLine()); 
 

  if (day == 6 || day == 7) { 
  Console.WriteLine(" да "); 
  } 
  else 
    Console.WriteLine(" нет "); 
  
   
} 
     
} 
}
