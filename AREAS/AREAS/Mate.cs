﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREAS
{
    public static class Mate
    {
        private static double Area;
        public static double Cuadrado(double a)
        {
            Area = Math.Pow(a, 2);
            return Area;
        }
        public static double Triangulo(double a, double b)
        {
            Area = (a * b) / 2;
            return Area;
        }
        public static double Circulo(double a)
        {
            Area = Math.PI * (Math.Pow(a, 2));
            return Area;
        }
        public static double Rectangulo(double a)
        {
            Area = Math.Pow(a, 2);
            return Area;
        }
        public static double Trapecio(double a, double b, double c)
        {
            Area = (a + b) * c / 2;
            return Area;
        }
        public static double Romboide(double a, double b)
        {
            Area = a * b;
            return Area;
        }
        public static double Pentagono(double a, double b)
        {
            Area = (5 * a * b) / 2;
            return Area;
        }
        public static double Hexagono(double a, double b)
        {
            Area = (6 * a * b) / 2;
            return Area;
        }
    }
}
