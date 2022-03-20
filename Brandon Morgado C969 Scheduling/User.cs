using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Brandon_Morgado_C969_Scheduling

{
    public class User
    {
        public int UserID;
        public string UserName;
        public string Password;
        public byte Active;
        public DateTime CreateDate;
        public DateTime LastUpdate;
        public string CreatedBy;
        public string LastUpdateBy;

        public User(int userID, string userName, string password, int active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            Active = (byte)active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }


    }
}