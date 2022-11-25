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
			this.ProductsData = new System.Windows.Forms.DataGridView();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.TabLevels = new System.Windows.Forms.TabPage();
			this.LevelsData = new System.Windows.Forms.DataGridView();
			this.TabProducts = new System.Windows.Forms.TabPage();
			this.TabDO = new System.Windows.Forms.TabPage();
			this.DOData = new System.Windows.Forms.DataGridView();
			this.TabTree = new System.Windows.Forms.TabPage();
			this.TreesData = new System.Windows.Forms.DataGridView();
			this.TabBuilding = new System.Windows.Forms.TabPage();
			this.BuildingsData = new System.Windows.Forms.DataGridView();
			this.ButtonOpenDb = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ProductsData)).BeginInit();
			this.TabControl.SuspendLayout();
			this.TabLevels.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LevelsData)).BeginInit();
			this.TabProducts.SuspendLayout();
			this.TabDO.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DOData)).BeginInit();
			this.TabTree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TreesData)).BeginInit();
			this.TabBuilding.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BuildingsData)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonNewDb
			// 
			this.ButtonNewDb.Location = new System.Drawing.Point(16, 12);
			this.ButtonNewDb.Name = "ButtonNewDb";
			this.ButtonNewDb.Size = new System.Drawing.Size(144, 33);
			this.ButtonNewDb.TabIndex = 0;
			this.ButtonNewDb.Text = "Создать новую БД";
			this.ButtonNewDb.UseVisualStyleBackColor = true;
			this.ButtonNewDb.Click += new System.EventHandler(this.ButtonNewDb_Click);
			// 
			// ProductsData
			// 
			this.ProductsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProductsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProductsData.Location = new System.Drawing.Point(3, 3);
			this.ProductsData.Name = "ProductsData";
			this.ProductsData.RowHeadersWidth = 51;
			this.ProductsData.RowTemplate.Height = 24;
			this.ProductsData.Size = new System.Drawing.Size(738, 306);
			this.ProductsData.TabIndex = 1;
			// 
			// TabControl
			// 
			this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			                                                                | System.Windows.Forms.AnchorStyles.Left)
			                                                               | System.Windows.Forms.AnchorStyles.Right)));
			this.TabControl.Controls.Add(this.TabLevels);
			this.TabControl.Controls.Add(this.TabProducts);
			this.TabControl.Controls.Add(this.TabDO);
			this.TabControl.Controls.Add(this.TabTree);
			this.TabControl.Controls.Add(this.TabBuilding);
			this.TabControl.Location = new System.Drawing.Point(12, 51);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(752, 341);
			this.TabControl.TabIndex = 2;
			// 
			// TabLevels
			// 
			this.TabLevels.Controls.Add(this.LevelsData);
			this.TabLevels.Location = new System.Drawing.Point(4, 25);
			this.TabLevels.Name = "TabLevels";
			this.TabLevels.Padding = new System.Windows.Forms.Padding(3);
			this.TabLevels.Size = new System.Drawing.Size(744, 312);
			this.TabLevels.TabIndex = 0;
			this.TabLevels.Text = "Уровни";
			this.TabLevels.UseVisualStyleBackColor = true;
			// 
			// LevelsData
			// 
			this.LevelsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.LevelsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LevelsData.Location = new System.Drawing.Point(3, 3);
			this.LevelsData.Name = "LevelsData";
			this.LevelsData.RowHeadersWidth = 51;
			this.LevelsData.RowTemplate.Height = 24;
			this.LevelsData.Size = new System.Drawing.Size(738, 306);
			this.LevelsData.TabIndex = 2;
			// 
			// TabProducts
			// 
			this.TabProducts.Controls.Add(this.ProductsData);
			this.TabProducts.Location = new System.Drawing.Point(4, 25);
			this.TabProducts.Name = "TabProducts";
			this.TabProducts.Padding = new System.Windows.Forms.Padding(3);
			this.TabProducts.Size = new System.Drawing.Size(744, 312);
			this.TabProducts.TabIndex = 1;
			this.TabProducts.Text = "Продукты";
			this.TabProducts.UseVisualStyleBackColor = true;
			// 
			// TabDO
			// 
			this.TabDO.Controls.Add(this.DOData);
			this.TabDO.Location = new System.Drawing.Point(4, 25);
			this.TabDO.Name = "TabDO";
			this.TabDO.Padding = new System.Windows.Forms.Padding(3);
			this.TabDO.Size = new System.Drawing.Size(744, 312);
			this.TabDO.TabIndex = 2;
			this.TabDO.Text = "Объекты Развития";
			this.TabDO.UseVisualStyleBackColor = true;
			// 
			// DOData
			// 
			this.DOData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DOData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DOData.Location = new System.Drawing.Point(3, 3);
			this.DOData.Name = "DOData";
			this.DOData.RowHeadersWidth = 51;
			this.DOData.RowTemplate.Height = 24;
			this.DOData.Size = new System.Drawing.Size(738, 306);
			this.DOData.TabIndex = 2;
			// 
			// TabTree
			// 
			this.TabTree.Controls.Add(this.TreesData);
			this.TabTree.Location = new System.Drawing.Point(4, 25);
			this.TabTree.Name = "TabTree";
			this.TabTree.Padding = new System.Windows.Forms.Padding(3);
			this.TabTree.Size = new System.Drawing.Size(744, 312);
			this.TabTree.TabIndex = 3;
			this.TabTree.Text = "Деревья";
			this.TabTree.UseVisualStyleBackColor = true;
			// 
			// TreesData
			// 
			this.TreesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TreesData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TreesData.Location = new System.Drawing.Point(3, 3);
			this.TreesData.Name = "TreesData";
			this.TreesData.RowHeadersWidth = 51;
			this.TreesData.RowTemplate.Height = 24;
			this.TreesData.Size = new System.Drawing.Size(738, 306);
			this.TreesData.TabIndex = 3;
			// 
			// TabBuilding
			// 
			this.TabBuilding.Controls.Add(this.BuildingsData);
			this.TabBuilding.Location = new System.Drawing.Point(4, 25);
			this.TabBuilding.Name = "TabBuilding";
			this.TabBuilding.Padding = new System.Windows.Forms.Padding(3);
			this.TabBuilding.Size = new System.Drawing.Size(744, 312);
			this.TabBuilding.TabIndex = 4;
			this.TabBuilding.Text = "Здания";
			this.TabBuilding.UseVisualStyleBackColor = true;
			// 
			// BuildingsData
			// 
			this.BuildingsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BuildingsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BuildingsData.Location = new System.Drawing.Point(3, 3);
			this.BuildingsData.Name = "BuildingsData";
			this.BuildingsData.RowHeadersWidth = 51;
			this.BuildingsData.RowTemplate.Height = 24;
			this.BuildingsData.Size = new System.Drawing.Size(738, 306);
			this.BuildingsData.TabIndex = 4;
			// 
			// ButtonOpenDb
			// 
			this.ButtonOpenDb.Location = new System.Drawing.Point(166, 12);
			this.ButtonOpenDb.Name = "ButtonOpenDb";
			this.ButtonOpenDb.Size = new System.Drawing.Size(101, 33);
			this.ButtonOpenDb.TabIndex = 3;
			this.ButtonOpenDb.Text = "Открыть БД";
			this.ButtonOpenDb.UseVisualStyleBackColor = true;
			this.ButtonOpenDb.Click += new System.EventHandler(this.ButtonOpenDb_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 404);
			this.Controls.Add(this.ButtonOpenDb);
			this.Controls.Add(this.TabControl);
			this.Controls.Add(this.ButtonNewDb);
			this.Name = "MainForm";
			this.Text = "Эко-ферма Модуль Управления Данными";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ProductsData)).EndInit();
			this.TabControl.ResumeLayout(false);
			this.TabLevels.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LevelsData)).EndInit();
			this.TabProducts.ResumeLayout(false);
			this.TabDO.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DOData)).EndInit();
			this.TabTree.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TreesData)).EndInit();
			this.TabBuilding.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BuildingsData)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.DataGridView BuildingsData;

		private System.Windows.Forms.TabPage TabBuilding;

		private System.Windows.Forms.DataGridView TreesData;

		private System.Windows.Forms.TabPage TabTree;

		private System.Windows.Forms.DataGridView DOData;

		private System.Windows.Forms.TabPage TabDO;

		private System.Windows.Forms.DataGridView LevelsData;

		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage TabLevels;
		private System.Windows.Forms.TabPage TabProducts;

		private System.Windows.Forms.DataGridView ProductsData;

		private System.Windows.Forms.Button ButtonNewDb;

		#endregion

		private System.Windows.Forms.Button ButtonOpenDb;
	}
}