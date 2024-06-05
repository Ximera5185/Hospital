using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _patients.Add(new Patient("Дуров Эдуард Самадович","Ангина",35));
            _patients.Add(new Patient("Гонинов Вячеслав Американович","Ветрянка",35));
            _patients.Add(new Patient("Громов Аркадий Олегович", "Атит", 37));
            _patients.Add(new Patient("Колокольчиков Игорь Аркадьевич", "Орв", 40));
            _patients.Add(new Patient("Клонов Клон Клонович", "Сердечная недостаточность", 41));
            _patients.Add(new Patient("Проныров Андрей Игоревич", "Хитрость", 21));
            _patients.Add(new Patient("Дворников Дворник Степанович", "Старость", 80));
            _patients.Add(new Patient("Прищиков Олег Олегович", "Алергия", 78));
            _patients.Add(new Patient("Зубнов Антон Артемонович", "Стамотит", 51));
            _patients.Add(new Patient("Грунов Юрий Дмитриевич", "Насморк", 19));
        }
    }
}