﻿   Circle.PrintCircleArea(100);
   class Circle
   {
       static double PI = 3.14159;
       public static void PrintCircleArea(double radius)
       {
           PI = 3.14159265359; // change PI to more precision number.
           Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
       }
   }