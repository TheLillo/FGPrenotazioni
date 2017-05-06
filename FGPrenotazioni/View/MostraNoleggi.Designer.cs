namespace FGPrenotazioni.View
{
    partial class MostraNoleggi
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
            this.dataGridViewRent = new System.Windows.Forms.DataGridView();
            this.comboBoxFilitri = new System.Windows.Forms.ComboBox();
            this.textBoxFilitri = new System.Windows.Forms.TextBox();
            this.buttonApplicaFilitri = new System.Windows.Forms.Button();
            this.listViewFiltriApplicati = new System.Windows.Forms.ListView();
            this.buttonClearFilitri = new System.Windows.Forms.Button();
            this.buttonMostraDettagli = new System.Windows.Forms.Button();
            this.buttonRitorno = new System.Windows.Forms.Button();
            this.checkBoxIsPagata = new System.Windows.Forms.CheckBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.checkBoxIsPercentuale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRent
            // 
            this.dataGridViewRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRent.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewRent.MultiSelect = false;
            this.dataGridViewRent.Name = "dataGridViewRent";
            this.dataGridViewRent.ReadOnly = true;
            this.dataGridViewRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRent.Size = new System.Drawing.Size(771, 334);
            this.dataGridViewRent.TabIndex = 0;
            // 
            // comboBoxFilitri
            // 
            this.comboBoxFilitri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilitri.FormattingEnabled = true;
            this.comboBoxFilitri.Location = new System.Drawing.Point(4, 4);
            this.comboBoxFilitri.Name = "comboBoxFilitri";
            this.comboBoxFilitri.Size = new System.Drawing.Size(205, 21);
            this.comboBoxFilitri.TabIndex = 1;
            // 
            // textBoxFilitri
            // 
            this.textBoxFilitri.Location = new System.Drawing.Point(4, 53);
            this.textBoxFilitri.Name = "textBoxFilitri";
            this.textBoxFilitri.Size = new System.Drawing.Size(205, 20);
            this.textBoxFilitri.TabIndex = 2;
            // 
            // buttonApplicaFilitri
            // 
            this.buttonApplicaFilitri.Location = new System.Drawing.Point(216, 53);
            this.buttonApplicaFilitri.Name = "buttonApplicaFilitri";
            this.buttonApplicaFilitri.Size = new System.Drawing.Size(75, 25);
            this.buttonApplicaFilitri.TabIndex = 3;
            this.buttonApplicaFilitri.Text = "Applica";
            this.buttonApplicaFilitri.UseVisualStyleBackColor = true;
            // 
            // listViewFiltriApplicati
            // 
            this.listViewFiltriApplicati.Location = new System.Drawing.Point(297, 4);
            this.listViewFiltriApplicati.Name = "listViewFiltriApplicati";
            this.listViewFiltriApplicati.Size = new System.Drawing.Size(190, 93);
            this.listViewFiltriApplicati.TabIndex = 4;
            this.listViewFiltriApplicati.UseCompatibleStateImageBehavior = false;
            this.listViewFiltriApplicati.View = System.Windows.Forms.View.List;
            // 
            // buttonClearFilitri
            // 
            this.buttonClearFilitri.Location = new System.Drawing.Point(493, 30);
            this.buttonClearFilitri.Name = "buttonClearFilitri";
            this.buttonClearFilitri.Size = new System.Drawing.Size(75, 23);
            this.buttonClearFilitri.TabIndex = 5;
            this.buttonClearFilitri.Text = "Reset";
            this.buttonClearFilitri.UseVisualStyleBackColor = true;
            // 
            // buttonMostraDettagli
            // 
            this.buttonMostraDettagli.Location = new System.Drawing.Point(668, 4);
            this.buttonMostraDettagli.Name = "buttonMostraDettagli";
            this.buttonMostraDettagli.Size = new System.Drawing.Size(106, 23);
            this.buttonMostraDettagli.TabIndex = 6;
            this.buttonMostraDettagli.Text = "Mostra Noleggio";
            this.buttonMostraDettagli.UseVisualStyleBackColor = true;
            // 
            // buttonRitorno
            // 
            this.buttonRitorno.Location = new System.Drawing.Point(668, 48);
            this.buttonRitorno.Name = "buttonRitorno";
            this.buttonRitorno.Size = new System.Drawing.Size(106, 49);
            this.buttonRitorno.TabIndex = 7;
            this.buttonRitorno.Text = "Ritorna Merce";
            this.buttonRitorno.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsPagata
            // 
            this.checkBoxIsPagata.AutoSize = true;
            this.checkBoxIsPagata.Location = new System.Drawing.Point(602, 80);
            this.checkBoxIsPagata.Name = "checkBoxIsPagata";
            this.checkBoxIsPagata.Size = new System.Drawing.Size(60, 17);
            this.checkBoxIsPagata.TabIndex = 8;
            this.checkBoxIsPagata.Text = "Pagata";
            this.checkBoxIsPagata.UseVisualStyleBackColor = true;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(494, 76);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiscount.TabIndex = 9;
            this.textBoxDiscount.Text = "0";
            this.textBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxIsPercentuale
            // 
            this.checkBoxIsPercentuale.AutoSize = true;
            this.checkBoxIsPercentuale.Location = new System.Drawing.Point(602, 61);
            this.checkBoxIsPercentuale.Name = "checkBoxIsPercentuale";
            this.checkBoxIsPercentuale.Size = new System.Drawing.Size(48, 17);
            this.checkBoxIsPercentuale.TabIndex = 10;
            this.checkBoxIsPercentuale.Text = "Perc";
            this.checkBoxIsPercentuale.UseVisualStyleBackColor = true;
            // 
            // MostraNoleggi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxIsPercentuale);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.checkBoxIsPagata);
            this.Controls.Add(this.buttonRitorno);
            this.Controls.Add(this.buttonMostraDettagli);
            this.Controls.Add(this.buttonClearFilitri);
            this.Controls.Add(this.listViewFiltriApplicati);
            this.Controls.Add(this.buttonApplicaFilitri);
            this.Controls.Add(this.textBoxFilitri);
            this.Controls.Add(this.comboBoxFilitri);
            this.Controls.Add(this.dataGridViewRent);
            this.Name = "MostraNoleggi";
            this.Size = new System.Drawing.Size(781, 440);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRent;
        private System.Windows.Forms.ComboBox comboBoxFilitri;
        private System.Windows.Forms.TextBox textBoxFilitri;
        private System.Windows.Forms.Button buttonApplicaFilitri;
        private System.Windows.Forms.ListView listViewFiltriApplicati;
        private System.Windows.Forms.Button buttonClearFilitri;
        private System.Windows.Forms.Button buttonMostraDettagli;
        private System.Windows.Forms.Button buttonRitorno;
        private System.Windows.Forms.CheckBox checkBoxIsPagata;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.CheckBox checkBoxIsPercentuale;
    }
}
