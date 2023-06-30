using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiniginaDA_01_09
{
    public class RoadWorks
    {
        public double WidthRoad { get; set; }//поле ширины
        public double LenghtRoad { get; set; }//поле длины
        public double WeightRoad { get; set; }//поле массы дрожного покрытия
        public RoadWorks(double widthRoad, double lenghtRoad, double weightRoad)//конструктор класса
        {
            WidthRoad = widthRoad;
            LenghtRoad = lenghtRoad;
            WeightRoad = weightRoad;
        }
        public void PrintAboutRoad()//метод для вывода информации
        {
            Console.WriteLine($"Ширина дороги (м): {WidthRoad}, Длина (м): {LenghtRoad}, Масса дорожного покрытия на 1 кв.м (кг): {WeightRoad}");
        }
        public double QualityRoad()//функция для определения качества
        {
            return Math.Round(WidthRoad * LenghtRoad * WeightRoad / 1000,2);
        }
        public void PrintAboutQuality()
        {
            Console.WriteLine($"Качество объекта: {QualityRoad()}");
        }
    }
}
