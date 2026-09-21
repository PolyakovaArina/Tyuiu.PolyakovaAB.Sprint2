using Tyuiu.PolyakovaAB.Sprint2.Task7.V6.Lib;
namespace Tyuiu.PolyakovaAB.Sprint2.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y;
            Console.Title = "Спринт #2 | Выполнила: Полякова А. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Полякова Арина Вячеславовна | ИИПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные данные и вычисляет,    *");
            Console.WriteLine("* внаходится ли точка с координатами X,Y в заштрихованной области.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Введите x:                                                               *");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*Введите y:                                                               *");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();
        }
    }
}
