using System;

namespace PROPERTIES {
    class Students
    {
        //fields
         private static string Name;
         private static string FName;

        public static string _Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You can not enter Null or empty value in Name");
                }
                else {
                    Name = value;
                }
                
            }
            get
            {
                return Name;
            } 
        }

        public static string _FName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You can not enter Null or empty value in FName");
                }
                else {
                    FName = value; 
                      }
                
            }
            get
            {
                return FName;
            }
        }


    }

    class Program
    {
        //public static int a=7, b=8, c=5, d = 9;
        static void Main(string[] args) {
          Students._Name="Kavita";
           
           // Console.WriteLine("a= {1},b={0},c={2},d={3}", a, b, c, d); ;
          Console.WriteLine("Name of the student is : {0} " , Students._Name);
          Students._FName = "Om prakash";
          Console.WriteLine("Name of the student is : {0} ", Students._FName);

        }
    }
}
