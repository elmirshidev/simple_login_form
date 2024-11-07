using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        public string Password { get { return _password; } }
        public int Id { get { return _id;} }
        public string Name { get { return _name;} }
        public string Email { get { return _email;} }
        public User(int id,string name,string email,string password)
        {
            this._id = id;
            this._name = name;
            this._email = email;
            this._password = password;
        }
    }
}
