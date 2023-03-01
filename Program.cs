using System;

namespace workshop2_1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter password: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter agency abbreviation: ");
            string agency = Console.ReadLine();
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;

           /* switch (agency){
                case "FBI":
                    Console.WriteLine("pass");
                    break;
                case  "CIA":
                    Console.WriteLine("pass");
                    break;
                case "NSA":
                    Console.WriteLine("pass");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;        
            }
            */
                    if  (number > 99999 && number <= 999999 ) 
                    {
                        num1 = 0;
                        while (number > 99999 && number <= 999999){
                            num1++;
                            number = number - 100000;
                        }
                        
                        num2 = 0;
                        while (number > 9999 && number <= 99999){
                            num2++;
                            number = number - 10000;
                        }
                        
                        num3 = 0;
                        while (number > 999 && number <= 9999){
                            num3++;
                            number = number - 1000;
                        }
                        
                        num4 = 0;
                        while (number > 99 && number <= 999){
                            num4++;
                            number = number - 100;
                        }
                        
                        num5 = 0;
                        while (number > 9 && number <= 99){
                            num5++;
                            number = number - 10;
                        }
                        
                        num6 = 0;
                        while (number > 0 && number <= 9){
                            num6++;
                            number = number - 1;
                        }
                       
                    }
                    else 
                    {
                    Console.WriteLine("false");
                    }
                        switch (agency){
                            case "CIA" :
                                if ((num6 % 3  == 0) && (num5 != 1 ) && (num5 != 3) && (num5 != 5) && (num3 >= 6 && num3 != 8 ))
                                {
                                    Console.WriteLine("true");   
                                }  
                                    else
                                    {
                                        Console.WriteLine("false");
                                    }
                                break;

                            case "FBI" :
                               if ((num1 >= 4 && num1 <= 7) && (num4 % 2 == 0) && (num4 != 6) && (num2 % 2 != 0 ))
                                {
                                    Console.WriteLine("true"); 
                                }
                                    else
                                    {
                                        Console.WriteLine("false");
                                    }
                                break;
                            case "NSA" : 
                                if ((30 % num6 == 0) && (num4 % 3 == 0) && (num4 % 2 != 0) && (num1 ==7 || num2 == 7 || num3 == 7 || num4 == 7 || num5 == 7 || num6 == 7 ))
                                {
                                   Console.WriteLine("true");
                                }
                                    else
                                    {
                                        Console.WriteLine("false");
                                    }
                                break;
                        }
                    
        }
    }            
}