using System;
using System.Windows.Forms;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.Common
{
    /// <summary>
    /// Base class for every prototype form. Applies the shared theme
    /// centrally instead of per-screen: one AutoScaleMode, one default font,
    /// one background, one StartPosition/MinimumSize convention. Resolves
    /// the Font/Dpi/None AutoScaleMode mix and FixedToolWindow/Sizable mix
    /// documented in DVLD_UI_Inventory_Report.md.
    /// </summary>
    public class BaseForm : Form
    {
        public BaseForm()
        {
            // AutoScaleMode.None: these Designer.cs files are hand-authored
            // (not round-tripped through the VS designer at a specific
            // system font/DPI), so Font/Dpi auto-scaling has no correct
            // baseline to scale from and mis-positions docked controls.
            // None keeps every screen's hand-tuned pixel layout predictable
            // — resolves the Font/Dpi/None mix documented in the report.
            AutoScaleMode = AutoScaleMode.None;
            Font = AppTheme.FontBody;
            BackColor = AppTheme.Surface;
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new System.Drawing.Size(360, 240);

            try { Icon = System.Drawing.SystemIcons.Application; }
            catch { /* no-op: icon is cosmetic only */ }
        }

        /// <summary>Applies the one fixed, non-resizable dialog convention.</summary>
        protected void UseDialogSizing()
        {
            FormBorderStyle = AppTheme.DialogBorderStyle;
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
