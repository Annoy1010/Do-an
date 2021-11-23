using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.DAO
{
    class CurrentAccount
    {
        private static CurrentAccount instance;
        string username;
        public static CurrentAccount Instance
        {
            get
            {
                if (instance == null)
                    instance = new CurrentAccount();
                return CurrentAccount.instance;
            }
            set
            {
                CurrentAccount.Instance = value;
            }
        }
        public CurrentAccount()
        {
            this.username = "";
        }
        public void SetAccount(string user)
        {
            this.username = user;
        }
        public string GetAccount()
        {
            return this.username;
        }
    }
}
