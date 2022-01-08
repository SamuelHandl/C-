    
namespace Seminární_práce
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            bool work = true;
            do
                Console.WriteLine("");
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    if (a + b + c == 180)
                    {
                        if (a == 90)
                        {
                            Console.WriteLine("Trojúhelník je pravoúhlý");
                            
                            Console.WriteLine("Stiskněte klávesu ENTER");
                            Console.ReadLine();



                        }
                        else
                        {
                            if (b == 90)
                            {
                                Console.WriteLine("Trojúhelník je pravoúhlý");
                                
                                Console.WriteLine("Stiskněte ENTER");
                                Console.ReadLine();
                            }
                            else
                            {
                                if (c == 90)
                                {
                                    Console.WriteLine("Trojúhelník je pravoúhlý");
                                    
                                    Console.WriteLine("Stiskněte ENTER");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Není pravoúhlý");
                                    Console.WriteLine("Stiskněte ENTER");
                                    Console.ReadLine();
                                }

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Trojúhelník není pravoúhlý");
                        Console.WriteLine("Stiskněte ENTER");
                        Console.ReadLine();

                    }
                }
                catch
                {
                    Console.WriteLine("Neplatný Výraz");
                    
                    Console.WriteLine("Stiskněte ENTER");
                    Console.ReadLine();

                }
                

                {
                    Console.WriteLine("Chcete ukončit program? (ano/ne)");
    
                        string odpoved = Console.ReadLine();
                    switch (odpoved)
                    {
                        case "ano":
                            work = false;
                            break;
                        case "ne":
                            break;
                        default:
                            Console.WriteLine("Neplatná Odpověď");
                            break;
                    }
                } 
            } while (work);
        }
    }
}using System;

