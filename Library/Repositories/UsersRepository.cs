using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library.Repositories
{
    class UsersRepository
    {
        Users users;
        public UsersRepository()
        {
            users = new Users();
        }
        public bool AdminEnterance(string username,string password)
        {
            if (username == "admin" && password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckIfNameIsCorrect(string name)
        {
            bool CheckName;
            string ptName = @"^[\u0600-\u06FF\s]+$";
            if (Regex.Match(name, ptName).Success)
            {
                 CheckName = true;
            }
            else
            {
                CheckName = false;
            }
            return CheckName;
        }
        public bool CheckIfPhoneNumIsCorrect(string phoneNum)
        {
            bool Checked;
            string ptPhoneNum = @"^09+\d{9}$";
            if (Regex.Match(phoneNum,ptPhoneNum).Success)
            {
                Checked = true;
            }
            else
            {
                Checked = false;
            }
            return Checked;
        }
        public bool CheckIfNumberIsCorrect(string number)
        {
            bool Checked;
            string ptNum = @"\d{8,11}$";
            if (Regex.Match(number, ptNum).Success)
            {
                Checked = true;
            }
            else
            {
                Checked = false;
            }
            return Checked;
        }
        public bool CheckPassword(string pass)
        {
            bool Checked;
            string ptPassWord = @"[0-9]+";
            string ptPassWord2 = @"[A-Z]+";
            string ptPassWord3 = @".{8,}";
            if (Regex.Match(pass,ptPassWord).Success && Regex.Match(pass, ptPassWord2).Success && Regex.Match(pass, ptPassWord3).Success)
            {
                Checked = true;
            }
            else
            {
                Checked = false;
            }
            return Checked;
        }
    }
}
