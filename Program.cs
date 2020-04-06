using System;

namespace part2
{
     class Employee{
            public string name {get; set;}
            public string surname {get; set;}
            public Employee (string name, string surname){
                this.name = name;
                this.surname = surname;
            }
            public Employee(){

            }
            public int[] postSalary = {1000, 3000, 5000, 7000};
            public string[] post = {"Intern", "Junior", "Middle", "Senior"};
            public int[] service = {200, 400, 600, 800};   
            public int salary(int cP, int cE)
            {
                return postSalary[cP-1] + service[cE-1];
            }
            public double tax(int salary)
            {
                return 0.14*salary;
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Console.Write("Name: ");
            employee1.name = Console.ReadLine();
            Console.Write("Surname: ");
            employee1.surname = Console.ReadLine();
            Console.WriteLine("Which position:");
            Console.WriteLine("1. Intern");
            Console.WriteLine("2. Junior");
            Console.WriteLine("3. Middle");
            Console.WriteLine("4. Senior");

            int ChoicePosition = Convert.ToInt32(Console.ReadLine());
            if((ChoicePosition>=1)&&(ChoicePosition<=4))
            {
                Console.WriteLine("Which experience:");
                Console.WriteLine("1. One year");
                Console.WriteLine("2. Two years");
                Console.WriteLine("3. Tree years");
                Console.WriteLine("4. Four years");
            }
            else
            {
                Console.WriteLine("Wrong turn!");
                
            }
            
            int ChoiceExperience = int.Parse(Console.ReadLine());
            if((ChoiceExperience>=1)&&(ChoiceExperience<=4))
            {
                Console.WriteLine("Info about employee:");
            Console.WriteLine($"Name: {employee1.name}");
            Console.WriteLine($"Surname: {employee1.surname}");
            Console.WriteLine($"Position: {employee1.post[ChoicePosition-1]}");
            Console.WriteLine($"Salary: {employee1.salary(ChoicePosition, ChoiceExperience)}");
            Console.WriteLine($"Tax: {employee1.tax(employee1.salary(ChoicePosition, ChoiceExperience))}");
            }
            else
            {
                Console.WriteLine("Yu ho! You selected incorrect!");
            }
            Console.ReadKey();
        }
    }
}