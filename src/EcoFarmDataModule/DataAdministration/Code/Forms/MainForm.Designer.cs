namespace DataAdministration
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ButtonNewDb = new System.Windows.Forms.Button();
			this.MainDataGridView = new System.Windows.Forms.DataGridView();
			this.CurrentTableComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonNewDb
			// 
			this.ButtonNewDb.Location = new System.Drawing.Point(12, 12);
			this.ButtonNewDb.Name = "ButtonNewDb";
			this.ButtonNewDb.Size = new System.Drawing.Size(144, 33);
			this.ButtonNewDb.TabIndex = 0;
			this.ButtonNewDb.Text = "Создать новую БД";
			this.ButtonNewDb.UseVisualStyleBackColor = true;
			this.ButtonNewDb.Click += new System.EventHandler(this.ButtonNewDb_Click);
			// 
			// MainDataGridView
			// 
			this.MainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
					| System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MainDataGridView.Location = new System.Drawing.Point(12, 51);
			this.MainDataGridView.Name = "MainDataGridView";
			this.MainDataGridView.RowTemplate.Height = 24;
			this.MainDataGridView.Size = new System.Drawing.Size(758, 305);
			this.MainDataGridView.TabIndex = 1;
			// 
			// CurrentTableComboBox
			// 
			this.CurrentTableComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CurrentTableComboBox.FormattingEnabled = true;
			this.CurrentTableComboBox.Location = new System.Drawing.Point(527, 17);
			this.CurrentTableComboBox.Name = "CurrentTableComboBox";
			this.CurrentTableComboBox.Size = new System.Drawing.Size(243, 24);
			this.CurrentTableComboBox.TabIndex = 2;
			this.CurrentTableComboBox.SelectedValueChanged += new System.EventHandler(this.CurrentTableComboBox_SelectedValueChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 368);
			this.Controls.Add(this.CurrentTableComboBox);
			this.Controls.Add(this.MainDataGridView);
			this.Controls.Add(this.ButtonNewDb);
			this.Name = "MainForm";
			this.Text = "Эко-ферма Модуль Управления Данными";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.ComboBox CurrentTableComboBox;

		private System.Windows.Forms.DataGridView MainDataGridView;

		private System.Windows.Forms.Button ButtonNewDb;

#endregion
	}
}