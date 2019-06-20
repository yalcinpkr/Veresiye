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
    public partial class FrmCompanies : Form
    {
        private readonly ICompanyService companyService;
        public FrmCompanies(ICompanyService companyService)
        {
            this.companyService = companyService;
            InitializeComponent();
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
    }
}
