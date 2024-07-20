using Demo_OOP04.IClonable_Interface;
using Demo_OOP04.Interfaces;
using System.Text;


namespace Demo_OOP04
{
    internal class Program
    {

        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();

            }
            else
                Console.WriteLine("its null"); 
        }

        
        static void Main(string[]  args)
        {
            #region Interface
            // IMyType myType = new IMyType(); // invalid
            //IMyType myType; // create ref


            MyType myType1 = new MyType();
            myType1.MyFun(55);
            myType1.Id = 1;
            //myType1.Print(); // invalid


            // ref from interface -> obeject from class implement interface
            IMyType MyType = new MyType();
            MyType.Print();
            MyType.MyFun(554);
            MyType.Id = 2;



            #endregion

            #region Interface Ex 01
            // series by two 
            SeriesByTwo seriesByTwo = new SeriesByTwo();
            Print10NumbersFromSeries(seriesByTwo);
            
            //series by three
            SeriesByThree seriesByThree = new SeriesByThree();
            Print10NumbersFromSeries(seriesByThree);


            #endregion

            #region Interface Ex 02 

            // implicity : 
            Car car = new Car();
            car.Backward();
            car.Forward();

            Airplane airplane = new Airplane();
            //airplane.Backward();    invalid
            //airplane.Forward();     invalid

            // explicity : 
            IMoveable moveable = new Airplane();
            moveable.Backward();
            moveable.Forward();
            IFlyable flyable = new Airplane();
            flyable.Backward();
            flyable.Forward();
            #endregion


            #region Deep Copy Vs Shallow Copy [Array Of Value Type] [int value]

            
            #region Shallow copy [Heap]

            int[] Arr01 = { 1, 2, 3, };
            int[] Arr02 = { 0, 0, 0 };

            // shallow copy 
            Arr02 = Arr01;

            #endregion

            #region Deep Copy [Stack]
            // with clone => deep copy
            // with casting
            Arr02 = (int[]) Arr01.Clone();


            #endregion

            #region Array of string type [immutaple]

            #region shallow copy
            string[] name1 = { "hesham" };
            string[] name2 =new string[1];

            // shallow copy 
            name2 = name1;
            #endregion

            #region Deep copy

            // deep copy
            name2 = (string[]) name1.Clone();


            #endregion


            #endregion

            #region array of string type [mutable]

            #region shallow copy
            StringBuilder[] name11 = new StringBuilder[1];

            name11[0] = new StringBuilder("hesham");

            StringBuilder[] name22 = new StringBuilder[1];


            // shallow copy 
            name22 = name11;
            #endregion

            #region deep copy
            // deep copy

            name22 = (StringBuilder[])name11.Clone();
            #endregion
            #endregion










            #endregion


            #region Built in interfaces



            Employee employee1 = new Employee() { Id = 1, Name = "hesham", Salary = 55450 };
            Employee employee2 = new Employee() { Id = 2, Name = "ahmed", Salary = 12121 };


            #region shallow copy 
            employee2 = employee1;



            #endregion

            #region deep copy 
            employee2 = (Employee)employee1.Clone();

            #endregion
            #endregion




        }
    }
}