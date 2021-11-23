using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.DAO
{
    internal class CurrentMemberCard
    {
        private static CurrentMemberCard instance;
        string username;
        public static CurrentMemberCard Instance
        {
            get
            {
                if (instance == null)
                    instance = new CurrentMemberCard();
                return CurrentMemberCard.instance;
            }
            set
            {
                CurrentMemberCard.Instance = value;
            }
        }
        public CurrentMemberCard()
        {
            this.username = "";
        }
        public void SetMemberCard(string user)
        {
            this.username = user;
        }
        public string GetMemberCard()
        {
            return this.username;
        }
    }
}
