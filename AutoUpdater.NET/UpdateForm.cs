using System.Windows.Forms;

namespace AutoUpdater.NET
{
    public partial class UpdateForm : Form
    {
        public UpdateForm(string oldVersion, string newVersion, string changelogText, bool mandatory = false)
        {
            InitializeComponent();

            oldVersionLabel.Text = oldVersion;
            newVersionLabel.Text = newVersion;

            changeLogTextBox.Text = changelogText ?? "No changelog available.";

            ignoreUpdateButton.Visible = !mandatory;
        }

        private void InstallUpdateButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
