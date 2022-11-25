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
			this.Tabs = new System.Windows.Forms.TabControl();
			this.TabLevels = new System.Windows.Forms.TabPage();
			this.LevelsData = new System.Windows.Forms.DataGridView();
			this.TabProducts = new System.Windows.Forms.TabPage();
			this.TabDO = new System.Windows.Forms.TabPage();
			this.DOData = new System.Windows.Forms.DataGridView();
			this.TabTree = new System.Windows.Forms.TabPage();
			this.TreesData = new System.Windows.Forms.DataGridView();
			this.TabBuilding = new System.Windows.Forms.TabPage();
			this.BuildingsData = new System.Windows.Forms.DataGridView();
			this.TabFactories = new System.Windows.Forms.TabPage();
			this.FactoriesData = new System.Windows.Forms.DataGridView();
			this.TabGenerators = new System.Windows.Forms.TabPage();
			this.GeneratorsData = new System.Windows.Forms.DataGridView();
			this.TabResources = new System.Windows.Forms.TabPage();
			this.ResourcesData = new System.Windows.Forms.DataGridView();
			this.TabGoal = new System.Windows.Forms.TabPage();
			this.GoalsData = new System.Windows.Forms.DataGridView();
			this.TabDOonStart = new System.Windows.Forms.TabPage();
			this.DOonLevelsData = new System.Windows.Forms.DataGridView();
			this.TabInputProduct = new System.Windows.Forms.TabPage();
			this.InputProductsData = new System.Windows.Forms.DataGridView();
			this.TabOutputProducts = new System.Windows.Forms.TabPage();
			this.OutputProductsData = new System.Windows.Forms.DataGridView();
			this.TabResourcesFoFractory = new System.Windows.Forms.TabPage();
			this.ResourcesForFactoryData = new System.Windows.Forms.DataGridView();
			this.TabGoalByDO = new System.Windows.Forms.TabPage();
			this.GoalByDOData = new System.Windows.Forms.DataGridView();
			this.ButtonOpenDb = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ProductsData)).BeginInit();
			this.Tabs.SuspendLayout();
			this.TabLevels.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LevelsData)).BeginInit();
			this.TabProducts.SuspendLayout();
			this.TabDO.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DOData)).BeginInit();
			this.TabTree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TreesData)).BeginInit();
			this.TabBuilding.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BuildingsData)).BeginInit();
			this.TabFactories.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FactoriesData)).BeginInit();
			this.TabGenerators.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GeneratorsData)).BeginInit();
			this.TabResources.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ResourcesData)).BeginInit();
			this.TabGoal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GoalsData)).BeginInit();
			this.TabDOonStart.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DOonLevelsData)).BeginInit();
			this.TabInputProduct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InputProductsData)).BeginInit();
			this.TabOutputProducts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.OutputProductsData)).BeginInit();
			this.TabResourcesFoFractory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ResourcesForFactoryData)).BeginInit();
			this.TabGoalByDO.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GoalByDOData)).BeginInit();
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
			// Tabs
			// 
			this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			                                                          | System.Windows.Forms.AnchorStyles.Left)
			                                                         | System.Windows.Forms.AnchorStyles.Right)));
			this.Tabs.Controls.Add(this.TabLevels);
			this.Tabs.Controls.Add(this.TabProducts);
			this.Tabs.Controls.Add(this.TabDO);
			this.Tabs.Controls.Add(this.TabTree);
			this.Tabs.Controls.Add(this.TabBuilding);
			this.Tabs.Controls.Add(this.TabFactories);
			this.Tabs.Controls.Add(this.TabGenerators);
			this.Tabs.Controls.Add(this.TabResources);
			this.Tabs.Controls.Add(this.TabGoal);
			this.Tabs.Controls.Add(this.TabDOonStart);
			this.Tabs.Controls.Add(this.TabInputProduct);
			this.Tabs.Controls.Add(this.TabOutputProducts);
			this.Tabs.Controls.Add(this.TabResourcesFoFractory);
			this.Tabs.Controls.Add(this.TabGoalByDO);
			this.Tabs.Location = new System.Drawing.Point(12, 51);
			this.Tabs.Name = "Tabs";
			this.Tabs.SelectedIndex = 0;
			this.Tabs.Size = new System.Drawing.Size(752, 341);
			this.Tabs.TabIndex = 2;
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
			// TabFactories
			// 
			this.TabFactories.Controls.Add(this.FactoriesData);
			this.TabFactories.Location = new System.Drawing.Point(4, 25);
			this.TabFactories.Name = "TabFactories";
			this.TabFactories.Padding = new System.Windows.Forms.Padding(3);
			this.TabFactories.Size = new System.Drawing.Size(744, 312);
			this.TabFactories.TabIndex = 5;
			this.TabFactories.Text = "Заводы";
			this.TabFactories.UseVisualStyleBackColor = true;
			// 
			// FactoriesData
			// 
			this.FactoriesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FactoriesData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FactoriesData.Location = new System.Drawing.Point(3, 3);
			this.FactoriesData.Name = "FactoriesData";
			this.FactoriesData.RowHeadersWidth = 51;
			this.FactoriesData.RowTemplate.Height = 24;
			this.FactoriesData.Size = new System.Drawing.Size(738, 306);
			this.FactoriesData.TabIndex = 5;
			// 
			// TabGenerators
			// 
			this.TabGenerators.Controls.Add(this.GeneratorsData);
			this.TabGenerators.Location = new System.Drawing.Point(4, 25);
			this.TabGenerators.Name = "TabGenerators";
			this.TabGenerators.Padding = new System.Windows.Forms.Padding(3);
			this.TabGenerators.Size = new System.Drawing.Size(744, 312);
			this.TabGenerators.TabIndex = 6;
			this.TabGenerators.Text = "Генераторы";
			this.TabGenerators.UseVisualStyleBackColor = true;
			// 
			// GeneratorsData
			// 
			this.GeneratorsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GeneratorsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GeneratorsData.Location = new System.Drawing.Point(3, 3);
			this.GeneratorsData.Name = "GeneratorsData";
			this.GeneratorsData.RowHeadersWidth = 51;
			this.GeneratorsData.RowTemplate.Height = 24;
			this.GeneratorsData.Size = new System.Drawing.Size(738, 306);
			this.GeneratorsData.TabIndex = 6;
			// 
			// TabResources
			// 
			this.TabResources.Controls.Add(this.ResourcesData);
			this.TabResources.Location = new System.Drawing.Point(4, 25);
			this.TabResources.Name = "TabResources";
			this.TabResources.Padding = new System.Windows.Forms.Padding(3);
			this.TabResources.Size = new System.Drawing.Size(744, 312);
			this.TabResources.TabIndex = 7;
			this.TabResources.Text = "Ресурсы";
			this.TabResources.UseVisualStyleBackColor = true;
			// 
			// ResourcesData
			// 
			this.ResourcesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ResourcesData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ResourcesData.Location = new System.Drawing.Point(3, 3);
			this.ResourcesData.Name = "ResourcesData";
			this.ResourcesData.RowHeadersWidth = 51;
			this.ResourcesData.RowTemplate.Height = 24;
			this.ResourcesData.Size = new System.Drawing.Size(738, 306);
			this.ResourcesData.TabIndex = 6;
			// 
			// TabGoal
			// 
			this.TabGoal.Controls.Add(this.GoalsData);
			this.TabGoal.Location = new System.Drawing.Point(4, 25);
			this.TabGoal.Name = "TabGoal";
			this.TabGoal.Padding = new System.Windows.Forms.Padding(3);
			this.TabGoal.Size = new System.Drawing.Size(744, 312);
			this.TabGoal.TabIndex = 8;
			this.TabGoal.Text = "Цели";
			this.TabGoal.UseVisualStyleBackColor = true;
			// 
			// GoalsData
			// 
			this.GoalsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GoalsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GoalsData.Location = new System.Drawing.Point(3, 3);
			this.GoalsData.Name = "GoalsData";
			this.GoalsData.RowHeadersWidth = 51;
			this.GoalsData.RowTemplate.Height = 24;
			this.GoalsData.Size = new System.Drawing.Size(738, 306);
			this.GoalsData.TabIndex = 6;
			// 
			// TabDOonStart
			// 
			this.TabDOonStart.Controls.Add(this.DOonLevelsData);
			this.TabDOonStart.Location = new System.Drawing.Point(4, 25);
			this.TabDOonStart.Name = "TabDOonStart";
			this.TabDOonStart.Padding = new System.Windows.Forms.Padding(3);
			this.TabDOonStart.Size = new System.Drawing.Size(744, 312);
			this.TabDOonStart.TabIndex = 10;
			this.TabDOonStart.Text = "ОР на уровне";
			this.TabDOonStart.UseVisualStyleBackColor = true;
			// 
			// DOonLevelsData
			// 
			this.DOonLevelsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DOonLevelsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DOonLevelsData.Location = new System.Drawing.Point(3, 3);
			this.DOonLevelsData.Name = "DOonLevelsData";
			this.DOonLevelsData.RowHeadersWidth = 51;
			this.DOonLevelsData.RowTemplate.Height = 24;
			this.DOonLevelsData.Size = new System.Drawing.Size(738, 306);
			this.DOonLevelsData.TabIndex = 6;
			// 
			// TabInputProduct
			// 
			this.TabInputProduct.Controls.Add(this.InputProductsData);
			this.TabInputProduct.Location = new System.Drawing.Point(4, 25);
			this.TabInputProduct.Name = "TabInputProduct";
			this.TabInputProduct.Padding = new System.Windows.Forms.Padding(3);
			this.TabInputProduct.Size = new System.Drawing.Size(744, 312);
			this.TabInputProduct.TabIndex = 11;
			this.TabInputProduct.Text = "Продукты на вход";
			this.TabInputProduct.UseVisualStyleBackColor = true;
			// 
			// InputProductsData
			// 
			this.InputProductsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InputProductsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InputProductsData.Location = new System.Drawing.Point(3, 3);
			this.InputProductsData.Name = "InputProductsData";
			this.InputProductsData.RowHeadersWidth = 51;
			this.InputProductsData.RowTemplate.Height = 24;
			this.InputProductsData.Size = new System.Drawing.Size(738, 306);
			this.InputProductsData.TabIndex = 6;
			// 
			// TabOutputProducts
			// 
			this.TabOutputProducts.Controls.Add(this.OutputProductsData);
			this.TabOutputProducts.Location = new System.Drawing.Point(4, 25);
			this.TabOutputProducts.Name = "TabOutputProducts";
			this.TabOutputProducts.Padding = new System.Windows.Forms.Padding(3);
			this.TabOutputProducts.Size = new System.Drawing.Size(744, 312);
			this.TabOutputProducts.TabIndex = 12;
			this.TabOutputProducts.Text = "Продукты на выход";
			this.TabOutputProducts.UseVisualStyleBackColor = true;
			// 
			// OutputProductsData
			// 
			this.OutputProductsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OutputProductsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OutputProductsData.Location = new System.Drawing.Point(3, 3);
			this.OutputProductsData.Name = "OutputProductsData";
			this.OutputProductsData.RowHeadersWidth = 51;
			this.OutputProductsData.RowTemplate.Height = 24;
			this.OutputProductsData.Size = new System.Drawing.Size(738, 306);
			this.OutputProductsData.TabIndex = 6;
			// 
			// TabResourcesFoFractory
			// 
			this.TabResourcesFoFractory.Controls.Add(this.ResourcesForFactoryData);
			this.TabResourcesFoFractory.Location = new System.Drawing.Point(4, 25);
			this.TabResourcesFoFractory.Name = "TabResourcesFoFractory";
			this.TabResourcesFoFractory.Padding = new System.Windows.Forms.Padding(3);
			this.TabResourcesFoFractory.Size = new System.Drawing.Size(744, 312);
			this.TabResourcesFoFractory.TabIndex = 13;
			this.TabResourcesFoFractory.Text = "Ресурсы завода";
			this.TabResourcesFoFractory.UseVisualStyleBackColor = true;
			// 
			// ResourcesForFactoryData
			// 
			this.ResourcesForFactoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ResourcesForFactoryData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ResourcesForFactoryData.Location = new System.Drawing.Point(3, 3);
			this.ResourcesForFactoryData.Name = "ResourcesForFactoryData";
			this.ResourcesForFactoryData.RowHeadersWidth = 51;
			this.ResourcesForFactoryData.RowTemplate.Height = 24;
			this.ResourcesForFactoryData.Size = new System.Drawing.Size(738, 306);
			this.ResourcesForFactoryData.TabIndex = 6;
			// 
			// TabGoalByDO
			// 
			this.TabGoalByDO.Controls.Add(this.GoalByDOData);
			this.TabGoalByDO.Location = new System.Drawing.Point(4, 25);
			this.TabGoalByDO.Name = "TabGoalByDO";
			this.TabGoalByDO.Padding = new System.Windows.Forms.Padding(3);
			this.TabGoalByDO.Size = new System.Drawing.Size(744, 312);
			this.TabGoalByDO.TabIndex = 14;
			this.TabGoalByDO.Text = "Цель по ОР";
			this.TabGoalByDO.UseVisualStyleBackColor = true;
			// 
			// GoalByDOData
			// 
			this.GoalByDOData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GoalByDOData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GoalByDOData.Location = new System.Drawing.Point(3, 3);
			this.GoalByDOData.Name = "GoalByDOData";
			this.GoalByDOData.RowHeadersWidth = 51;
			this.GoalByDOData.RowTemplate.Height = 24;
			this.GoalByDOData.Size = new System.Drawing.Size(738, 306);
			this.GoalByDOData.TabIndex = 6;
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
			this.Controls.Add(this.Tabs);
			this.Controls.Add(this.ButtonNewDb);
			this.Name = "MainForm";
			this.Text = "Эко-ферма Модуль Управления Данными";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ProductsData)).EndInit();
			this.Tabs.ResumeLayout(false);
			this.TabLevels.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LevelsData)).EndInit();
			this.TabProducts.ResumeLayout(false);
			this.TabDO.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DOData)).EndInit();
			this.TabTree.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TreesData)).EndInit();
			this.TabBuilding.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BuildingsData)).EndInit();
			this.TabFactories.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FactoriesData)).EndInit();
			this.TabGenerators.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GeneratorsData)).EndInit();
			this.TabResources.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ResourcesData)).EndInit();
			this.TabGoal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GoalsData)).EndInit();
			this.TabDOonStart.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DOonLevelsData)).EndInit();
			this.TabInputProduct.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.InputProductsData)).EndInit();
			this.TabOutputProducts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.OutputProductsData)).EndInit();
			this.TabResourcesFoFractory.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ResourcesForFactoryData)).EndInit();
			this.TabGoalByDO.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GoalByDOData)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.TabControl Tabs;

		private System.Windows.Forms.DataGridView GeneratorsData;
		private System.Windows.Forms.DataGridView ResourcesData;
		private System.Windows.Forms.DataGridView GoalsData;
		private System.Windows.Forms.DataGridView DOonLevelsData;
		private System.Windows.Forms.DataGridView InputProductsData;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView ResourcesForFactoryData;
		private System.Windows.Forms.DataGridView GoalByDOData;

		private System.Windows.Forms.TabPage tabPage1;

		private System.Windows.Forms.TabPage TabGoalByDO;

		private System.Windows.Forms.TabPage TabResourcesFoFractory;

		private System.Windows.Forms.TabPage TabOutputProducts;

		private System.Windows.Forms.TabPage TabInputProduct;

		private System.Windows.Forms.TabPage TabDOonStart;

		private System.Windows.Forms.TabPage TabGoal;

		private System.Windows.Forms.TabPage TabResources;

		private System.Windows.Forms.TabPage TabGenerators;

		private System.Windows.Forms.TabPage TabFactories;
		private System.Windows.Forms.DataGridView FactoriesData;

		private System.Windows.Forms.DataGridView BuildingsData;

		private System.Windows.Forms.TabPage TabBuilding;

		private System.Windows.Forms.DataGridView TreesData;

		private System.Windows.Forms.TabPage TabTree;

		private System.Windows.Forms.DataGridView DOData;

		private System.Windows.Forms.TabPage TabDO;

		private System.Windows.Forms.DataGridView LevelsData;

		private System.Windows.Forms.DataGridView OutputProductsData;
		private System.Windows.Forms.TabPage TabLevels;
		private System.Windows.Forms.TabPage TabProducts;

		private System.Windows.Forms.DataGridView ProductsData;

		private System.Windows.Forms.Button ButtonNewDb;

		#endregion

		private System.Windows.Forms.Button ButtonOpenDb;
	}
}