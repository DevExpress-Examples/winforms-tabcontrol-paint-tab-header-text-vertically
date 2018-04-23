using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab.Registrator;

namespace WindowsFormsApplication907 {
    public partial class Form1 : Form {
        public Form1() {

            InitializeComponent();
            PaintStyleCollection.DefaultPaintStyles.Add(new MySkinViewInfoRegistrator());
            xtraTabControl1.PaintStyleName = "MyStyle";
        }
    }
}
