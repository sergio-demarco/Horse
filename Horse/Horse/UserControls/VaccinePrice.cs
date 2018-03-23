﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse.UserControls
{
    public partial class VaccinePrice : UserControl
    {
        private static VaccinePrice _instance;

        public static VaccinePrice Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VaccinePrice();
                return _instance;
            }
        }
        public VaccinePrice()
        {
            InitializeComponent();
        }
    }
}
