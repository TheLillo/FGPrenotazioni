namespace FGPrenotazioni.View
{
    partial class MostraSubject
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
            this.dataGridSubject = new System.Windows.Forms.DataGridView();
            this.aggiungiSubject = new System.Windows.Forms.Button();
            this.comboBoxFiltriSubject = new System.Windows.Forms.ComboBox();
            this.filterText = new System.Windows.Forms.TextBox();
            this.applicaFiltroSubject = new System.Windows.Forms.Button();
            this.listaApplyFilter = new System.Windows.Forms.ListView();
            this.ClearSubjectFilter = new System.Windows.Forms.Button();
            this.buttonRimuovi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSubject
            // 
            this.dataGridSubject.AllowUserToAddRows = false;
            this.dataGridSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubject.Location = new System.Drawing.Point(3, 62);
            this.dataGridSubject.MultiSelect = false;
            this.dataGridSubject.Name = "dataGridSubject";
            this.dataGridSubject.ReadOnly = true;
            this.dataGridSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSubject.Size = new System.Drawing.Size(784, 375);
            this.dataGridSubject.TabIndex = 0;
            // 
            // aggiungiSubject
            // 
            this.aggiungiSubject.Location = new System.Drawing.Point(677, 3);
            this.aggiungiSubject.Name = "aggiungiSubject";
            this.aggiungiSubject.Size = new System.Drawing.Size(110, 53);
            this.aggiungiSubject.TabIndex = 1;
            this.aggiungiSubject.Text = "Aggiungi Cliente";
            this.aggiungiSubject.UseVisualStyleBackColor = true;
            // 
            // comboBoxFiltriSubject
            // 
            this.comboBoxFiltriSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltriSubject.FormattingEnabled = true;
            this.comboBoxFiltriSubject.Location = new System.Drawing.Point(3, 3);
            this.comboBoxFiltriSubject.Name = "comboBoxFiltriSubject";
            this.comboBoxFiltriSubject.Size = new System.Drawing.Size(167, 21);
            this.comboBoxFiltriSubject.TabIndex = 2;
            // 
            // filterText
            // 
            this.filterText.Location = new System.Drawing.Point(4, 36);
            this.filterText.Name = "filterText";
            this.filterText.Size = new System.Drawing.Size(166, 20);
            this.filterText.TabIndex = 4;
            // 
            // applicaFiltroSubject
            // 
            this.applicaFiltroSubject.Location = new System.Drawing.Point(176, 33);
            this.applicaFiltroSubject.Name = "applicaFiltroSubject";
            this.applicaFiltroSubject.Size = new System.Drawing.Size(75, 23);
            this.applicaFiltroSubject.TabIndex = 6;
            this.applicaFiltroSubject.Text = "Applica";
            this.applicaFiltroSubject.UseVisualStyleBackColor = true;
            // 
            // listaApplyFilter
            // 
            this.listaApplyFilter.Location = new System.Drawing.Point(257, 4);
            this.listaApplyFilter.MultiSelect = false;
            this.listaApplyFilter.Name = "listaApplyFilter";
            this.listaApplyFilter.Size = new System.Drawing.Size(221, 52);
            this.listaApplyFilter.TabIndex = 7;
            this.listaApplyFilter.UseCompatibleStateImageBehavior = false;
            this.listaApplyFilter.View = System.Windows.Forms.View.List;
            // 
            // ClearSubjectFilter
            // 
            this.ClearSubjectFilter.Location = new System.Drawing.Point(484, 34);
            this.ClearSubjectFilter.Name = "ClearSubjectFilter";
            this.ClearSubjectFilter.Size = new System.Drawing.Size(75, 23);
            this.ClearSubjectFilter.TabIndex = 8;
            this.ClearSubjectFilter.Text = "Reset";
            this.ClearSubjectFilter.UseVisualStyleBackColor = true;
            // 
            // buttonRimuovi
            // 
            this.buttonRimuovi.Location = new System.Drawing.Point(565, 4);
            this.buttonRimuovi.Name = "buttonRimuovi";
            this.buttonRimuovi.Size = new System.Drawing.Size(106, 52);
            this.buttonRimuovi.TabIndex = 9;
            this.buttonRimuovi.Text = "Rimuovi Cliente";
            this.buttonRimuovi.UseVisualStyleBackColor = true;
            // 
            // MostraSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRimuovi);
            this.Controls.Add(this.ClearSubjectFilter);
            this.Controls.Add(this.listaApplyFilter);
            this.Controls.Add(this.applicaFiltroSubject);
            this.Controls.Add(this.filterText);
            this.Controls.Add(this.comboBoxFiltriSubject);
            this.Controls.Add(this.aggiungiSubject);
            this.Controls.Add(this.dataGridSubject);
            this.Name = "MostraSubject";
            this.Size = new System.Drawing.Size(790, 440);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSubject;
        private System.Windows.Forms.Button aggiungiSubject;
        private System.Windows.Forms.ComboBox comboBoxFiltriSubject;
        private System.Windows.Forms.TextBox filterText;
        private System.Windows.Forms.Button applicaFiltroSubject;
        private System.Windows.Forms.ListView listaApplyFilter;
        private System.Windows.Forms.Button ClearSubjectFilter;
        private System.Windows.Forms.Button buttonRimuovi;
    }
}
