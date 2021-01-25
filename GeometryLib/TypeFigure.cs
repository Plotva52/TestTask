using System;

namespace GeometryLib
{
    public static class TypeFigure
    {
        /// <summary>
        /// Выводит тип треугольника
        /// 0 не существует, 1 остроугольный, 2 тупоугольный, 3 прямоугольный
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int TypeTriangle(double a, double b, double c)
        {

            //Проверка на существование            
            if (a < 0 || b < 0 || c < 0)
            {
                return 0;
            }

            //Найдем наибольшу сторону
            double x;
            if (a>b)
            {
                if (a > c)
                {
                    x = c;
                    c = a;
                    a = x;
                }
            }
            else
            {
                if (b > c)
                {
                    x = c;
                    c = b;
                    b = x;
                }
            }


            double diff = c * c - (a * a + b * b);
            if ((c >= a + b) || (c <= a - b))
                return 0;

            if (diff < 0)
            {
                return 1;//остроугольный
            }
            else
            {
                if (diff > 0)
                    return 2;//Тупоугольный
                else
                    return 3;//Прямоугольный
            }       
        }           
    }
}
