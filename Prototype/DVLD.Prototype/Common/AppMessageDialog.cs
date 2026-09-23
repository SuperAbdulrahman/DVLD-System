using System.Windows.Forms;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.Common
{
    /// <summary>
    /// Custom-styled replacement for MessageBox.Show, matching the app's own
    /// de-facto 3-variant contract (see MessageKind) but rendered with
    /// AppTheme instead of default Windows chrome.
    /// </summary>
    public partial class AppMessageDialog : BaseForm
    {
        public AppMessageDialog()
        {
            InitializeComponent();
        }

        private void Configure(MessageKind kind, string title, string message)
        {
            lblTitle.Text = title;
            lblMessage.Text = message;

            switch (kind)
            {
                case MessageKind.Confirm:
                    icon.Icon = IconKind.Warning;
                    icon.Tint = AppTheme.Warning;
                    lblTitle.ForeColor = AppTheme.TextPrimary;
                    btnPrimary.Text = "OK";
                    AppTheme.ApplyPrimaryButton(btnPrimary);
                    btnSecondary.Visible = true;
                    AcceptButton = btnPrimary;
                    CancelButton = btnSecondary;
                    DialogResult = DialogResult.None;
                    break;
                case MessageKind.Success:
                    icon.Icon = IconKind.Check;
                    icon.Tint = AppTheme.Success;
                    lblTitle.ForeColor = AppTheme.Success;
                    btnPrimary.Text = "OK";
                    AppTheme.ApplyPrimaryButton(btnPrimary);
                    btnSecondary.Visible = false;
                    AcceptButton = btnPrimary;
                    CancelButton = btnPrimary;
                    break;
                case MessageKind.Failure:
                    icon.Icon = IconKind.Error;
                    icon.Tint = AppTheme.Danger;
                    lblTitle.ForeColor = AppTheme.Danger;
                    btnPrimary.Text = "OK";
                    AppTheme.ApplyDangerButton(btnPrimary);
                    btnSecondary.Visible = false;
                    AcceptButton = btnPrimary;
                    CancelButton = btnPrimary;
                    break;
            }
        }

        private void btnPrimary_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSecondary_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>Confirm/Caution — OK/Cancel. Returns true if confirmed.</summary>
        public static bool Confirm(IWin32Window owner, string message, string title = "Confirm changes")
        {
            using (var dlg = new AppMessageDialog())
            {
                dlg.Configure(MessageKind.Confirm, title, message);
                return dlg.ShowDialog(owner) == DialogResult.OK;
            }
        }

        public static void Success(IWin32Window owner, string message, string title = "Success")
        {
            using (var dlg = new AppMessageDialog())
            {
                dlg.Configure(MessageKind.Success, title, message);
                dlg.ShowDialog(owner);
            }
        }

        public static void Failure(IWin32Window owner, string message, string title = "Failure")
        {
            using (var dlg = new AppMessageDialog())
            {
                dlg.Configure(MessageKind.Failure, title, message);
                dlg.ShowDialog(owner);
            }
        }
    }
}
