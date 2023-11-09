using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Author
    {
        //Attribute
        private string name;
        private string email;
        private char gender;
        //properties

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'm' || value == 'f')
                {
                    gender = value;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Enter 'm' for male or 'f' for female");
                        value = char.Parse(Console.ReadLine());
                    } while (value != 'm' && value != 'f');
                    gender = value;
                }
            }
        }
        //constructor
        public Author() { }
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            Gender = gender;
        }

        //Methods
        public string getName()
        {
            return Name;
        }
        public string getEmail()
        {
            return Email;
        }
        public void setEmail(string email)
        {
            Email = email;
        }

        public char getGender()
        {
            return Gender;
        }
        public string toString()
        {
            return $"Author[name = {Name}, email = {Email}, gender = {Gender} ]";
        }
    }
}
