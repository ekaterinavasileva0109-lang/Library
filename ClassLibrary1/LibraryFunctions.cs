using System;
using System.Collections.Generic;

namespace LibraryLib
{
    //класс для работы с функциями Городской библиотеки г. Чита
    public class LibraryFunctions
    {
        //название библиотеки
        private const string LibraryName = "Городская библиотека г. Чита";

        //ФИО главного библиотекаря
        private string _chiefLibrarian = "Иванова Мария Петровна";

        //список сотрудников библиотеки
        private readonly List<string> _staff = new List<string>
        {
            "Петров П.С.",
            "Сидорова А.В.",
            "Козлов И.Д.",
            "Иванова М.П."
        };

        //метод возвращает ФИО главного библиотекаря
        public string GetChiefLibrarian()
        {
            return _chiefLibrarian;
        }

        //метод возвращает название библиотеки
        public string GetLibraryName()
        {
            return LibraryName;
        }

        //метод изменяет ФИО главного библиотекаря, только если он есть в списке сотрудников
        public bool SetChiefLibrarian(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname))
                return false;

            //проверка наличия в списке
            if (!_staff.Contains(fullname))
                return false;

            _chiefLibrarian = fullname;
            return true;
        }

        //метод формирует код книги вида CAT_number
        public string GenerateBookCode(string category, int number)
        {
            if (string.IsNullOrWhiteSpace(category))
                throw new ArgumentException("Категория не может быть пустой", nameof(category));

            return $"{category}_{number}";
        }

        //метод возвращает список сотрудников библиотеки
        public List<string> GetStaff()
        {
            return new List<string>(_staff);
        }

        //метод добавляет нового сотрудника в список
        public void AddStaff(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname))
                throw new ArgumentException("ФИО не может быть пустым", nameof(fullname));

            _staff.Add(fullname);
        }
    }
}