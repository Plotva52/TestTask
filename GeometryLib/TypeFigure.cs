using System;

namespace GeometryLib
{
    public static class TypeFigure
    {
        /// <summary>
        /// Выводит тип треугольника
        /// 0 не существует, 1 остроугольный, 2 тупоугольный, 3 прямоугольный
        /// </summary>
        /// <returns>enum typeTriangle</returns>
        public static typeTriangle GetTypeTriangle(double a, double b, double c)
        {

            //Проверка на существование            
            if (a < 0 || b < 0 || c < 0)
            {
                return 0;
            }

            //Найдем наибольшу сторону
            double x;
            if (a > b)
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
            if (c >= a + b)
                return 0;

            if (diff < 0)
            {
                return typeTriangle.acute_angled;//Остроугольный
            }
            else
            {
                if (diff > 0)
                    return typeTriangle.obtuse;//Тупоугольный
                else
                    return typeTriangle.rectangular;//Прямоугольный
            }
        }

        public enum typeTriangle
        {
            acute_angled = 1,
            obtuse = 2,
            rectangular = 3
        }
    }
}
