using System.Windows.Forms;

namespace FGPrenotazioni.View
{
    partial class SelezionaProdotti
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productListDataGrid = new System.Windows.Forms.DataGridView();
            this.aggiungiButton = new System.Windows.Forms.Button();
            this.mostraButton = new System.Windows.Forms.Button();
            this.filterListCombo = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.filterValueText = new System.Windows.Forms.TextBox();
            this.listaFiltri = new System.Windows.Forms.ListView();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productListDataGrid
            // 
            this.productListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListDataGrid.Location = new System.Drawing.Point(3, 70);
            this.productListDataGrid.MultiSelect = false;
            this.productListDataGrid.Name = "productListDataGrid";
            this.productListDataGrid.ReadOnly = true;
            this.productListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productListDataGrid.Size = new System.Drawing.Size(740, 275);
            this.productListDataGrid.TabIndex = 0;
            // 
            // aggiungiButton
            // 
            this.aggiungiButton.Location = new System.Drawing.Point(632, 351);
            this.aggiungiButton.Name = "aggiungiButton";
            this.aggiungiButton.Size = new System.Drawing.Size(108, 56);
            this.aggiungiButton.TabIndex = 1;
            this.aggiungiButton.Text = "Aggiungi al Carrello";
            this.aggiungiButton.UseVisualStyleBackColor = true;
            // 
            // mostraButton
            // 
            this.mostraButton.Location = new System.Drawing.Point(632, 3);
            this.mostraButton.Name = "mostraButton";
            this.mostraButton.Size = new System.Drawing.Size(111, 61);
            this.mostraButton.TabIndex = 2;
            this.mostraButton.Text = "Mostra Carrello";
            this.mostraButton.UseVisualStyleBackColor = true;
            // 
            // filterListCombo
            // 
            this.filterListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterListCombo.FormattingEnabled = true;
            this.filterListCombo.Location = new System.Drawing.Point(3, 3);
            this.filterListCombo.Name = "filterListCombo";
            this.filterListCombo.Size = new System.Drawing.Size(223, 21);
            this.filterListCombo.TabIndex = 3;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(232, 41);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Applica";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // filterValueText
            // 
            this.filterValueText.Location = new System.Drawing.Point(4, 43);
            this.filterValueText.Name = "filterValueText";
            this.filterValueText.Size = new System.Drawing.Size(222, 20);
            this.filterValueText.TabIndex = 5;
            // 
            // listaFiltri
            // 
            this.listaFiltri.Location = new System.Drawing.Point(313, 3);
            this.listaFiltri.MultiSelect = false;
            this.listaFiltri.Name = "listaFiltri";
            this.listaFiltri.Size = new System.Drawing.Size(170, 61);
            this.listaFiltri.TabIndex = 6;
            this.listaFiltri.UseCompatibleStateImageBehavior = false;
            this.listaFiltri.View = System.Windows.Forms.View.SmallIcon;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(489, 41);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // SelezionaProdotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.listaFiltri);
            this.Controls.Add(this.filterValueText);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.filterListCombo);
            this.Controls.Add(this.mostraButton);
            this.Controls.Add(this.aggiungiButton);
            this.Controls.Add(this.productListDataGrid);
            this.Name = "SelezionaProdotti";
            this.Size = new System.Drawing.Size(749, 410);
            ((System.ComponentModel.ISupportInitialize)(this.productListDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productListDataGrid;
        private System.Windows.Forms.Button aggiungiButton;
        private System.Windows.Forms.Button mostraButton;
        private System.Windows.Forms.ComboBox filterListCombo;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox filterValueText;
        private ListView listaFiltri;
        private Button resetButton;
    }
}
