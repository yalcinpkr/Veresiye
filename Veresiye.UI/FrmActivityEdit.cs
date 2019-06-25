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
    public partial class FrmActivityEdit : Form
    {
        private int activityId;
        private readonly IActivityService activityService;
        public FrmCompanyEdit MasterForm { get; set; }

        public FrmActivityEdit(IActivityService activityService)
        {
            this.activityService = activityService;
            InitializeComponent();
        }

        private void BtnActivityEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="")
            {
                MessageBox.Show("- Açıklama Gereklidir -");
                return;
            }
            else if (txtAmount.Text=="")
            {
                MessageBox.Show("- Miktar Gereklidir -");
                return;
            }
            else if (cmbActivityType.SelectedIndex<0)
            {
                MessageBox.Show("- İşlem Türü Gereklidir -");
                return;
            }

            //BURADA BOL BOL HATA VAR

            var activity = activityService.Get(this.activityId);
            
            activity.Name = txtName.Text;
            activity.Amount = Convert.ToDecimal(txtAmount.Text);
            activity.TransactionDate = dtpTransactionDate.Value;
            activity.ActivityType = (ActivityType)cmbActivityType.SelectedIndex;
            activityService.Update(activity);
            MessageBox.Show("- İşlem Güncellendi -");
            MasterForm.LoadActivities();
            this.Hide();

        }

        public void ClearActivities(int activityId)
        {
            this.activityId = activityId;
            var activity = activityService.Get(activityId);
            if (activity!=null)
            {
                this.txtName.Text=activity.Name;
                this.txtAmount.Text=activity.Amount.ToString();
                this.dtpTransactionDate.Value = activity.TransactionDate;
                this.cmbActivityType.SelectedIndex = ((int)activity.ActivityType)-1;
            }


        }

        private void FrmActivityAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
