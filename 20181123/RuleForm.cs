﻿using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20181123
{
    public partial class RuleForm : Form
    {
        private MSsql db;

        public RuleForm(Object oDB)
        {
            InitializeComponent();
            this.db = (MSsql)oDB;
            Load += RuleForm_Load;
        }

        private void RuleForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}