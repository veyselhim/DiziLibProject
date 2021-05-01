using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;

namespace FormUI
{
    public partial class Form1 : Form
    {
        private UserManager userManager = new UserManager(new EfUserDal());
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            userManager.Add(new User{UserName =tbxfirstName.Text,UserSurName = tbxLastName.Text,Adress = tbxAdress.Text,TelephoneNumber = tbxTelephone.Text});
        }

       
    }
}
