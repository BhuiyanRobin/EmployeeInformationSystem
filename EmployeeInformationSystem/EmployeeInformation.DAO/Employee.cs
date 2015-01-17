namespace EmployeeInformation.DAO
{
    public class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public Designation EmployeeDesignation { set; get; }

       public Employee()
        {
            EmployeeDesignation=new Designation();
        }
    }
}
