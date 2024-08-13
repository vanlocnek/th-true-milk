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
         *  3 = Xác thực thành công nhưng không thể cấp quyền
         */
        private int status;
        private DataTable user = new DataTable();
        private DataTable userPermissions = new DataTable();
        private bool isAdminUser = false;

        private List<int> userPermissionsId = new List<int>();
        public Validation(string username, string password)
        {
            if (username != "" && password != "")
            {
                DBS dbs = new DBS();
                dbs.Connect();
                string sqlgetUser = "SELECT * FROM users WHERE username = '" + username + "' AND password = '" + password + "'";
                if (dbs.Get(sqlgetUser, this.user))
                {
                    if (this.user.Rows[0]["group_type"].ToString().Trim() == "admin")
                    {
                        this.isAdminUser = true;
                        SetStatus(2);
                    }
                    else
                    {
                        string sqlGetPermisson = "SELECT p.id FROM user_permission AS u_p INNER JOIN permission AS p ON u_p.id = p.id WHERE u_p.id_user = " + this.user.Rows[0]["id"].ToString();
                        if (dbs.Get(sqlGetPermisson, this.userPermissions))
                        {
                        
                            foreach (DataRow row in this.userPermissions.Rows)
                            {
                                this.userPermissionsId.Add(Convert.ToInt32(row["id"]));
                            }
                            SetStatus(2);
                        }
                        else
                        {
                            SetStatus(3);
                        }
                    }
                }
                else
                {
                    SetStatus(1);
                }

            }
            else
            {
                SetStatus(0);
            }

        }

        public bool HasAdmin()
        {
            return this.isAdminUser;
        }

        public void SetStatus(int status)
        {
            this.status = status;
        }

        public int GetStatus()
        {
            return this.status;
        }

        public List<int> GetPermissions()
        {
            return this.userPermissionsId;
        }

    }
}
