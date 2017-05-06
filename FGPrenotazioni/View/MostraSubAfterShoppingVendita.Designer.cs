namespace FGPrenotazioni.View
{
    partial class MostraSubAfterShoppingVendita
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
            this.procediButton = new System.Windows.Forms.Button();
            this.scontoBox = new System.Windows.Forms.TextBox();
            this.scontoLabel = new System.Windows.Forms.Label();
            this.isPercCheckBox = new System.Windows.Forms.CheckBox();
            this.pagatoCheckBox = new System.Windows.Forms.CheckBox();
            this.indietroButton = new System.Windows.Forms.Button();
            this.totaleLabel = new System.Windows.Forms.Label();
            this.mostraSubjectShopping = new FGPrenotazioni.View.MostraSubject();
            this.SuspendLayout();
            // 
            // procediButton
            // 
            this.procediButton.Location = new System.Drawing.Point(685, 450);
            this.procediButton.Name = "procediButton";
            this.procediButton.Size = new System.Drawing.Size(92, 49);
            this.procediButton.TabIndex = 1;
            this.procediButton.Text = "Procedi";
            this.procediButton.UseVisualStyleBackColor = true;
            // 
            // scontoBox
            // 
            this.scontoBox.Location = new System.Drawing.Point(13, 451);
            this.scontoBox.Name = "scontoBox";
            this.scontoBox.Size = new System.Drawing.Size(100, 20);
            this.scontoBox.TabIndex = 2;
            this.scontoBox.Text = "0";
            // 
            // scontoLabel
            // 
            this.scontoLabel.AutoSize = true;
            this.scontoLabel.Location = new System.Drawing.Point(120, 457);
            this.scontoLabel.Name = "scontoLabel";
            this.scontoLabel.Size = new System.Drawing.Size(41, 13);
            this.scontoLabel.TabIndex = 3;
            this.scontoLabel.Text = "Sconto";
            // 
            // isPercCheckBox
            // 
            this.isPercCheckBox.AutoSize = true;
            this.isPercCheckBox.Location = new System.Drawing.Point(167, 453);
            this.isPercCheckBox.Name = "isPercCheckBox";
            this.isPercCheckBox.Size = new System.Drawing.Size(91, 17);
            this.isPercCheckBox.TabIndex = 4;
            this.isPercCheckBox.Text = "inPercentuale";
            this.isPercCheckBox.UseVisualStyleBackColor = true;
            // 
            // pagatoCheckBox
            // 
            this.pagatoCheckBox.AutoSize = true;
            this.pagatoCheckBox.Location = new System.Drawing.Point(619, 482);
            this.pagatoCheckBox.Name = "pagatoCheckBox";
            this.pagatoCheckBox.Size = new System.Drawing.Size(60, 17);
            this.pagatoCheckBox.TabIndex = 5;
            this.pagatoCheckBox.Text = "Pagato";
            this.pagatoCheckBox.UseVisualStyleBackColor = true;
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(12, 478);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 6;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            // 
            // totaleLabel
            // 
            this.totaleLabel.AutoSize = true;
            this.totaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaleLabel.ForeColor = System.Drawing.Color.Red;
            this.totaleLabel.Location = new System.Drawing.Point(264, 457);
            this.totaleLabel.Name = "totaleLabel";
            this.totaleLabel.Size = new System.Drawing.Size(105, 31);
            this.totaleLabel.TabIndex = 7;
            this.totaleLabel.Text = "Totale:";
            // 
            // mostraSubjectShopping
            // 
            this.mostraSubjectShopping.Dock = System.Windows.Forms.DockStyle.Top;
            this.mostraSubjectShopping.Location = new System.Drawing.Point(0, 0);
            this.mostraSubjectShopping.Name = "mostraSubjectShopping";
            this.mostraSubjectShopping.Size = new System.Drawing.Size(788, 444);
            this.mostraSubjectShopping.TabIndex = 0;
            this.mostraSubjectShopping.RimuoviCliente.Visible = false;
            // 
            // MostraSubAfterShoppingVendita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 511);
            this.ControlBox = false;
            this.Controls.Add(this.totaleLabel);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.pagatoCheckBox);
            this.Controls.Add(this.isPercCheckBox);
            this.Controls.Add(this.scontoLabel);
            this.Controls.Add(this.scontoBox);
            this.Controls.Add(this.procediButton);
            this.Controls.Add(this.mostraSubjectShopping);
            this.Name = "MostraSubAfterShoppingVendita";
            this.Text = "MostraSubAfterShoppingVendita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private MostraSubject mostraSubjectShopping;
        private System.Windows.Forms.Button procediButton;
        private System.Windows.Forms.TextBox scontoBox;
        private System.Windows.Forms.Label scontoLabel;
        private System.Windows.Forms.CheckBox isPercCheckBox;
        private System.Windows.Forms.CheckBox pagatoCheckBox;
        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.Label totaleLabel;
    }
}