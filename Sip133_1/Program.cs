using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sip133_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления индекса массы тела");
            Console.WriteLine("Введите свой вес");
            double ves = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой рост");
            double rost = double.Parse(Console.ReadLine());
            double I = ves / Math.Pow(rost/100,2);
            if (I < 18)
            {
                Console.WriteLine("Физическое состояние:\nНедостаток веса второй степени");
                Console.WriteLine("Риск и патология:\nХроническая усталость, апатия, нехватка витаминов, истощение");
            }
            else if (I > 18 && I < 20)
            {
                Console.WriteLine("Физическое состояние:\nНедостаток веса первой степени");
                Console.WriteLine("Риск и патология:\nПроблемы пищеварения, истощение, стресс, хроническая усталость, низкий иммунитет, депрессия, гормональные нарушения и т.д");
            }
            else if (I > 20 && I < 25)
            {
                Console.WriteLine("Физическое состояние:\nНедостаток веса первой степени");
                Console.WriteLine("Риск и патология:\nВысокий уровень энергии, хорошая физическая форма, жизнерадостность, психоэмоциональное равновесие и т.д.");
            }
            else if (I > 25 && I < 27)
            {
                Console.WriteLine("Физическое состояние:\nЛишний вес");
                Console.WriteLine("Риск и патология:\nХроническая усталость, проблемы пищеварения, сердечно - сосудистой систәмы, варикоз и т.д.");
            }
            else if (I > 27 && I < 30)
            {
                Console.WriteLine("Физическое состояние:\nОжирение первой степени");
                Console.WriteLine("Риск и патология:\nРиск диабета, высокое давление, проблемы кровообращения, нарушение психики, проблемы суставов и т.д.");
            }
            else if (I > 30 && I < 35)
            {
                Console.WriteLine("Физическое состояние:\nОжирение второй степени");
                Console.WriteLine("Риск и патология:\nДиабет не инсулинозависимый, атеросклероз, стенокардия, инфаркт, тромбофлебит и т.д.");
            }
            else 
            {
                Console.WriteLine("Физическое состояние:\nОжирение третей степени");
                Console.WriteLine("Риск и патология:\n Диабет инсулинозависимый, инфаркт, инсульт, рак");
            }
            Console.ReadKey();
            
            
        }
    }
}
