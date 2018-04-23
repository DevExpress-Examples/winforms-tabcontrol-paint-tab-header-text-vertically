using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab.Registrator;

namespace WindowsFormsApplication907 {
    public class MySkinViewInfoRegistrator : SkinViewInfoRegistrator {
        public MySkinViewInfoRegistrator() {

        }

        public override string ViewName {
            get {
                return "MyStyle";
            }
        }

        public override BaseTabPainter CreatePainter(IXtraTab tabControl) {
            return new MySkinTabPainter(tabControl);
        }
    }
}
