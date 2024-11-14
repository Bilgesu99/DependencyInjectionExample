using DependencyInjectionExample.Interfaces;

namespace DependencyInjectionExample
{
    public class Teacher : IOgretmen
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"Teacher: {FirstName} {LastName}";
        }
    }
}
