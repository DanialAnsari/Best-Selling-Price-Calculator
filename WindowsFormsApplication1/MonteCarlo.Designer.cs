namespace WindowsFormsApplication1
{
    partial class MonteCarlo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonteCarlo));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CostPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.MaxCustomers = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Stocktf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Change = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Dec = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Weeks = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SellingPricetf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.materialSingleLineTextField11 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bestSell = new MetroFramework.Controls.MetroLabel();
            this.stockLeft = new MetroFramework.Controls.MetroLabel();
            this.customerPerDay = new MetroFramework.Controls.MetroLabel();
            this.profit = new MetroFramework.Controls.MetroLabel();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Cost Price";
            // 
            // CostPrice
            // 
            this.CostPrice.Depth = 0;
            this.CostPrice.Hint = "";
            this.CostPrice.Location = new System.Drawing.Point(145, 115);
            this.CostPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.PasswordChar = '\0';
            this.CostPrice.SelectedText = "";
            this.CostPrice.SelectionLength = 0;
            this.CostPrice.SelectionStart = 0;
            this.CostPrice.Size = new System.Drawing.Size(142, 23);
            this.CostPrice.TabIndex = 1;
            this.CostPrice.UseSystemPasswordChar = false;
            this.CostPrice.Click += new System.EventHandler(this.CostPrice_Click);
            this.CostPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostPrice_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 177);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Max Customers/Day";
            // 
            // MaxCustomers
            // 
            this.MaxCustomers.Depth = 0;
            this.MaxCustomers.Hint = "";
            this.MaxCustomers.Location = new System.Drawing.Point(145, 173);
            this.MaxCustomers.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaxCustomers.Name = "MaxCustomers";
            this.MaxCustomers.PasswordChar = '\0';
            this.MaxCustomers.SelectedText = "";
            this.MaxCustomers.SelectionLength = 0;
            this.MaxCustomers.SelectionStart = 0;
            this.MaxCustomers.Size = new System.Drawing.Size(142, 23);
            this.MaxCustomers.TabIndex = 3;
            this.MaxCustomers.UseSystemPasswordChar = false;
            this.MaxCustomers.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            this.MaxCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxCustomers_KeyPress);
            // 
            // Stocktf
            // 
            this.Stocktf.Depth = 0;
            this.Stocktf.Hint = "";
            this.Stocktf.Location = new System.Drawing.Point(145, 230);
            this.Stocktf.MouseState = MaterialSkin.MouseState.HOVER;
            this.Stocktf.Name = "Stocktf";
            this.Stocktf.PasswordChar = '\0';
            this.Stocktf.SelectedText = "";
            this.Stocktf.SelectionLength = 0;
            this.Stocktf.SelectionStart = 0;
            this.Stocktf.Size = new System.Drawing.Size(142, 23);
            this.Stocktf.TabIndex = 5;
            this.Stocktf.UseSystemPasswordChar = false;
            this.Stocktf.Click += new System.EventHandler(this.Stocktf_Click);
            this.Stocktf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Stocktf_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 234);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Stock/Week";
            // 
            // Change
            // 
            this.Change.Depth = 0;
            this.Change.Hint = "";
            this.Change.Location = new System.Drawing.Point(585, 115);
            this.Change.MouseState = MaterialSkin.MouseState.HOVER;
            this.Change.Name = "Change";
            this.Change.PasswordChar = '\0';
            this.Change.SelectedText = "";
            this.Change.SelectionLength = 0;
            this.Change.SelectionStart = 0;
            this.Change.Size = new System.Drawing.Size(142, 23);
            this.Change.TabIndex = 7;
            this.Change.UseSystemPasswordChar = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            this.Change.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Change_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(314, 119);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(174, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Percentage Increase of Price";
            // 
            // Dec
            // 
            this.Dec.Depth = 0;
            this.Dec.Hint = "";
            this.Dec.Location = new System.Drawing.Point(585, 173);
            this.Dec.MouseState = MaterialSkin.MouseState.HOVER;
            this.Dec.Name = "Dec";
            this.Dec.PasswordChar = '\0';
            this.Dec.SelectedText = "";
            this.Dec.SelectionLength = 0;
            this.Dec.SelectionStart = 0;
            this.Dec.Size = new System.Drawing.Size(142, 23);
            this.Dec.TabIndex = 9;
            this.Dec.UseSystemPasswordChar = false;
            this.Dec.Click += new System.EventHandler(this.Dec_Click);
            this.Dec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dec_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(314, 177);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(265, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Expected Customer Decrease/Price Increase";
            // 
            // Weeks
            // 
            this.Weeks.Depth = 0;
            this.Weeks.Hint = "";
            this.Weeks.Location = new System.Drawing.Point(585, 230);
            this.Weeks.MouseState = MaterialSkin.MouseState.HOVER;
            this.Weeks.Name = "Weeks";
            this.Weeks.PasswordChar = '\0';
            this.Weeks.SelectedText = "";
            this.Weeks.SelectionLength = 0;
            this.Weeks.SelectionStart = 0;
            this.Weeks.Size = new System.Drawing.Size(142, 23);
            this.Weeks.TabIndex = 11;
            this.Weeks.UseSystemPasswordChar = false;
            this.Weeks.Click += new System.EventHandler(this.Weeks_Click);
            this.Weeks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Weeks_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(314, 234);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(238, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Number of Weeks to Run Current Price";
            // 
            // SellingPricetf
            // 
            this.SellingPricetf.Depth = 0;
            this.SellingPricetf.Hint = "";
            this.SellingPricetf.Location = new System.Drawing.Point(145, 291);
            this.SellingPricetf.MouseState = MaterialSkin.MouseState.HOVER;
            this.SellingPricetf.Name = "SellingPricetf";
            this.SellingPricetf.PasswordChar = '\0';
            this.SellingPricetf.SelectedText = "";
            this.SellingPricetf.SelectionLength = 0;
            this.SellingPricetf.SelectionStart = 0;
            this.SellingPricetf.Size = new System.Drawing.Size(142, 23);
            this.SellingPricetf.TabIndex = 13;
            this.SellingPricetf.UseSystemPasswordChar = false;
            this.SellingPricetf.Click += new System.EventHandler(this.SellingPricetf_Click);
            this.SellingPricetf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SellingPricetf_KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(9, 295);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(109, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Max Selling Price";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 346);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(745, 1);
            this.materialDivider1.TabIndex = 15;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(9, 537);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(44, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Profit:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(9, 498);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(174, 19);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "Total Number of Customers:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(9, 460);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(68, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Stock Left:";
            // 
            // materialSingleLineTextField11
            // 
            this.materialSingleLineTextField11.Depth = 0;
            this.materialSingleLineTextField11.Hint = "";
            this.materialSingleLineTextField11.Location = new System.Drawing.Point(565, 357);
            this.materialSingleLineTextField11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField11.Name = "materialSingleLineTextField11";
            this.materialSingleLineTextField11.PasswordChar = '\0';
            this.materialSingleLineTextField11.SelectedText = "";
            this.materialSingleLineTextField11.SelectionLength = 0;
            this.materialSingleLineTextField11.SelectionStart = 0;
            this.materialSingleLineTextField11.Size = new System.Drawing.Size(142, 23);
            this.materialSingleLineTextField11.TabIndex = 17;
            this.materialSingleLineTextField11.UseSystemPasswordChar = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(9, 419);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(172, 19);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Estimated Best Selling Price:";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(91, 582);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(327, 19);
            this.metroProgressBar1.TabIndex = 24;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(0, 357);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(745, 35);
            this.metroTile1.TabIndex = 25;
            this.metroTile1.Text = "Output";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(9, 582);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(63, 19);
            this.metroLabel12.TabIndex = 27;
            this.metroLabel12.Text = "Progress:";
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(0, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(745, 35);
            this.metroTile2.TabIndex = 28;
            this.metroTile2.Text = "Input";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(575, 269);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(143, 36);
            this.materialRaisedButton1.TabIndex = 29;
            this.materialRaisedButton1.Text = "Estimate Price";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // bestSell
            // 
            this.bestSell.AutoSize = true;
            this.bestSell.Location = new System.Drawing.Point(194, 419);
            this.bestSell.Name = "bestSell";
            this.bestSell.Size = new System.Drawing.Size(0, 0);
            this.bestSell.TabIndex = 30;
            // 
            // stockLeft
            // 
            this.stockLeft.AutoSize = true;
            this.stockLeft.Location = new System.Drawing.Point(194, 460);
            this.stockLeft.Name = "stockLeft";
            this.stockLeft.Size = new System.Drawing.Size(0, 0);
            this.stockLeft.TabIndex = 31;
            // 
            // customerPerDay
            // 
            this.customerPerDay.AutoSize = true;
            this.customerPerDay.Location = new System.Drawing.Point(194, 498);
            this.customerPerDay.Name = "customerPerDay";
            this.customerPerDay.Size = new System.Drawing.Size(0, 0);
            this.customerPerDay.TabIndex = 32;
            // 
            // profit
            // 
            this.profit.AutoSize = true;
            this.profit.Location = new System.Drawing.Point(194, 537);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(0, 0);
            this.profit.TabIndex = 33;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(311, 319);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(35, 13);
            this.error.TabIndex = 35;
            this.error.Text = "label2";
            this.error.Visible = false;
            // 
            // MonteCarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 626);
            this.Controls.Add(this.error);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.customerPerDay);
            this.Controls.Add(this.stockLeft);
            this.Controls.Add(this.bestSell);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.materialSingleLineTextField11);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.SellingPricetf);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.Weeks);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.Stocktf);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.MaxCustomers);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.CostPrice);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MonteCarlo";
            this.Text = "Monte Carlo Price Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField CostPrice;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField MaxCustomers;
        private MaterialSkin.Controls.MaterialSingleLineTextField Stocktf;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField Change;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField Dec;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField Weeks;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField SellingPricetf;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField11;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MetroFramework.Controls.MetroLabel bestSell;
        private MetroFramework.Controls.MetroLabel stockLeft;
        private MetroFramework.Controls.MetroLabel customerPerDay;
        private MetroFramework.Controls.MetroLabel profit;
        private System.Windows.Forms.Label error;
    }
}

