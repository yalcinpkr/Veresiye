﻿using System;
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

            var activity = new Activity();

            activity.CompanyId = this.CompanyId;
            activity.ActivityType = (ActivityType)cmbActivityType.SelectedIndex;
            activity.Name = txtName.Text;
            activity.Amount = Convert.ToDecimal(txtAmount.Text);
            activity.TransactionDate = dtpTransactionDate.Value;
            activityService.Insert(activity);
            MessageBox.Show("- İşlem Eklendi -");
            MasterForm.LoadActivities();
            this.Hide();

        }

        public void ClearActivities(int companyId)
        {
            this.CompanyId = companyId;
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
