namespace Mvc_train.Data
{
    public interface IEmailSender
    {
        public interface IEmpRepo : IDataRepository<Employee>
        {
            void setPayRoll(Employee employee);

            decimal getSalary(Employee employee);
        }
    }
}
