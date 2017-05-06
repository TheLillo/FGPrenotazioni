using System.Windows.Forms;

namespace FGPrenotazioni.View
{
    partial class ShopppingCartForm
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
            this.shoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.noleggioRadioButton = new System.Windows.Forms.RadioButton();
            this.venditaRadioButton = new System.Windows.Forms.RadioButton();
            this.procediButton = new System.Windows.Forms.Button();
            this.indietroButton = new System.Windows.Forms.Button();
            this.gruppo = new System.Windows.Forms.GroupBox();
            this.eliminaProductShopping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shoppingCartDataGridView
            // 
            this.shoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartDataGridView.Location = new System.Drawing.Point(12, 12);
            this.shoppingCartDataGridView.Name = "shoppingCartDataGridView";
            this.shoppingCartDataGridView.ReadOnly = true;
            this.shoppingCartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shoppingCartDataGridView.Size = new System.Drawing.Size(660, 283);
            this.shoppingCartDataGridView.TabIndex = 0;
            // 
            // noleggioRadioButton
            // 
            this.noleggioRadioButton.AutoSize = true;
            this.noleggioRadioButton.Location = new System.Drawing.Point(12, 305);
            this.noleggioRadioButton.Name = "noleggioRadioButton";
            this.noleggioRadioButton.Size = new System.Drawing.Size(67, 17);
            this.noleggioRadioButton.TabIndex = 1;
            this.noleggioRadioButton.TabStop = true;
            this.noleggioRadioButton.Text = "Noleggio";
            this.noleggioRadioButton.UseVisualStyleBackColor = true;
            // 
            // venditaRadioButton
            // 
            this.venditaRadioButton.AutoSize = true;
            this.venditaRadioButton.Checked = true;
            this.venditaRadioButton.Location = new System.Drawing.Point(85, 305);
            this.venditaRadioButton.Name = "venditaRadioButton";
            this.venditaRadioButton.Size = new System.Drawing.Size(61, 17);
            this.venditaRadioButton.TabIndex = 2;
            this.venditaRadioButton.TabStop = true;
            this.venditaRadioButton.Text = "Vendita";
            this.venditaRadioButton.UseVisualStyleBackColor = true;
            // 
            // procediButton
            // 
            this.procediButton.Location = new System.Drawing.Point(597, 302);
            this.procediButton.Name = "procediButton";
            this.procediButton.Size = new System.Drawing.Size(75, 23);
            this.procediButton.TabIndex = 3;
            this.procediButton.Text = "Procedi";
            this.procediButton.UseVisualStyleBackColor = true;
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(516, 302);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 4;
            this.indietroButton.Text = "Nascondi";
            this.indietroButton.UseVisualStyleBackColor = true;
            // 
            // gruppo
            // 
            this.gruppo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gruppo.Location = new System.Drawing.Point(0, 0);
            this.gruppo.Name = "gruppo";
            this.gruppo.Size = new System.Drawing.Size(200, 100);
            this.gruppo.TabIndex = 0;
            this.gruppo.TabStop = false;
            // 
            // eliminaProductShopping
            // 
            this.eliminaProductShopping.Location = new System.Drawing.Point(435, 302);
            this.eliminaProductShopping.Name = "eliminaProductShopping";
            this.eliminaProductShopping.Size = new System.Drawing.Size(75, 23);
            this.eliminaProductShopping.TabIndex = 5;
            this.eliminaProductShopping.Text = "Elimina";
            this.eliminaProductShopping.UseVisualStyleBackColor = true;
            // 
            // ShopppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 332);
            this.ControlBox = false;
            this.Controls.Add(this.venditaRadioButton);
            this.Controls.Add(this.eliminaProductShopping);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.procediButton);
            this.Controls.Add(this.noleggioRadioButton);
            this.Controls.Add(this.shoppingCartDataGridView);
            this.Name = "ShopppingCartForm";
            this.Text = "ShopppingCartForm";
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView shoppingCartDataGridView;
        private System.Windows.Forms.RadioButton noleggioRadioButton;
        private System.Windows.Forms.RadioButton venditaRadioButton;
        private System.Windows.Forms.Button procediButton;
        private System.Windows.Forms.Button indietroButton;
        private GroupBox gruppo;
        private Button eliminaProductShopping;
    }
}