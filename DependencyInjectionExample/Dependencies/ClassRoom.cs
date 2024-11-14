using DependencyInjectionExample.Interfaces;

namespace DependencyInjectionExample
{
    public class ClassRoom
    {
        private readonly IOgretmen _teacher;

        // Constructor Injection
        public ClassRoom(IOgretmen teacher)
        {
            _teacher = teacher;
        }

        public void GetTeacherInfo()
        {
            Console.WriteLine(_teacher.GetInfo());
        }
    }
}
