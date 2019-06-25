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
    public partial class FrmCompanyEdit : Form
    {
        private int Id ;
        private readonly ICompanyService companyService;
        private readonly IActivityService activityService;
        private readonly FrmActivityAdd frmActivityAdd;
        private readonly FrmActivityEdit frmActivityEdit;
        public FrmCompanies MasterForm { get; set; }
        public FrmCompanyEdit(ICompanyService companyService,IActivityService activityService,FrmActivityAdd frmActivityAdd,FrmActivityEdit frmActivityEdit)
        {
            this.frmActivityAdd = frmActivityAdd;
            this.frmActivityEdit = frmActivityEdit;
            this.activityService = activityService;
            this.companyService = companyService;

            InitializeComponent();
            this.frmActivityAdd.MdiParent = this.MdiParent;
            this.frmActivityAdd.MasterForm = this;
            this.frmActivityEdit.MdiParent = this.MdiParent;
            this.frmActivityEdit.MasterForm = this;
        }

        //-------------------------------Form Load Bölümü-------------------------------------------------------------------------------------------------------
        public void LoadForm(int id)
        {
            var company = companyService.Get(id);
            this.Id = id;
            txtCompanyName.Text=company.Name;
            txtCity.Text=company.City;
            txtPhone.Text=company.Phone;
            txtRegion.Text=company.Region;
        }

        //-------------------------------Activity Bölümü-------------------------------------------------------------------------------------------------------
        public void LoadActivities()
        {
            var activities = activityService.GetAllByCompanyId(Id);
            dgwActivities.AutoGenerateColumns = false;
            dgwActivities.DataSource = activities ;
        }

        private void BtnCompanyEdit_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "")
            {
                MessageBox.Show("- Lütfen Şirket Adını Giriniz -");
                return;
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("- Lütfen Telefon Giriniz -");
                return;
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("- Lütfen Şehir Giriniz -");
                return;
            }
            else if (txtRegion.Text == "")
            {
                MessageBox.Show("- Lütfen Bölge Giriniz -");
                return;
            }
            Company company = companyService.Get(this.Id);
            company.Name = txtCompanyName.Text;
            company.Phone = txtPhone.Text;
            company.City = txtCity.Text;
            company.Region = txtRegion.Text;
            companyService.Update(company);
            MasterForm.LoadCompanies();
            MessageBox.Show("- Şirket Başarıyla Güncellendi -");
            MasterForm.LoadCompanies();
            this.Hide();

        }

        private void FrmCompanyEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        //-------------------------------Activity Bölümü-------------------------------------------------------------------------------------------------------
        private void BtnActivityAdd_Click(object sender, EventArgs e)
        {
            frmActivityAdd.Show();
            frmActivityAdd.ClearActivities(this.Id);
        }

        private void BtnActivityEdit_Click(object sender, EventArgs e)
        {
            if (this.dgwActivities.SelectedRows.Count>0)
            {
                this.frmActivityEdit.Show();
                this.frmActivityEdit.ClearActivities(int.Parse(this.dgwActivities.SelectedRows[0].Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("- Lütfen Düzenlemek İstediğiniz İşlemi Seçiniz -");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgwActivities.SelectedRows.Count>0)
            {
                this.activityService.Delete(int.Parse(this.dgwActivities.SelectedRows[0].Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("- Lütfen Silmek İstediğiniz İşlemi Seçiniz -");
            }
        }

        private void FrmCompanyEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
