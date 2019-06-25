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
    public partial class FrmCompanyAdd : Form
    {
        private readonly ICompanyService companyService;
        public FrmCompanies MasterForm { get; set; }
        public FrmCompanyAdd(ICompanyService companyService)
        {
            this.companyService = companyService;
            InitializeComponent();
        }

        public void ClearForm()
        {
            txtCompanyName.Clear();
            txtCity.Clear();
            txtPhone.Clear();
            txtRegion.Clear();
        }

        private void BtnCompanyAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCompanyName.Text=="")
                {
                    MessageBox.Show("- Lütfen Şirket Adını Giriniz -");
                    return;
                }
                else if (txtPhone.Text=="")
                {
                    MessageBox.Show("- Lütfen Telefon Giriniz -");
                    return;
                }
                else if (txtCity.Text=="")
                {
                    MessageBox.Show("- Lütfen Şehir Giriniz -");
                    return;
                }
                else if (txtRegion.Text=="")
                {
                    MessageBox.Show("- Lütfen Bölge Giriniz -");
                    return;
                }
                Company newCompany = new Company();
                newCompany.Name = txtCompanyName.Text;
                newCompany.Phone = txtPhone.Text;
                newCompany.City = txtCity.Text;
                newCompany.Region = txtRegion.Text;
                companyService.Insert(newCompany);
                MasterForm.LoadCompanies();
                MessageBox.Show("- Şirket Başarıyla Eklendi -");
              
                
                    this.Hide();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("- Bir Sorun Oluştu -"+ex.Message);
            }
             

        }

        private void FrmCompanyAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
