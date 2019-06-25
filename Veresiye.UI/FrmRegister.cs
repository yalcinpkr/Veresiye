using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veresiye.Model;
using Veresiye.Service;

namespace Veresiye.UI
{
    public partial class FrmRegister : Form
    {
        private readonly IUserService userService;

        public FrmRegister(IUserService userService)
        {
            this.userService = userService;
            InitializeComponent();
        }

        private void BtnUserRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text!=txtPasswordValidate.Text)
            {
                MessageBox.Show("- Parola Doğruluğunu Kontrol Edin -");
                return;
            }

            var user = new User();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.CompanyName = txtCompanyName.Text;
            user.City = txtCity.Text;
            user.Phone = txtPhone.Text;
            user.Region = txtRegion.Text;
            var status = userService.Register(user);
            switch (status)
            {
                case RegisterStatus.Success:
                    MessageBox.Show("- Kullanıcı başarıyla kaydedildi -");
                    this.Close();
                    break;
                case RegisterStatus.InvalidFields:
                    MessageBox.Show("- Kullanıcı adı boş olamaz -");
                    break;
                case RegisterStatus.UserAlreayExists:
                    MessageBox.Show("- Bu kullanıcı daha önce kullanılmış -");
                    break;
                default:
                    break;
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
