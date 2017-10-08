using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENASD_v2._0
{
    partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            lbVersion.Text = "v. " + Statics.VERSION;
        }

        /*
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        */

        private void Info_Load(object sender, EventArgs e)
        {

        }
    }
}
