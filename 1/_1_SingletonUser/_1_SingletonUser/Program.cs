using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SingletonUser
{
    class Program
    {
        class User
        {
            public string Name { get; set; }

            private static User instance;

            private User(string Name)
            {
                this.Name = Name;
            }

            public static User getInstance(string Name) 
            { 
                if ( instance == null)
                {
                    instance = new User(Name);
                }
                return instance;
            }
        }


        class OS
        {
            public string Name { get; set; }

            public List<User> Users { get; set; }

            public OS(string Name)
            {
                this.Name = Name;
                this.Users = new List<User>();
            }
        }


        static void Main(string[] args)
        {
            OS os = new OS ( "Linux");
            os.Users.Add(User.getInstance("Pupkin"));
            os.Users.Add(User.getInstance("Pupkinson"));
            os.Users.Add(User.getInstance("Pupkinyavichus"));

            foreach(var user in os.Users)
            {
                Console.WriteLine(string.Format("OS - {0}, User - {1}", os.Name, user.Name));
            }

            Console.ReadKey();
        }
    }
}
