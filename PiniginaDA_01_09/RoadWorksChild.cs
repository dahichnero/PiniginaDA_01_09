using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiniginaDA_01_09
{
    public class RoadWorksChild : RoadWorks
    {
        public int Coefficient { get; set; }// поле коэффициент прочности
        public RoadWorksChild(double widthRoad, double lenghtRoad, double weightRoad, int coefficient) : base(widthRoad, lenghtRoad, weightRoad)//конструктор класса (наследованного)
        {
            Coefficient = coefficient;
        }
        public new double QualityRoad() //метод для перекрытия метода из базового класса
        {
            if (Coefficient>=5 && Coefficient <= 8)//если коэффициент находится в диапозоне 5...8
            {
                return Math.Round((WidthRoad * LenghtRoad * WeightRoad / 1000)*1.1,2);
            }
            if (Coefficient==3 || Coefficient==4 || Coefficient==9 || Coefficient == 10)//если коэффициент равен 3,4,9 или 10
            {
                return Math.Round((WidthRoad * LenghtRoad * WeightRoad / 1000) * 1.6,2);
            }
            return Math.Round((WidthRoad * LenghtRoad * WeightRoad / 1000) * 1.9,2);//в других случаях
        }
        public new void PrintAboutQuality()
        {
            Console.WriteLine($"Качество объекта: {QualityRoad()}");
        }
    }
}
