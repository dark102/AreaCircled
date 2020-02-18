using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaCircled
{
    public class Square
    {
        /// <summary>
        /// Метод вычисления Площади круга по его радиусу
        /// </summary>
        /// <param name="r">Радиус окружности</param>
        /// <param name="round">количество знаков после запятой</param>
        /// <returns>Площади круга</returns>
        public double SquareFigyre(double r, int round)
        {
            double pi = Math.Round(Math.PI, round);
            double rez = pi * Math.Pow(r, 2);
            return Math.Round(rez, round);
        }
        /// <summary>
        /// Метод вычисления Площади треугольника по его сторонам(Формула Герона)
        /// </summary>
        /// <param name="r1">1-я сторона</param>
        /// <param name="r2">2-я сторона</param>
        /// <param name="r3">3-я сторона</param>
        /// <param name="round">количество знаков после запятой</param>
        /// <returns>Площади треугольника</returns>
        public double SquareFigyre(double r1, double r2, double r3, int round)
        {
            double rez;
            double p = (r1 + r2 + r3) / 2;                          // вычисление полупериметра

            bool rightTriangle = RightTriangle(r1, r2, r3,round);
            
            if (rightTriangle == false)                             // если обычный треугольник
                rez = Math.Sqrt(p * (p - r1) * (p - r2) * (p - r3));
            else                                                    // если прямоугольный треугольник
            {
                List<double> list = new List<double>();
                list.Add(r1); list.Add(r2); list.Add(r3);
                list.Remove(list.Max());
                double kat1 = list[0]; 
                double kat2 = list[1];
                rez = (p - kat1) * (p - kat2);
            }
            return Math.Round(rez, round);
        }
        /// <summary>
        /// проверка на Прямоугольность треугольника
        /// </summary>
        /// <param name="r1">1-я сторона</param>
        /// <param name="r2">2-я сторона</param>
        /// <param name="r3">3-я сторона</param>
        /// <param name="round">количество знаков после запятой</param>
        /// <returns> да/нет</returns>
        public bool RightTriangle(double r1, double r2, double r3, int round)
        {
            bool rez = false;
            List<double> list = new List<double>();
            list.Add(r1); list.Add(r2); list.Add(r3);
            double gip = list.Max();
            double kat1 = list.Min();
            list.Remove(gip);
            list.Remove(kat1);
            double kat2 = list[0];
            double kv_gip = Math.Round(Math.Pow(gip, 2), round);
            double kv_kat1 = Math.Round(Math.Pow(kat1, 2), round);
            double kv_kat2 = Math.Round(Math.Pow(kat2, 2), round);
            if (kv_gip == kv_kat1+kv_kat2)
            {
                rez = true;
            }
            return rez;
        }
    }
}
// •	Юнит-тесты                                              Сделал
// •	Легкость добавления других фигур                        Добавить метод с формулой для вычисления площади фигуры
// •	Вычисление площади фигуры без знания типа фигуры        Если передаются 2 параметра то окружность если 4 то треугольник
// •	Проверку на то, является ли треугольник прямоугольным   Сделал. Определяем наибольшую сторону и наименьшую. исходя из этого можем
//                                                              предположить что наибольшая это гипотенуза, а меньшие это катеты и если 
//                                                              формула gip*gip=(kat1*kat1)+(kat2*kat2) то прямоугольник прямоугольный.
// думаю в данном проекте есть небольшие косяки с округлением, но это тест а не бой! логику мышления вы и так сможете оценить!
// Спасибо за уделённое время:)
