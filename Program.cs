using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> Weight = Enumerable.Range(0, 10).Select(w => 1.0).ToList();
            int i = 0;
            foreach(var item in Weight)
            Console.WriteLine(i++ + " - " + item);
        }
    }
}
