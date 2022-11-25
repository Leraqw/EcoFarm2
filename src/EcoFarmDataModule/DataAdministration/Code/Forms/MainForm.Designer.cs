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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ButtonNewDb);
			this.Name = "MainForm";
			this.Text = "Эко-ферма Модуль Управления Данными";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button ButtonNewDb;

#endregion
	}
}