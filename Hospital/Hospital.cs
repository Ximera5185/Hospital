using System;

namespace Hospital
{
    internal class Hospital
    {
        private Database _database = new Database();

        public Hospital() { }

        public void Run()
        {
            const string SortFullNameMenu = "1";
            const string SortAgeMenu = "2";
            const string ShowPatientDiseaseMenu = "3";
            const string ExitProgrammMenu = "4";

            string userInput;

            bool isProgrammWork = true;

            while (isProgrammWork)
            {
                _database.ShowPatients();

                Console.WriteLine($"Сортировка по ФИО {SortFullNameMenu}\n" +
                $"Сортировка по возрасту {SortAgeMenu}\n" +
                $"Вывод заболевания {ShowPatientDiseaseMenu} \n" +
                $"Выход {ExitProgrammMenu}");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case SortFullNameMenu:
                        _database.ShowPotientName();
                        break;
                    case SortAgeMenu:
                        _database.ShowPotientAge();
                        break;
                    case ShowPatientDiseaseMenu:
                        _database.ShowPotientDisease();
                        break;
                    case ExitProgrammMenu:
                        isProgrammWork = false;
                        break;
                }
            }
        }
    }
}