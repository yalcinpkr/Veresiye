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
    public partial class FrmActivityAdd : Form
    {
        private int CompanyId;
        private readonly IActivityService activityService;
        public FrmCompanyEdit MasterForm { get; set; }
        public FrmActivityAdd(IActivityService activityService)
        {
            this.activityService = activityService;
            InitializeComponent();
        }

        private void BtnActivityAdd_Click(object sender, EventArgs e)
        {
            var activity = new Activity();

            activity.ActivityType = ((Activity)cmbActivityType.SelectedItem).ActivityType;
            activity.Name = txtName.Text;
            activity.Amount = Convert.ToDecimal(txtAmount.Text);
            activity.TransactionDate = Convert.ToDateTime(dtpTransactionDate);
            activityService.Insert(activity);
            MessageBox.Show("- İşlem Eklendi -");
            MasterForm.LoadActivities();

        }

        public void ClearActivities(int companyId)
        {
            this.CompanyId = CompanyId;
            this.txtName.Clear();
            this.txtAmount.Clear();
            this.dtpTransactionDate.Value=DateTime.Now;
            this.cmbActivityType.SelectedIndex = -1;
            
        }

        private void FrmActivityAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
