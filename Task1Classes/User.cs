using System;

namespace Classes
{
    class User
    {
        string login, name, surname;
        int age;
        readonly DateTime dateTime;

        public User(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public string Login { get { return login; } set { login = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } }

        public void Call()
        {
            Console.WriteLine($"{Login}: {Name}, {Surname}, {Age} y.o., created on {dateTime}");
        }
    }
}