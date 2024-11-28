using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;

namespace ConsoleApp6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FunctionInsp inspector = new FunctionInsp();

            // Получение имени главного инспектора
            Console.WriteLine($"Главный инспектор: {inspector.GetInspector()}");

            // Получение названия ГИБДД
            Console.WriteLine($"Название ГИБДД: {inspector.GetCarInspection()}");

            // Изменение имени главного инспектора (проверка на успех)
            bool success = inspector.SetInspector("Иванов И.И.");
            Console.WriteLine($"Изменение главного инспектора на Иванов И.И.: {success}");
            Console.WriteLine($"Главный инспектор после изменения: {inspector.GetInspector()}");


            // Генерация номера
            string generatedNumber = inspector.GenerateNumber(123, 'A', 75);
            Console.WriteLine($"Сгенерированный номер: {generatedNumber}");

            // Получение списка сотрудников
            List<string> employees = inspector.GetWorker();
            Console.WriteLine("\nСписок сотрудников:");
            foreach (string employee in employees)
            {
                Console.WriteLine($"- {employee}");
            }

            // Добавление нового сотрудника (проверка на успех)
            success = inspector.AddWorker("Петров П.П.");
            Console.WriteLine($"\nДобавление сотрудника Петров П.П.: {success}");

            // Получение обновленного списка сотрудников
            employees = inspector.GetWorker();
            Console.WriteLine("\nОбновленный список сотрудников:");
            foreach (string employee in employees)
            {
                Console.WriteLine($"- {employee}");
            }

            Console.ReadKey();
        }
    }
}
