namespace OCCTDemo {
	partial class Viewer {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.SuspendLayout();
			// 
			// Viewer
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "Viewer";
			this.Text = "Child";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.SizeChanged += new System.EventHandler(this.Form_Resize);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion
	}
}