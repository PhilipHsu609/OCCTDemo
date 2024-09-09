using System.Windows.Forms;

namespace OCCTDemo {
	public partial class Form: System.Windows.Forms.Form {
		public Form() {
			InitializeComponent();
		}
		public void OnFileClose() {
			if (MdiChildren.Length == 1) {
				FileClose.Enabled = false;
				ImportFile.Enabled = false;
			}
		}
		private void NewViewer() {
			Viewer newView = new Viewer();
			newView.MdiParent = this;
			newView.Show();
			newView.InitView();
			newView.InitV3d();

			Cursor = Cursors.Default;
			FileClose.Enabled = true;
			ImportFile.Enabled = true;
		}
		private void ImportStep_Click(object sender, System.EventArgs e) {
			Viewer currentView = (Viewer)ActiveMdiChild;
			if (currentView == null) {
				return;
			}
			currentView.ImportStep();
		}

		private void NewView_Click(object sender, System.EventArgs e) {
			Cursor = Cursors.WaitCursor;
			NewViewer();
		}

		private void FileClose_Click(object sender, System.EventArgs e) {
			if (MdiChildren.Length > 0) {
				ActiveMdiChild.Close();
			}
		}
	}
}
