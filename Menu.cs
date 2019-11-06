using System;
using static System.Console;

namespace multifabrik_CS
{
    class Menu
    {
        public void Welcome()
        {
            int valg;

            do 
            {

             WriteLine("\n\t  Welcome to The MultiFabrik  ");

                    WriteLine("\tNew Car         -           enter 1 ");
                    WriteLine("\tNew Candy       -           enter 2 ");
                    WriteLine("\tNew Pipe        -           enter 3 ");    
                    WriteLine("\tNew Oatmilk     -           enter 4 ");
                    WriteLine("\tSee all items   -          enter 5 ");
                    WriteLine("\tEnd program     -          enter 9 ");
                    Write("\tIndtast dit valg        -           ");
                    //int.TryParse(ReadLine(), out valg);
                    valg = Convert.ToInt32(ReadLine());

                    
                    switch (valg)
                        {
                            case 1:
                            WriteLine("Creating a new car");
                               Car automobile= new Car();
                               automobile.New();
                            break;

                            case 2:
                            WriteLine("Creating new candy"); 
                               Candy sweet= new Candy();
                               sweet.New();                           
                            break;

                            case 3:
                            WriteLine("Creating a new pipe");  
                                Pipe pipe = new Pipe();
                                pipe.New();                            
                            break;

                            case 4:
                            WriteLine("Creating new oatmilk");      
                                Oatmilk milk = new Oatmilk();
                                milk.New();                       
                            break;

                            case 5:
                            WriteLine("See all created items");                            
                            break;

                            case 9:
                            WriteLine("Exiting Program");                            
                            break;

                        }                        
            }while (valg != 9);
        }

    }
}