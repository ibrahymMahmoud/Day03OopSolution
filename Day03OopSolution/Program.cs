﻿using Day03OopSolution.Interface;
using Day03OopSolution.Interface_Example_02;
using Day03OopSolution.Interface_Example_03;

namespace Day03OopSolution
{
    internal class Program
    {

        public static void PrintFirst10NumbersOfSeries( ISeries series )
        {
            if (series == null)
            {
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current}\t");
                series.GetNext();
            }

            series.Reset();

        }


        static void Main(string[] args)
        {

            #region P1 interface

            ///  IMyType imyType;
            ///  // can declare of referance of type (IMyType)
            ///  // this referance can refer to class or struct that implments this interface
            ///  // CLR create 4 bytes in stack for this referance
            ///  
            /// /// myType = new IMyType();
            /// /// //can't create object of interface
            /// /// 
            ///
            ///  imyType = new MyType();



            #endregion

            #region Interface - Example 02

            /// SeriesBy2 series = new SeriesBy2();
            /// SeriesBy3 seriesBy3 = new SeriesBy3(); 
            /// SeriesBy4 seriesBy4 = new SeriesBy4();
            /// Console.WriteLine("series by 2\n");
            /// PrintFirst10NumbersOfSeries (series);
            /// Console.WriteLine("\nseries by 3\n");
            /// PrintFirst10NumbersOfSeries(seriesBy3);
            /// Console.WriteLine("\nseries by 4\n");
            /// PrintFirst10NumbersOfSeries(seriesBy4);


            #endregion

            #region Interface - Example 03

            /// Aireplane aireplane = new Aireplane();  
            /// Car car = new Car();
            ///
            /// IFlyable fly = new Aireplane();
            /// fly.Forward();
            /// aireplane.Backward();

            #endregion

            #region Deep Copy Vs Shallow Copy

         ///   int[] Arr01 = { 1, 2, 3 };
         ///   int[] Arr02 = { 4 , 5, 6 };
         ///   Console.WriteLine($"Hashcode of Array01 {Arr01.GetHashCode()}");
         ///   Console.WriteLine($"Hashcode of Array02 {Arr02.GetHashCode()}");
         ///   Arr01 = Arr02;
         ///   //This Object {1 ,2 ,3} Has 2 References [Arr01 , Arr02](اسمين دلع)
         ///   //This Object {4 ,5 ,6} Became UnReachable Object
         ///   //Shall Copy
         ///   Console.WriteLine("After Shallow Copy -->  Arr01 = Arr02; ");
         ///   Console.WriteLine($"Hashcode of Array01 {Arr01.GetHashCode()}");
         ///   Console.WriteLine($"Hashcode of Array02 {Arr02.GetHashCode()}");
         ///   Arr01[1] = 500;
         ///   Console.WriteLine(Arr02[1]);
         ///   Arr01 = (int[])Arr01.Clone();
         ///   //Clone Method :will generate new object with new and different indentity
         ///   //              this object will have the same object the same object state [data] of caller object 'Arr01'
         ///   //Deep Copy
         ///   Console.WriteLine("After deep copy --> Arr01 = (int[])Arr01.Clone(); ");
         ///   Console.WriteLine($"Hashcode of Array01 {Arr01.GetHashCode()}");
         ///   Console.WriteLine($"Hashcode of Array02 {Arr02.GetHashCode()}");
         ///   Arr01[1] = 200;
         ///   Console.WriteLine(Arr02[1]);
            #endregion



        }
    }
}
