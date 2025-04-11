using MovieLibraryCommon;
using System;

namespace MovieLibraryData
{
    public class AccountHandle
    {
        public static List<Account> accounts = new List<Account>();

        public AccountHandle()
        {
            CreateAccount();
        }

        private static void CreateAccount()
        {
            Account account1 = new Account();
            account1.Username = "macfroze";
            account1.Password = "macfrozen";
            accounts.Add(account1);

            Account account2 = new Account();
            account2.Username = "brodtire";
            account2.Password = "brodtires";
            accounts.Add(account2);
        }

        public bool ValidateAccount(string userName, string password)
        {
            foreach (var account in accounts)
            {
                if (account.Username == userName && account.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
