using InstalmentsProject.Operations;

namespace InstalmentsProject.Customers
{
    internal class Users
    {
        public class CustomerList
        {

            public static List<UserModel> GetUsers()
            {

                List<UserModel> Customers = new()
                {
                    new UserModel
                    {
                        FName = "Stephen",
                        LName = "Nnamani",
                        IsEmployed = true,
                        AtmPin = "1234",
                        AccBalance = 100000,
                        salary = UserCheck.salary,
                    },
                    new UserModel
                    {
                        FName = "Caleb",
                        LName = "Okechukwu",
                        IsEmployed = true,
                        AtmPin = "4321",
                        AccBalance = 40000,
                        salary = UserCheck.salary,

                    },
                    new UserModel
                    {
                        FName = "Alex",
                        LName = "Ogubuike",
                        IsEmployed = true,
                        AtmPin = "0803",
                        AccBalance = 80000,
                        salary = UserCheck.salary,

                    }
                };
                return Customers;
            }
        }
    }
}
