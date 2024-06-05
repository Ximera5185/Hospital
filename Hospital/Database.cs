using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    internal class Database
    {
        private List<Patient> _patients = new List<Patient>();

        public Database()
        {
            AddPatients();
        }

        private void AddPatients()
        {
            _patients.Add(new Patient("Дуров Эдуард Самадович", "Ангина", 35));
            _patients.Add(new Patient("Гонинов Вячеслав Американович", "Ветрянка", 35));
            _patients.Add(new Patient("Громов Аркадий Олегович", "Атит", 37));
            _patients.Add(new Patient("Колокольчиков Игорь Аркадьевич", "Орв", 40));
            _patients.Add(new Patient("Клонов Клон Клонович", "Сердечная недостаточность", 41));
            _patients.Add(new Patient("Проныров Андрей Игоревич", "Хитрость", 21));
            _patients.Add(new Patient("Дворников Дворник Степанович", "Старость", 80));
            _patients.Add(new Patient("Прищиков Олег Олегович", "Алергия", 78));
            _patients.Add(new Patient("Зубнов Антон Артемонович", "Стамотит", 51));
            _patients.Add(new Patient("Грунов Юрий Дмитриевич", "Насморк", 19));
        }

        public void ShowPatients()
        {
            Console.WriteLine("Исходный список");

            foreach (Patient patient in _patients)
            {
                Console.WriteLine($"{patient.FullName} {patient.Age} {patient.Disease}");
            }

            Console.WriteLine();
        }

        public void ShowPotientName() 
        {
            var sortPatientName = _patients.OrderBy(patient => patient.FullName);

            Console.WriteLine("Сортировка по Имени");

            ShowSortList(sortPatientName);

            Console.ReadKey();
        }

        public void ShowPotientAge() 
        {
            var sortPatientAge = _patients.OrderBy(patient => patient.Age);

            Console.WriteLine("Сортировка по возрасту");

            ShowSortList(sortPatientAge);

            Console.ReadKey();
        }

        public void ShowPotientDisease() 
        {
            string inputUserDisease = "";

            Console.WriteLine("Введите заболевание");

            inputUserDisease = Console.ReadLine().ToUpper();

            var sortPatientDisease = _patients.Where(patient => patient.Disease.ToUpper() == inputUserDisease);

            int countPatients = sortPatientDisease.Count();

            if (countPatients > 0)
            {
                ShowSortList(sortPatientDisease);
            }
            else
            {
                Console.WriteLine("Нет такого диагназа");
            }

            Console.ReadLine();
        }

        private void ShowSortList(IEnumerable<Patient> sortList) 
        {
            foreach (Patient patient in sortList)
            {
                Console.WriteLine($"{patient.FullName} {patient.Age} {patient.Disease}");
            }
        }
    }
}