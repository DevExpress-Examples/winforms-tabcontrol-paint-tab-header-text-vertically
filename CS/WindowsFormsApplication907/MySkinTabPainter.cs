using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Drawing;

namespace WindowsFormsApplication907 {
    public class MySkinTabPainter : SkinTabPainter {
        public MySkinTabPainter(IXtraTab tabControl)
            : base(tabControl) {

        }

        protected override void DrawHeaderPageText(TabDrawArgs e, DevExpress.XtraTab.ViewInfo.BaseTabPageViewInfo pInfo) {
            //base.DrawHeaderPageText(e, pInfo);
            //
            int angle = 0;
            if(e.ViewInfo.HeaderInfo.RealPageOrientation == TabOrientation.Vertical) {
                angle = 270;
                if(e.ViewInfo.HeaderInfo.IsLeftLocation || e.ViewInfo.HeaderInfo.IsTopLocation)
                    angle = 270;
            }
            AppearanceObject a = pInfo.PaintAppearance;
            System.Drawing.Text.HotkeyPrefix? hotKeyPrefixOverride = (a.TextOptions.HotkeyPrefix == HKeyPrefix.Default) || pInfo.UseHotkeyPrefixDrawModeOverride ?
                new System.Drawing.Text.HotkeyPrefix?(pInfo.HotkeyPrefixDrawModeOverride) : null;
            //default for Brusher.Green was e.Cache.GetSolidBrush(CheckHeaderPageForeColor(e, pInfo))
            DrawVString(e.Cache, pInfo.Page.Text,
                a.GetFont(),Brushes.Green , 
                a.GetStringFormat(), pInfo.Text, angle, hotKeyPrefixOverride);
        }
        void DrawVString(GraphicsCache cache, string text, Font font, Brush foreBrush, StringFormat format, Rectangle bounds, int angle,
    System.Drawing.Text.HotkeyPrefix? hotkeyDrawModeOverride) {
            using(StringFormat strFormat = format.Clone() as StringFormat) {
                if(hotkeyDrawModeOverride.HasValue)
                    strFormat.HotkeyPrefix = hotkeyDrawModeOverride.Value;
                cache.DrawVString(text, font, foreBrush, bounds, strFormat, angle);
            }
        }
    }
}
