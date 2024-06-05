﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        break;
                    case SortAgeMenu:
                        break;
                    case ShowPatientDiseaseMenu:
                        break;
                    case ExitProgrammMenu:
                        isProgrammWork = false;
                        break;
                }
            }
        }
    }
}
