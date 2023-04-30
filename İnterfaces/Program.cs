using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customManager = new CustomerManager();

            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
        }

        interface IPersonManager
        {
            void Add();
            void Update();
        }

        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Müşteri eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri güncellendi.");
            }
        }

        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Personel eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Personel güncellendi.");
            }
        }

        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajyer eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Stajyer güncellendi.");
            }
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }
        }
    }
}
