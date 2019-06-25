using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veresiye.Service;

namespace Veresiye.UI
{
    public partial class FrmLogin : Form
    {
        private readonly IUserService userService;
        public FrmMain MasterForm { get; set;}
        public FrmLogin(IUserService userService,FrmCompanies frmCompanies)
        {
            this.userService = userService;
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var confirm=userService.Login(txtUserName.Text,txtPassword.Text);
            //Validation
            if (txtUserName.Text=="")
            {
                MessageBox.Show("- Lütfen Kullanıcı Adı Giriniz -");
                return;
            }
            else if (txtPassword.Text=="")
            {
                MessageBox.Show("- Lütfen Şifre Giriniz -");
            }

            //Kulanıcı Kontrol
            if (confirm!=null)
            {
                MasterForm.ShowFrmCompanies();
                this.Close();
            }
            else
            {
                MessageBox.Show("- Böyle Bir Kullanıcı Yok -");
            }
        }


    }
}
