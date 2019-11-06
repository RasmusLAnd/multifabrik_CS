using System;
using static System.Console;
using System.Collections.Generic;

namespace multifabrik_CS
{
    class Car{
        public void New(){

                    

            WriteLine("ny bil....");
            List<Car> cars = new List<Car>();

           NewCars newcar = new NewCars();
           newcar.SetData();
           

        }
    }

    public class NewCars
    {

        string number, color, brand;
       

    

        public string Number => number;
        public string Color => color;
        public string Brand=> brand;


        public void SetData()
        {
                       
            Write("Number plate?                               "); number = ReadLine().ToUpper().Trim();
            Write("Color?                              "); color = ReadLine().ToUpper().Trim(); 
            Write("Brand?                              "); brand = ReadLine().ToUpper().Trim();
        }
    }
}