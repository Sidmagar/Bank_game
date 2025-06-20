namespace Banks_Models
{
    public enum Designations {STAFF,MANAGER,VICEPRESIDENT }
    public class Employee
    {
        // private memebers of the class
        private string name;
        private int experience;
        private Designations designation;
        private double basicSalary;
        // Getters and settter for memebers of the class
        // getters public 
        
        public string Name { get { return name; } set { name = value; } }
        public int Experience { get { return experience; } set { experience = value; } }
        public Designations Designation {get{return designation;} set {designation = value;}}
        public double BasicSalary {get { return basicSalary; } set { basicSalary = value; } }

         
        
        public Employee() 
        { }
        // overloaded Constructor
        public Employee(string name, int exp, Designations designation, double salary)
        {
            this.name = name;
            this.experience = exp;
            this.designation = designation;
            this.basicSalary = salary;
        }
        // copy constructor
        public Employee(Employee emp)
        {
            this.name = emp.Name;
            this.experience = emp.Experience;
            this.designation = emp.Designation;
            this.basicSalary= emp.BasicSalary;
        }
        //override the ToStringmethod
        public override string ToString()
        {
            string objectValue = $"Nmae: {Name}, Experience :{experience},Designation :{Designation},salary:{basicSalary}";
            return objectValue;
        }
        //  overload constructor without designation
        public Employee(string name,int exp,double salary)
        {
            Designations designation;
            Console.Write("eNTER DESIgnation - staff ,manager,Vice president");



            designation = (Designations)Enum.Parse(typeof(Designations),Console.ReadLine().ToUpper());
            this.name = name;
            this.experience = exp;
            this.basicSalary = salary;
            this.designation = designation;

        }
        // overide the equals method 
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (!(obj is Employee)) {
                return false;
            }
            else
            {
                return true;
            }
            return((this.name == ((Employee)obj).Name )&& ((this.experience)==((Employee)obj).experience) && (this.BasicSalary== ((Employee)obj).BasicSalary) && (this.designation== ((Employee)obj).Designation));
        }
        
    }
}
