﻿using System;


namespace lab2_2
{
    class Program
    {
        static void Main()
        {
            //declare variables
            double y;
            double x;
            double a = -Math.PI;
            double b = Math.PI;
            double dx = Math.PI / 10;

            //print table header
            Console.WriteLine("Calculation results of the function y = 5x * sin(x) on the interval [-PI, PI] with a step of PI/10");

            //use do-while loop to calculate and display values 
            x = a; //initialize x value 
            Console.WriteLine("_________________________________");
            Console.WriteLine("|\t x     \t| y=f(x)  \t|");
            Console.WriteLine("|_______________|_______________|");
            do
            {
                y = 5 * x * Math.Sin(x); //calculate y value 
                Console.WriteLine("| x = {0:F2}\t| y = {1:F2}\t|", x, y); //display x and y values with two decimal places 
                Console.WriteLine("|_______________|_______________|");
                x += dx; //update x value 
            } while (x <= b); //check condition
        }
    }
}