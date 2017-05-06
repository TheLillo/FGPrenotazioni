namespace FGPrenotazioni.View
{
    partial class MainPage
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
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.menuTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.selectLabel = new System.Windows.Forms.Label();
            this.showRentLabel = new System.Windows.Forms.Label();
            this.showFattureLabel = new System.Windows.Forms.Label();
            this.showSubjectLabel = new System.Windows.Forms.Label();
            this.loggedUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainTableLayout.SuspendLayout();
            this.menuTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.BackColor = System.Drawing.SystemColors.Window;
            this.mainTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.28494F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.71506F));
            this.mainTableLayout.Controls.Add(this.menuTableLayoutPanel, 0, 0);
            this.mainTableLayout.Controls.Add(this.tableLayoutPanel, 1, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.Size = new System.Drawing.Size(988, 450);
            this.mainTableLayout.TabIndex = 0;
            // 
            // menuTableLayoutPanel
            // 
            this.menuTableLayoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.menuTableLayoutPanel.ColumnCount = 1;
            this.menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuTableLayoutPanel.Controls.Add(this.homeLabel, 0, 0);
            this.menuTableLayoutPanel.Controls.Add(this.selectLabel, 0, 1);
            this.menuTableLayoutPanel.Controls.Add(this.showRentLabel, 0, 2);
            this.menuTableLayoutPanel.Controls.Add(this.showFattureLabel, 0, 3);
            this.menuTableLayoutPanel.Controls.Add(this.showSubjectLabel, 0, 4);
            this.menuTableLayoutPanel.Controls.Add(this.loggedUser, 0, 5);
            this.menuTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.menuTableLayoutPanel.Name = "menuTableLayoutPanel";
            this.menuTableLayoutPanel.RowCount = 6;
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.menuTableLayoutPanel.Size = new System.Drawing.Size(183, 442);
            this.menuTableLayoutPanel.TabIndex = 0;
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(3, 0);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(177, 117);
            this.homeLabel.TabIndex = 1;
            this.homeLabel.Text = "Home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLabel.Click += new System.EventHandler(this._homeLabel_Click);
            this.homeLabel.MouseEnter += new System.EventHandler(this._homeLabel_MouseEnter);
            this.homeLabel.MouseLeave += new System.EventHandler(this._homeLabel_MouseLeave);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(3, 117);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(177, 52);
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "Seleziona  Prodotti";
            this.selectLabel.Click += new System.EventHandler(this._selectProductLabel_Click);
            this.selectLabel.MouseEnter += new System.EventHandler(this._selectProductLabel_MouseEnter);
            this.selectLabel.MouseLeave += new System.EventHandler(this._selectProductLabel_MouseLeave);
            // 
            // showRentLabel
            // 
            this.showRentLabel.AutoSize = true;
            this.showRentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRentLabel.Location = new System.Drawing.Point(3, 169);
            this.showRentLabel.Name = "showRentLabel";
            this.showRentLabel.Size = new System.Drawing.Size(177, 55);
            this.showRentLabel.TabIndex = 3;
            this.showRentLabel.Text = "Mostra Noleggi";
            this.showRentLabel.Click += new System.EventHandler(this._searchLabelRent_Click);
            this.showRentLabel.MouseEnter += new System.EventHandler(this._searchLabelRent_MouseEnter);
            this.showRentLabel.MouseLeave += new System.EventHandler(this._searchLabelRent_MouseLeave);
            // 
            // showFattureLabel
            // 
            this.showFattureLabel.AutoSize = true;
            this.showFattureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showFattureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFattureLabel.Location = new System.Drawing.Point(3, 224);
            this.showFattureLabel.Name = "showFattureLabel";
            this.showFattureLabel.Size = new System.Drawing.Size(177, 54);
            this.showFattureLabel.TabIndex = 4;
            this.showFattureLabel.Text = "Mostra Fatture";
            this.showFattureLabel.Click += new System.EventHandler(this._searchLabelFatture_Click);
            this.showFattureLabel.MouseEnter += new System.EventHandler(this._searchLabelFatture_MouseEnter);
            this.showFattureLabel.MouseLeave += new System.EventHandler(this._searchLabelFatture_MouseLeave);
            // 
            // showSubjectLabel
            // 
            this.showSubjectLabel.AutoSize = true;
            this.showSubjectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSubjectLabel.Location = new System.Drawing.Point(3, 278);
            this.showSubjectLabel.Name = "showSubjectLabel";
            this.showSubjectLabel.Size = new System.Drawing.Size(177, 56);
            this.showSubjectLabel.TabIndex = 5;
            this.showSubjectLabel.Text = "Mostra Clienti";
            this.showSubjectLabel.Click += new System.EventHandler(this._searchSubjectLabel_Click);
            this.showSubjectLabel.MouseEnter += new System.EventHandler(this._searchSubjectLabel_MouseEnter);
            this.showSubjectLabel.MouseLeave += new System.EventHandler(this._searchSubjectLabel_MouseLeave);
            // 
            // loggedUser
            // 
            this.loggedUser.AutoSize = true;
            this.loggedUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.loggedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedUser.Location = new System.Drawing.Point(2, 334);
            this.loggedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loggedUser.Name = "loggedUser";
            this.loggedUser.Size = new System.Drawing.Size(179, 17);
            this.loggedUser.TabIndex = 6;
            this.loggedUser.Text = "User";
            this.loggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loggedUser.Click += new System.EventHandler(this._logoutLabel_Click);
            this.loggedUser.MouseEnter += new System.EventHandler(this._logoutLabel_MouseEnter);
            this.loggedUser.MouseLeave += new System.EventHandler(this._logoutLabel_MouseLeave);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(193, 3);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(792, 444);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.mainTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.mainTableLayout.ResumeLayout(false);
            this.menuTableLayoutPanel.ResumeLayout(false);
            this.menuTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TableLayoutPanel menuTableLayoutPanel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label showRentLabel;
        private System.Windows.Forms.Label showFattureLabel;
        private System.Windows.Forms.Label showSubjectLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label loggedUser;
    }
}