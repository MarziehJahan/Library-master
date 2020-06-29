using Library.Models;
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
    public partial class RegisterMember : Form
    {
        Members member;
        MembersRepository membersRepo;
        UsersRepository usersRepo;
        public RegisterMember()
        {
            InitializeComponent();
            membersRepo = new MembersRepository();
            usersRepo = new UsersRepository();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int gender;
            string nationalityCode;
            if (membersRepo.CheckIfNationalityIsCorrect(txtNationalCode.Text))
            {
                nationalityCode = txtNationalCode.Text;
                if (membersRepo.CheckIfMemberExists(nationalityCode))
                {
                    lblNationalCodeValidation.Visible = true;
                }
                else if (!membersRepo.CheckIfMemberExists(nationalityCode))
                {
                    lblNationalCodeValidation.Visible = false;
                }
            }
            else
            {
                lblNationalCodeValidation.Visible = true;
                nationalityCode = "";
            }
            if (!usersRepo.CheckIfNameIsCorrect(txtMemberName.Text))
            {
                lblName.Visible = true;
            }
            else if (usersRepo.CheckIfNameIsCorrect(txtMemberName.Text))
            {
                lblName.Visible = false;
            }
            if (!usersRepo.CheckIfNameIsCorrect(txtMemberFname.Text))
            {
                lblFname.Visible = true;
            }
            else if (usersRepo.CheckIfNameIsCorrect(txtMemberFname.Text))
            {
                lblFname.Visible = false;
            }
            if (!membersRepo.CheckIfEmailIsCorrect(txtEmail.Text))
            {
                lblEmail.Visible = true;
            }
            else if (membersRepo.CheckIfEmailIsCorrect(txtEmail.Text))
            {
                lblEmail.Visible = false;
            }
            if (txtUserName.Text=="")
            {
                lblUsername.Visible = true;
            }
            else if (membersRepo.CheckIfUserNameExists(txtUserName.Text))
            {
                lblPickedUserName.Visible = true;
            }
            else if (txtUserName.Text != "")
            {
                lblUsername.Visible = false;
            }
            else if (!membersRepo.CheckIfUserNameExists(txtUserName.Text))
            {
                lblPickedUserName.Visible = false;
            }
            if (!usersRepo.CheckIfPhoneNumIsCorrect(txtPhoneNumber.Text))
            {
                lblPhoneNumber.Visible = true;
            }
            else if (usersRepo.CheckIfPhoneNumIsCorrect(txtPhoneNumber.Text))
            {
                lblPhoneNumber.Visible = false;
            }
            if (usersRepo.CheckIfNumberIsCorrect(txtNumber.Text))
            {
                lblNumber.Visible = false;
            }
            else if (!usersRepo.CheckIfNumberIsCorrect(txtNumber.Text))
            {
                lblNumber.Visible = true;
            }
            if (cmbGender.SelectedIndex==0)
            {
                gender = 0;
            }
            else if (cmbGender.SelectedIndex==1)
            {
                gender = 1;
            }
            else
            {
                gender = 3;
            }
            if (!usersRepo.CheckPassword(txtPassword.Text))
            {
                lblPass.Visible = true;
            }
            else if (usersRepo.CheckPassword(txtPassword.Text))
            {
                lblPass.Visible = false;
            }
            if (!(txtPassword.Text==txtPassRepeat.Text))
            {
                lblPassRepeat.Visible = true;
            }
            else if ((txtPassword.Text == txtPassRepeat.Text))
            {
                lblPassRepeat.Visible = false;
            }
            if (lblName.Visible==false && lblFname.Visible==false && lblNationalCodeValidation.Visible==false && lblEmail.Visible==false && lblUsername.Visible==false && lblPickedUserName.Visible==false && lblPhoneNumber.Visible==false && lblNumber.Visible==false && lblPass.Visible==false && lblPassRepeat.Visible==false)
            {
                member = new Members()
                {
                    NationalCode = nationalityCode,
                    Name = txtMemberName.Text,
                    Fname = txtMemberFname.Text,
                    Email = txtEmail.Text,
                    UserName = txtUserName.Text,
                    Number = txtNumber.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Gender = gender,
                    Password = txtPassword.Text
                };
                membersRepo.AddMember(member);
                MessageBox.Show("عملیات با موفقیت انجام شد","Success");
            }
        }
        
    }
}
