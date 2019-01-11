using System;

namespace play_with_ref_return
{
    class Program
    {
        public static int[] Numbers={1,2,3,4};
        public static ref int SomeThing()
        {
            return ref Numbers[0];
        }
        public static void P(dynamic message) => Console.WriteLine(message);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ref var x=ref SomeThing(); // ref keyword so return by reference
            P("     **********      ");
            P("     Before      ");
            foreach (var item in Numbers)
            {
                P(item);
            }
            x=999;
            P("     **********      ");
            P("     After      "); 
            foreach (var item in Numbers)
            {
                P(item);
            }

            // Output

            // $ dotnet run
            // Hello World!
            //     **********
            //     Before
            // 1
            // 2
            // 3
            // 4
            //     **********
            //     After
            // 999
            // 2
            // 3
            // 4


        }
    }
}
