using Library.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Login : Form
    {
        UsersRepository usersRepository;
        MembersRepository membersRepository;
        public Login()
        {
            InitializeComponent();
            usersRepository = new UsersRepository();
            membersRepository = new MembersRepository();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool checkAdmin = usersRepository.AdminEnterance(txtUserName.Text, txtPassword.Text);
            bool checkUser = membersRepository.CheckUserLogin(txtUserName.Text, txtPassword.Text);
            if (checkAdmin)
            {
                this.Hide();
                StorageOfBooks storage = new StorageOfBooks();
                storage.ShowDialog();
            }
            else if (checkUser)
            {
                this.Hide();
                UserPage userPage = new UserPage(txtUserName.Text);
                userPage.ShowDialog();
            }
            else
            {
                MessageBox.Show(".نام کاربری و یا رمز عبور اشتباه میباشد", "Error");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterMember register = new RegisterMember();
            this.Hide();
            register.ShowDialog();
        }
    }
}