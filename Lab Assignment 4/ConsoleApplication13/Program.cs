
namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("When you guys attunding the show (Matinee show or Evening show?) : ");
            string timeAttendingshow = System.Console.ReadLine();
            timeAttendingshow = timeAttendingshow.ToLower();

            if (timeAttendingshow != "matinee Prices")
            {
                if (timeAttendingshow != "evening show")
                {
                    System.Console.WriteLine("You did not enter  (Matinee  or Evening)");
                    System.Console.WriteLine();
                    System.Console.Write("Press any key to exit... ");
                    System.Console.ReadKey();
                    
                }
            }
                System.Console.Write(" How many of Adults attending : "); 
                int numberAdults = int.Parse(System.Console.ReadLine());
                System.Console.Write(" How many of children attending : ");
                int numberChildren = int.Parse(System.Console.ReadLine());
                System.Console.Write(" How many of Seniors attending : ");
                int numberSeniors = int.Parse(System.Console.ReadLine());
                System.Console.Write(" How many order purchess of Hot Dogs? : "); 
                int numberHotDogs = int.Parse(System.Console.ReadLine());
                System.Console.Write(" How many orders purchess of Popcorn? : ");
                int numberPopcorn = int.Parse(System.Console.ReadLine());
                System.Console.Write(" How many orders purchess of candy? : ");
                int numberCandy = int.Parse(System.Console.ReadLine());
                System.Console.Write(" How many orders purchess of smallsodi? : ");
                int numbersmallsodi = int.Parse(System.Console.ReadLine());
                System.Console.Write(" How many orders purchess of large sodas? : "); 
                int numberLargeSodas = int.Parse(System.Console.ReadLine());
                double totalCost = 0;

                
               
                if (timeAttendingshow == "matinee prices")
                {
                    totalCost += 5.99 * numberAdults;
                    totalCost += 3.99 * numberChildren;
                    totalCost += 4.50 * numberSeniors;

                }


                else if (timeAttendingshow == "evning prices")
                {
                    totalCost += 10.99 * numberAdults;
                    totalCost += 6.99 * numberChildren;
                    totalCost += 8.50 * numberSeniors;

                }
                
                    totalCost +=3.99*numberHotDogs;
                    totalCost +=4.50*numberPopcorn;
                    totalCost +=1.99*numberCandy;
                    totalCost += 3.50 * numbersmallsodi;
                    totalCost +=5.99*numberLargeSodas;

                    int NumberTickets = numberChildren + numberAdults + numberSeniors;
                    int NumberOfDiscounts = -(numberPopcorn + numberLargeSodas);
                    int NumberOfActualDiscounts = -(NumberOfDiscounts + NumberTickets);
                
                
              if(NumberOfActualDiscounts > 0)
              {
                  totalCost -= 2 * NumberOfActualDiscounts;
                  System.Console.WriteLine("Because you purchased " + numberPopcorn + " popcorns and " + numberLargeSodas + " large sodas you receive " + NumberOfDiscounts + " x $2.00 discounts"); 


              }
              if (timeAttendingshow == "evening prices") 
             { 
                if (NumberTickets > 2) 
                 { 
                     if (numberPopcorn > 0) 
                     {
                     System.Console.WriteLine("Because you purchased at least 3 evening ticket or more one of your popcorns is free"); 
                         totalCost -= 4.50;   
                    

                      }

                }
                
              }
                    double numberFreeCandies = numberCandy / 3;
                    if (numberFreeCandies > 0) 
                 { 
                 System.Console.WriteLine("You get " + numberFreeCandies + " additional free candies!");            
                 }
                 
                 
                   System.Console.WriteLine("Your Total Cost: $ " + totalCost ); 
                   System.Console.Write("Press any key to exit... "); 
                   System.Console.ReadKey(); 
                   


                }
              
           
           }
 
     }             
               

                 
                  
