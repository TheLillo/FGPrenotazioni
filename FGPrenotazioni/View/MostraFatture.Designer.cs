namespace FGPrenotazioni.View
{
    partial class MostraFatture
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
            this.dataGridViewFatture = new System.Windows.Forms.DataGridView();
            this.comboBoxFilterFatture = new System.Windows.Forms.ComboBox();
            this.textBoxFiltroFatture = new System.Windows.Forms.TextBox();
            this.buttonApplicaFiltro = new System.Windows.Forms.Button();
            this.listViewFiltriApplicati = new System.Windows.Forms.ListView();
            this.buttonRestFiltro = new System.Windows.Forms.Button();
            this.buttonShowFattura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFatture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFatture
            // 
            this.dataGridViewFatture.AllowUserToAddRows = false;
            this.dataGridViewFatture.AllowUserToDeleteRows = false;
            this.dataGridViewFatture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFatture.Location = new System.Drawing.Point(3, 110);
            this.dataGridViewFatture.MultiSelect = false;
            this.dataGridViewFatture.Name = "dataGridViewFatture";
            this.dataGridViewFatture.ReadOnly = true;
            this.dataGridViewFatture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFatture.Size = new System.Drawing.Size(772, 322);
            this.dataGridViewFatture.TabIndex = 0;
            // 
            // comboBoxFilterFatture
            // 
            this.comboBoxFilterFatture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterFatture.FormattingEnabled = true;
            this.comboBoxFilterFatture.Location = new System.Drawing.Point(4, 19);
            this.comboBoxFilterFatture.Name = "comboBoxFilterFatture";
            this.comboBoxFilterFatture.Size = new System.Drawing.Size(224, 21);
            this.comboBoxFilterFatture.TabIndex = 1;
            // 
            // textBoxFiltroFatture
            // 
            this.textBoxFiltroFatture.Location = new System.Drawing.Point(4, 58);
            this.textBoxFiltroFatture.Name = "textBoxFiltroFatture";
            this.textBoxFiltroFatture.Size = new System.Drawing.Size(224, 20);
            this.textBoxFiltroFatture.TabIndex = 2;
            // 
            // buttonApplicaFiltro
            // 
            this.buttonApplicaFiltro.Location = new System.Drawing.Point(234, 56);
            this.buttonApplicaFiltro.Name = "buttonApplicaFiltro";
            this.buttonApplicaFiltro.Size = new System.Drawing.Size(75, 23);
            this.buttonApplicaFiltro.TabIndex = 3;
            this.buttonApplicaFiltro.Text = "Applica";
            this.buttonApplicaFiltro.UseVisualStyleBackColor = true;
            // 
            // listViewFiltriApplicati
            // 
            this.listViewFiltriApplicati.Location = new System.Drawing.Point(315, 7);
            this.listViewFiltriApplicati.Name = "listViewFiltriApplicati";
            this.listViewFiltriApplicati.Size = new System.Drawing.Size(210, 72);
            this.listViewFiltriApplicati.TabIndex = 4;
            this.listViewFiltriApplicati.UseCompatibleStateImageBehavior = false;
            this.listViewFiltriApplicati.View = System.Windows.Forms.View.List;
            // 
            // buttonRestFiltro
            // 
            this.buttonRestFiltro.Location = new System.Drawing.Point(531, 55);
            this.buttonRestFiltro.Name = "buttonRestFiltro";
            this.buttonRestFiltro.Size = new System.Drawing.Size(75, 23);
            this.buttonRestFiltro.TabIndex = 5;
            this.buttonRestFiltro.Text = "Reset";
            this.buttonRestFiltro.UseVisualStyleBackColor = true;
            // 
            // buttonShowFattura
            // 
            this.buttonShowFattura.Location = new System.Drawing.Point(612, 7);
            this.buttonShowFattura.Name = "buttonShowFattura";
            this.buttonShowFattura.Size = new System.Drawing.Size(163, 75);
            this.buttonShowFattura.TabIndex = 6;
            this.buttonShowFattura.Text = "Mostra";
            this.buttonShowFattura.UseVisualStyleBackColor = true;
            // 
            // MostraFatture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonShowFattura);
            this.Controls.Add(this.buttonRestFiltro);
            this.Controls.Add(this.listViewFiltriApplicati);
            this.Controls.Add(this.buttonApplicaFiltro);
            this.Controls.Add(this.textBoxFiltroFatture);
            this.Controls.Add(this.comboBoxFilterFatture);
            this.Controls.Add(this.dataGridViewFatture);
            this.Name = "MostraFatture";
            this.Size = new System.Drawing.Size(779, 435);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFatture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFatture;
        private System.Windows.Forms.ComboBox comboBoxFilterFatture;
        private System.Windows.Forms.TextBox textBoxFiltroFatture;
        private System.Windows.Forms.Button buttonApplicaFiltro;
        private System.Windows.Forms.ListView listViewFiltriApplicati;
        private System.Windows.Forms.Button buttonRestFiltro;
        private System.Windows.Forms.Button buttonShowFattura;
    }
}
