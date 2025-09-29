namespace ClientHub.App.Forms
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Sair = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_Cliente = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.pn_Dashboard = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Relatórios";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Relatórios";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Relatório Cliente";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cadastros";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Cliente);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Pessoas";
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Caption = "Clientes";
            this.btn_Cliente.Id = 1;
            this.btn_Cliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cliente.ImageOptions.Image")));
            this.btn_Cliente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Cliente.ImageOptions.LargeImage")));
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Cliente_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_Cliente,
            this.barButtonItem1,
            this.barButtonGroup1,
            this.barSubItem1,
            this.barButtonGroup2,
            this.barButtonItem2,
            this.barSubItem2,
            this.barButtonItem3,
            this.barSubItem3,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.MiniToolbars.Add(this.Sair);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsExpandCollapseMenu.EnableExpandCollapseMenu = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.OptionsExpandCollapseMenu.ShowQuickAccessToolbarItem = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.OptionsExpandCollapseMenu.ShowRibbonGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.OptionsExpandCollapseMenu.ShowRibbonLayoutGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barSubItem2);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 158);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 3;
            this.barButtonGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonGroup1.ImageOptions.Image")));
            this.barButtonGroup1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonGroup1.ImageOptions.LargeImage")));
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 4;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonGroup2.Caption = "barButtonGroup2";
            this.barButtonGroup2.Hint = "teste";
            this.barButtonGroup2.Id = 5;
            this.barButtonGroup2.Name = "barButtonGroup2";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem2.Caption = "barSubItem2";
            this.barSubItem2.Id = 7;
            this.barSubItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.Image")));
            this.barSubItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.LargeImage")));
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sair";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "barSubItem3";
            this.barSubItem3.Id = 9;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 10;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // pn_Dashboard
            // 
            this.pn_Dashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_Dashboard.Location = new System.Drawing.Point(0, 157);
            this.pn_Dashboard.Name = "pn_Dashboard";
            this.pn_Dashboard.Size = new System.Drawing.Size(800, 293);
            this.pn_Dashboard.TabIndex = 1;
            this.pn_Dashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_Dashboard);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Home.IconOptions.LargeImage")));
            this.Name = "Home";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar Sair;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_Cliente;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.FlowLayoutPanel pn_Dashboard;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}