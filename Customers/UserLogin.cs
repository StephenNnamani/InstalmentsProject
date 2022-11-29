using static InstalmentsProject.Customers.Users;

namespace InstalmentsProject.Customers
{
    internal class UserLogin
    {


        public static UserModel UserChecks(string pin)
        {

            CustomerList customerList = new CustomerList();

            var _customers = CustomerList.GetUsers();

            var user = _customers.Where(x => x.AtmPin == pin).FirstOrDefault();

            Console.WriteLine(user.AccBalance);

            return user;

        }
    }
}