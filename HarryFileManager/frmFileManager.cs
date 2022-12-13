using System;
using System.Windows.Forms;

namespace HarryFileManager
{
    public partial class frmFileManager : Form
    {
        public frmFileManager()
        {
            InitializeComponent();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult response = fbd.ShowDialog(this);
                if (response == DialogResult.OK)
                {
                    txtFolderPath.Text = fbd.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SetToolStripStatus("", 0);
                if (CheckData())
                {
                    SetToolStripStatus("Search Done!", 100);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private bool CheckData()
        {
            if (string.IsNullOrEmpty(txtFolderPath.Text))
            {
                if (btnSelectPath.CanFocus) btnSelectPath.Focus();
                MessageBox.Show(this, "Please select path");
                return false;
            }

            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                if (txtFilter.CanFocus) txtFilter.Focus();
                MessageBox.Show(this, "Please enter filter text");
                return false;
            }

            return true;
        }

        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(this, ex.Message);
        }

        private void SetToolStripStatus(string sText, int sValue)
        {
            tsStatus.Text = sText;
            tsProgress.Value = sValue;
        }
    }
}
