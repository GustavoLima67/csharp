namespace entities
{
    class Employee
    {
        private string name {get;set;}
        private double salary {get;set;}

        public Employee() 
        {
        }
        public Employee(string name,double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string toString()
        {
            return "Name: "+name+ ", Salary: "+salary;
        }
    }
}
