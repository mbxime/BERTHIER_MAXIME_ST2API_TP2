using System;

namespace ST2API_TP2_BerthierMaxime
{
    class Program
    {
           static void Main(string[] args){
               
               
               // Q1
               Api Weather1 = new Api();
               Console.WriteLine("What's the weather like in Morocco ? \n");
               City morocco = new City("morocco");
               Root weatherMorocco = Weather1.Request(morocco);
               Console.WriteLine(weatherMorocco[0]);
               
               
               
               
               // Q2
               Api Weather2 = new Api();
               Console.WriteLine("When will the sun rise and set today in Oslo* (in readable, UTC time)?");
               City oslo = new City("oslo");
               Root weatherOslo = Weather1.Request(oslo);
               Console.WriteLine(weatherOslo);
               
               
               // Q3
               Api Weather3 = new Api();
               Console.WriteLine("What’s the temperature in Jakarta* (in Celsius)?");
               City jakarta = new City("jakarta");
               Root weatherJakarta = Weather1.Request(jakarta);
               Console.WriteLine(weatherJakarta);
               
               
               
               // Q4
               Api Weather4 = new Api();
               Console.WriteLine("Where is it more windy, New-York*, Tokyo* or Paris*?");

               
               

               // Q5
               Api Weather5 = new Api();
               Console.WriteLine("What is the humidity and pressure like in Kiev*, Moscow* and Berlin*?");
  
           } 
    }
}    