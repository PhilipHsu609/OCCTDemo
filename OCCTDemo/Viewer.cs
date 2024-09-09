using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OCCTDemo {
	public partial class Viewer: System.Windows.Forms.Form {
		enum Action {
			None,
			Zoom,
			Pan,
			Rotate,
		}
		private OCCTProxy myProxy;
		private Action action = Action.None;
		private Point mouse;
		public Viewer() {
			InitializeComponent();
			myProxy = new OCCTProxy();
		}
		public void InitV3d() {
			if (!myProxy.InitViewer(Handle)) {
				MessageBox.Show("Fatal Error during the graphic initialisation", "Error!",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void InitView() {
			myProxy.InitOCCTProxy();
		}
		public void Form_Resize(object sender, System.EventArgs e) {
			myProxy.UpdateView();
		}
		public void Form_Paint(object sender, PaintEventArgs e) {
			myProxy.RedrawView();
			myProxy.UpdateView();
		}
		public void Form_Closed(object sender, System.EventArgs e) {
			Form parent = (Form)ParentForm;
			parent.OnFileClose();
		}
		public void Form_MouseDown(object sender, MouseEventArgs e) {
			mouse = new Point(e.X, e.Y);
			switch (e.Button) {
				case MouseButtons.Left:
					action = Action.Rotate;
					myProxy.Select();
					myProxy.StartRotation(e.X, e.Y);
					break;
				case MouseButtons.Middle:
					action = Action.Pan;
					break;
				case MouseButtons.Right:
					action = Action.Zoom;
					break;
				default:
					break;
			}
		}
		public void Form_MouseMove(object sender, MouseEventArgs e) {
			switch (action) {
				case Action.Rotate:
					myProxy.Rotation(e.X, e.Y);
					break;
				case Action.Pan:
					myProxy.Pan(e.X - mouse.X, mouse.Y - e.Y);
					mouse = new Point(e.X, e.Y);
					break;
				case Action.Zoom:
					myProxy.Zoom(mouse.X, mouse.Y, e.X, e.Y);
					mouse = new Point(e.X, e.Y);
					break;
				default:
					myProxy.MoveTo(e.X, e.Y);
					break;
			}
		}
		public void Form_MouseUp(object sender, MouseEventArgs e) {
			action = Action.None;
		}
		public void Form_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyCode) {
				case Keys.R:
					myProxy.Reset();
					myProxy.ZoomAllView();
					break;
				case Keys.C:
					ColorDialog dlg = new ColorDialog();
					if (dlg.ShowDialog() == DialogResult.OK) {
						Color color = dlg.Color;
						myProxy.SetColor(color.R, color.G, color.B);
						myProxy.UpdateCurrentViewer();
					}
					break;
				default:
					break;
			}
		}
		public void Form_KeyUp(object sender, KeyEventArgs e) {

		}
		public void ImportStep() {
			string dir = Directory.GetCurrentDirectory();
			dir = Directory.GetParent(dir).Parent.Parent.Parent.FullName;

			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "STEP Files (*.stp *.step)|*.stp; *.step|All files (*.*)|*.*";
			dlg.InitialDirectory = dir + "\\Models";

			if (dlg.ShowDialog() == DialogResult.OK) {
				string fileName = dlg.FileName;
				if (fileName == "") {
					return;
				}
				Cursor = Cursors.WaitCursor;

				// 0 - BRep, 1 - STEP, 2 - IGES
				// true - import, false - export
				if (!myProxy.TranslateModel(fileName, 1, true)) {
					MessageBox.Show("Can't read this file", "Error!",
							MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				Cursor = Cursors.Default;
			}

			// 0 - Wireframe, 1 - Shading
			myProxy.SetDisplayMode(1);
			myProxy.ZoomAllView();
		}
	}
}
