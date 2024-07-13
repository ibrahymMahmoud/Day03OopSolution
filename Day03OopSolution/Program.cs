using Day03OopSolution.Interface;
using Day03OopSolution.Interface_Example_02;

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

        }
    }
}
