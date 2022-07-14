using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
//    Создать класс с именем Address.
//В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого
//поля, создать свойство с двумя методами доступа.
//Создать экземпляр класса Address.
//В поля экземпляра записать информацию о почтовом адресе.
//Выведите на экран значения полей, описывающих адрес.
    class Address
    {
        string index, country, city, street, house, apartment;

        public string Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }
        public string Country
            { get { return country; } set { country = value; } }
        public string City
            { get { return city; } set { city = value; } }
        public string Street
            { get { return street; } set { street = value; } }
        public string House
            { get { return house; } set { house = value; } }
        public string Apartment
            { get { return apartment; } set { apartment = value; } }
    }
}