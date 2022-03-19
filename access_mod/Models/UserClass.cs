using System;
namespace access_mod.Models
{
    class UserClass
    {
        
        public string _Username;
        private int _Age;
        private string _Password;

        public UserClass(string username, string password)
        {
            this._Username = username;
            this._Password = password;
            
        }
        

        
        public string username
        {
            get
            {
                return username;
            }
            set
            {
                //Console.WriteLine("Enter Your username: ");
                //_Username = Console.ReadLine();
                //Console.WriteLine(_Username);
                _Username = value;
                Console.WriteLine(_Username);

            }

        }
        public int age
        {
            get
            {
                return _Age;
            }
            set
            {
                //Console.WriteLine("Please enter your age");
                //int v = int.Parse(Console.ReadLine());
                //_Age = v;
                
                if (value <= 0)
                {
                    Console.WriteLine("age cannot be negative number");
                    return;
                }
                _Age = value;

                Console.WriteLine(_Age);

            }

        }
        public string password
        {
            get
            {
                return _Password;
            }
            set
            {
                string sym = "bukayooooooo";
                for (int i = 0; i < sym.Length; i++)
                {
                    if (sym.Length<8)
                    {
                        Console.WriteLine("Password cannot be less than 8");
                        return;
                    }
                }
                 _Password = value;
                Console.WriteLine(_Password);
            }

        }
        public bool Test(string pas)
        {
            char[] arr = pas.ToCharArray();
            bool result = false;
            bool result1 = false;
            bool result2 = false;

            for (int i = 0; i < arr.Length; i++)
            {


                if (result1 != char.IsUpper(arr[i]))
                {
                    result = true;
                }

                if (result2 != char.IsNumber(arr[i]))
                {
                    result = true;
                }

                if (result1 == true && result2 == true)
                {
                    result = true;
                }
                return result;
            }
            return result;
        }

        public void Info()
        {
            Console.WriteLine("the new user has been created");
        }
        



    }
}
