using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library.Repositories
{
    class MembersRepository
    {
        Members members;
        Context context;
        public MembersRepository()
        {
            members = new Members();
            context = new Context();
        }
        public List<Members> GetAllMembers()
        {
            return context.members();
        }
        public bool CheckIfNationalityIsCorrect(string code)
        {
            bool Checked;
            string pt = @"^\d{10}";
            if (Regex.Match(code,pt).Success)
            {
                Checked = true;
            }
            else
            {
                Checked = false;
            }
            return Checked;
        }
        public bool CheckIfMemberExists(string nationalCode)
        {
            var data = GetAllMembers();
            bool checkIfMemberExists;
            try
            {
                checkIfMemberExists = data.Exists(a => a.NationalCode == nationalCode);
            }
            catch (Exception)
            {
                checkIfMemberExists = false;
            }
           
            return checkIfMemberExists;
        }
        public bool CheckIfEmailIsCorrect(string email)
        {
            bool Checked;
            string ptEmail = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            if (Regex.Match(email,ptEmail).Success)
            {
                Checked = true;
            }
            else
            {
                Checked = false;
            }
            return Checked;
        }
        public bool CheckIfEmailExists(string email)
        {
            bool Checked = GetAllMembers().Exists(a => a.Email == email);
            return true;
        }
        public bool CheckIfUserNameExists(string username)
        {
            try
            {
                bool Checked = GetAllMembers().Exists(a => a.UserName == username);
                return Checked;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void AddMember(Members member)
        {
            var data = context.members();
            if (data==null)
            {
                data = new List<Members>();
            }
            data.Add(member);
            context.SaveChangesForMembers(data);
        }
        public bool CheckUserLogin(string username,string password)
        {
            try
            {
                var User = GetAllMembers().Single(a => a.UserName == username);
                if (User.Password==password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Members FindUserByNationalCode(string code)
        {
            try
            {
                return GetAllMembers().Single(a => a.NationalCode == code);
            }
            catch (Exception)
            {
                return null;
            }
           
        }
        public Members FindUserByUserName(string user)
        {
            return GetAllMembers().Single(a => a.UserName == user);
        }
        public Members FindUserByMemberId(Guid memberId)
        {
            try
            {
                return GetAllMembers().Single(a => a.MemberId == memberId);
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
