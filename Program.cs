using System;

namespace workshop2_1 {
    class Program {
        static void Main(string[] args) {
            double height = 10.0;
            double pedestal = 15.0;
            
            double area = 1.0/2.0 * pedestal * height;
            double length = pedestal + pedestal + pedestal;
            Console.WriteLine("Area is : {0}, length is: {1}", area, length);
        }
    }
}