using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Prototype.Theme
{
    /// <summary>
    /// Central design-system definition for the prototype: palette, type scale,
    /// spacing and form-sizing conventions. Every screen styles itself through
    /// this class instead of hardcoding colors/fonts, per STYLE_GUIDE.md.
    /// </summary>
    public static class AppTheme
    {
        // ---- Palette --------------------------------------------------------
        // Formalized from the original app's two hardcoded, never-named colors
        // (report: MainForm toolstrip / frmLoginScreen panel RGB(36,37,56), and
        // IndianRed used pervasively for titles/values) plus supporting neutrals.
        public static readonly Color Navy = Color.FromArgb(36, 37, 56);       // primary brand / chrome
        public static readonly Color NavyLight = Color.FromArgb(54, 56, 82);  // hover/active chrome
        public static readonly Color Accent = Color.IndianRed;                 // titles, values, danger
        public static readonly Color AccentDark = Color.FromArgb(176, 66, 66);
        public static readonly Color Success = Color.FromArgb(46, 160, 92);
        public static readonly Color Warning = Color.FromArgb(224, 168, 0);
        public static readonly Color Danger = Color.FromArgb(196, 62, 62);
        public static readonly Color Surface = Color.White;
        public static readonly Color SurfaceAlt = Color.FromArgb(245, 247, 250);
        public static readonly Color Border = Color.FromArgb(224, 226, 232);
        public static readonly Color TextPrimary = Color.FromArgb(36, 37, 56);
        public static readonly Color TextSecondary = Color.FromArgb(110, 113, 128);
        public static readonly Color TextOnNavy = Color.FromArgb(245, 247, 250);

        // ---- Type scale -------------------------------------------------------
        // Resolves the original Segoe UI Semibold + Tahoma mix onto one family.
        private const string FamilyName = "Segoe UI";
        private const string FamilySemibold = "Segoe UI Semibold";

        public static Font FontPageTitle => TryFont(FamilySemibold, 20f, FontStyle.Bold);
        public static Font FontSectionTitle => TryFont(FamilySemibold, 13f, FontStyle.Bold);
        public static Font FontCaption => TryFont(FamilyName, 10.5f, FontStyle.Bold);
        public static Font FontValue => TryFont(FamilySemibold, 10.5f, FontStyle.Bold);
        public static Font FontBody => new Font(FamilyName, 9.5f, FontStyle.Regular);
        public static Font FontSmall => new Font(FamilyName, 8.5f, FontStyle.Regular);
        public static Font FontButton => TryFont(FamilyName, 9.5f, FontStyle.Bold);

        private static Font TryFont(string family, float size, FontStyle style)
        {
            // Segoe UI Semibold is not always installed as a distinct family on
            // every Windows image; fall back cleanly instead of throwing.
            try { return new Font(family, size, style); }
            catch { return new Font(FamilyName, size, style); }
        }

        // ---- Spacing ------------------------------------------------------
        public const int SpaceXS = 4;
        public const int SpaceSM = 8;
        public const int SpaceMD = 16;
        public const int SpaceLG = 24;
        public const int SpaceXL = 32;

        // ---- Form sizing convention ----------------------------------------
        // ONE convention for all detail/dialog screens: fixed, non-resizable,
        // centered on parent/screen. Resolves the FixedToolWindow / Sizable /
        // SizableToolWindow mix documented in the report.
        public const FormBorderStyle DialogBorderStyle = FormBorderStyle.FixedSingle;

        public static void ApplyPageTitle(Label label)
        {
            label.Font = FontPageTitle;
            label.ForeColor = Accent;
            label.BackColor = Color.Transparent;
            label.AutoSize = true;
        }

        public static void ApplySectionTitle(Label label)
        {
            label.Font = FontSectionTitle;
            label.ForeColor = TextPrimary;
            label.BackColor = Color.Transparent;
            label.AutoSize = true;
        }

        public static void ApplyCaption(Label label)
        {
            label.Font = FontCaption;
            label.ForeColor = TextSecondary;
            label.BackColor = Color.Transparent;
            label.AutoSize = true;
        }

        public static void ApplyValue(Label label)
        {
            label.Font = FontValue;
            label.ForeColor = Accent;
            label.BackColor = Color.Transparent;
            label.AutoSize = true;
        }

        public static void ApplyPrimaryButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Navy;
            button.ForeColor = TextOnNavy;
            button.Font = FontButton;
            button.Height = 36;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.MouseOverBackColor = NavyLight;
        }

        public static void ApplySecondaryButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Border;
            button.BackColor = Surface;
            button.ForeColor = TextPrimary;
            button.Font = FontButton;
            button.Height = 36;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.MouseOverBackColor = SurfaceAlt;
        }

        public static void ApplyDangerButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Danger;
            button.ForeColor = Color.White;
            button.Font = FontButton;
            button.Height = 36;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.MouseOverBackColor = AccentDark;
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Navy;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = TextOnNavy;
            grid.ColumnHeadersDefaultCellStyle.Font = FontCaption;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Navy;
            grid.ColumnHeadersHeight = 36;
            grid.RowHeadersVisible = false;
            grid.DefaultCellStyle.Font = FontBody;
            grid.DefaultCellStyle.SelectionBackColor = SurfaceAlt;
            grid.DefaultCellStyle.SelectionForeColor = TextPrimary;
            grid.AlternatingRowsDefaultCellStyle.BackColor = SurfaceAlt;
            grid.GridColor = Border;
            grid.RowTemplate.Height = 30;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
        }
    }
}
