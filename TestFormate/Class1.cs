using System;

namespace TestFormate
{
    public class Class1
    {
        public Class1(){
            var i = 1 == 2 ? "A" : "B";
        }

        public void Test()
        {
            var testString = "42";
            if (!int.TryParse(testString, out var zahl))
            {
                zahl = -1;
            }
            Console.WriteLine(zahl);
        }
    }
}
