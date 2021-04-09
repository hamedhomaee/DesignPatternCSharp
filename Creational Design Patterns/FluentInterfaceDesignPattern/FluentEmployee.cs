namespace FluentInterfaceDesignPattern
{
    public class FluentEmployee
    {
        Employee _Employee = new Employee(); 
        public FluentEmployee setId(int id) 
        {
            this._Employee.Id = id; 
            return this;
        } 

        public FluentEmployee setName(string name)
        {
            this._Employee.Name = name;
            return this;
        }

        public FluentEmployee setRole(string role)
        {
            this._Employee.Role = role;
            return this;
        }
        public Employee build() {
            return this._Employee;
        }
    }
}