using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Classes
{
    class Validation
    {
        /**
         *  STATUS
         *  0 = Thiếu thông tin
         *  1 = Đủ thông tin nhưng không tìm thấy user
         *  2 = Xác thực thành công
         */
        private int status;
        private DataTable user = new DataTable();
        public Validation(string username, string password)
        {
            if (username != "" && password != "")
            {
                DBS dbs = new DBS();
                dbs.Connect();
                string sqlgetUser = "SELECT * FROM users WHERE username = '" + username + "' AND password = '" + password + "'";
                if (dbs.Get(sqlgetUser, this.user))
                {
                    setStatus(2);
                }
                else
                {
                    setStatus(1);
                }

            }
            else
            {
                setStatus(0);
            }

        }

        public void setStatus(int status)
        {
            this.status = status;
        }

        public int getStatus()
        {
            return this.status;
        }
    }
}
