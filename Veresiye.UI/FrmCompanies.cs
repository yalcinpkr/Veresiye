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
    public partial class FrmCompanies : Form
    {
        public int selectedId;
        private readonly ICompanyService companyService;
        private readonly FrmCompanyAdd frmCompanyAdd;
        private readonly FrmCompanyEdit frmCompanyEdit;
        public FrmCompanies(ICompanyService companyService,FrmCompanyAdd frmCompanyAdd,FrmCompanyEdit frmCompanyEdit)
        {
            this.companyService = companyService;
            this.frmCompanyAdd = frmCompanyAdd;
            this.frmCompanyEdit = frmCompanyEdit;
            
            InitializeComponent();
            this.frmCompanyAdd.MdiParent = this.MdiParent;
            this.frmCompanyAdd.MasterForm = this;

            this.frmCompanyEdit.MdiParent = this.MdiParent;
            this.frmCompanyEdit.MasterForm = this;
        }

        private void FrmCompanies_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        public void LoadCompanies()
        {
            this.dgwCompanies.AutoGenerateColumns = false;
            this.dgwCompanies.DataSource = companyService.GetAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            this.frmCompanyAdd.Show();
            this.frmCompanyAdd.ClearForm();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgwCompanies.SelectedRows.Count>0)
            {
                this.frmCompanyEdit.Show();
                this.frmCompanyEdit.LoadForm(selectedId);
            }
            else
            {
                MessageBox.Show("- Lütfen Düzenlemek İstediğiniz Kaydı Seçiniz -");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgwCompanies.SelectedRows.Count>0)
            {
                var ask = new DialogResult();
                ask = MessageBox.Show("Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (ask == DialogResult.Yes)
                {
                    companyService.Delete(selectedId);
                    LoadCompanies();
                    MessageBox.Show("Silindi", "Atta Gitti");
                }
            }
            else
            {
                MessageBox.Show("- Lütfen Silmek İstediğiniz Kaydı Seçiniz -");
            }
            
        }

        private void DgwCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          selectedId=(int)dgwCompanies.SelectedRows[0].Cells[0].Value;
        }
    }
}
