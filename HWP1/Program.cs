using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int countId = 0;
            bool check=true;
            Group group;
            using (AddGroup addgroup = new AddGroup())
            {
                while (check)
                {
                    Console.WriteLine("Введите наименование группы");
                    name = Console.ReadLine();
                    countId++;
                    group = new Group
                    {
                        Id = countId,
                        GroupName = name
                    };
                    addgroup.Add(group);
                    Console.WriteLine("Хотите продолжить? y/n");
                    string choice = Console.ReadLine();
                    if (choice == "n")
                    {
                        check = false;
                    }
                }
            }
        }
    }
}
