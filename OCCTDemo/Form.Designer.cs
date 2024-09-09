namespace OCCTDemo {
	partial class Form {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.NewView = new System.Windows.Forms.ToolStripMenuItem();
			this.ImportFile = new System.Windows.Forms.ToolStripMenuItem();
			this.ImportStep = new System.Windows.Forms.ToolStripMenuItem();
			this.FileClose = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// FileMenu
			// 
			this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewView,
            this.ImportFile,
            this.FileClose});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(38, 20);
			this.FileMenu.Text = "File";
			// 
			// NewView
			// 
			this.NewView.Name = "NewView";
			this.NewView.Size = new System.Drawing.Size(180, 22);
			this.NewView.Text = "New";
			this.NewView.Click += new System.EventHandler(this.NewView_Click);
			// 
			// ImportFile
			// 
			this.ImportFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportStep});
			this.ImportFile.Enabled = false;
			this.ImportFile.Name = "ImportFile";
			this.ImportFile.Size = new System.Drawing.Size(180, 22);
			this.ImportFile.Text = "Import";
			// 
			// ImportStep
			// 
			this.ImportStep.Name = "ImportStep";
			this.ImportStep.Size = new System.Drawing.Size(180, 22);
			this.ImportStep.Text = "Step";
			this.ImportStep.Click += new System.EventHandler(this.ImportStep_Click);
			// 
			// FileClose
			// 
			this.FileClose.Enabled = false;
			this.FileClose.Name = "FileClose";
			this.FileClose.Size = new System.Drawing.Size(180, 22);
			this.FileClose.Text = "Close";
			this.FileClose.Click += new System.EventHandler(this.FileClose_Click);
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form";
			this.Text = "Demo";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FileMenu;
		private System.Windows.Forms.ToolStripMenuItem ImportFile;
		private System.Windows.Forms.ToolStripMenuItem ImportStep;
		private System.Windows.Forms.ToolStripMenuItem NewView;
		private System.Windows.Forms.ToolStripMenuItem FileClose;
	}
}

