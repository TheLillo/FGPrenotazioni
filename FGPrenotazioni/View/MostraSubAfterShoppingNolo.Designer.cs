using System;

namespace FGPrenotazioni.View
{
    partial class MostraSubAfterShoppingNolo
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
            this.indietroButton = new System.Windows.Forms.Button();
            this.inizioTime = new System.Windows.Forms.DateTimePicker();
            this.fineTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scontoTextBox = new System.Windows.Forms.TextBox();
            this.isPercentuale = new System.Windows.Forms.CheckBox();
            this.totaleLabel = new System.Windows.Forms.Label();
            this.mostraSubject1 = new FGPrenotazioni.View.MostraSubject();
            this.SuspendLayout();
            // 
            // procediButton
            // 
            this.procediButton.Location = new System.Drawing.Point(719, 459);
            this.procediButton.Name = "procediButton";
            this.procediButton.Size = new System.Drawing.Size(75, 23);
            this.procediButton.TabIndex = 1;
            this.procediButton.Text = "Procedi";
            this.procediButton.UseVisualStyleBackColor = true;
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(719, 488);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 2;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            // 
            // inizioTime
            // 
            this.inizioTime.Enabled = false;
            this.inizioTime.Location = new System.Drawing.Point(54, 453);
            this.inizioTime.Name = "inizioTime";
            this.inizioTime.Size = new System.Drawing.Size(200, 20);
            this.inizioTime.TabIndex = 3;
            this.inizioTime.Value = new System.DateTime(2016, 11, 29, 17, 39, 2, 624);
            // 
            // fineTime
            // 
            this.fineTime.Location = new System.Drawing.Point(54, 491);
            this.fineTime.Name = "fineTime";
            this.fineTime.Size = new System.Drawing.Size(200, 20);
            this.fineTime.TabIndex = 4;
            this.fineTime.Value = new System.DateTime(2016, 11, 30, 17, 39, 2, 640);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "inzio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "fine";
            // 
            // scontoTextBox
            // 
            this.scontoTextBox.Location = new System.Drawing.Point(260, 491);
            this.scontoTextBox.Name = "scontoTextBox";
            this.scontoTextBox.Size = new System.Drawing.Size(100, 20);
            this.scontoTextBox.TabIndex = 7;
            this.scontoTextBox.Text = "0";
            // 
            // isPercentuale
            // 
            this.isPercentuale.AutoSize = true;
            this.isPercentuale.Location = new System.Drawing.Point(366, 494);
            this.isPercentuale.Name = "isPercentuale";
            this.isPercentuale.Size = new System.Drawing.Size(91, 17);
            this.isPercentuale.TabIndex = 8;
            this.isPercentuale.Text = "inPercentuale";
            this.isPercentuale.UseVisualStyleBackColor = true;
            // 
            // totaleLabel
            // 
            this.totaleLabel.AutoSize = true;
            this.totaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaleLabel.ForeColor = System.Drawing.Color.Red;
            this.totaleLabel.Location = new System.Drawing.Point(260, 455);
            this.totaleLabel.Name = "totaleLabel";
            this.totaleLabel.Size = new System.Drawing.Size(85, 25);
            this.totaleLabel.TabIndex = 9;
            this.totaleLabel.Text = "Totale:";
            // 
            // mostraSubject1
            // 
            this.mostraSubject1.Location = new System.Drawing.Point(12, 12);
            this.mostraSubject1.Name = "mostraSubject1";
            this.mostraSubject1.Size = new System.Drawing.Size(790, 440);
            this.mostraSubject1.TabIndex = 0;
            this.mostraSubject1.RimuoviCliente.Visible = false;
            // 
            // MostraSubAfterShoppingNolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 525);
            this.ControlBox = false;
            this.Controls.Add(this.totaleLabel);
            this.Controls.Add(this.isPercentuale);
            this.Controls.Add(this.scontoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fineTime);
            this.Controls.Add(this.inizioTime);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.procediButton);
            this.Controls.Add(this.mostraSubject1);
            this.Name = "MostraSubAfterShoppingNolo";
            this.Text = "MostraSubAfterShoppingNolo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MostraSubject mostraSubject1;
        private System.Windows.Forms.Button procediButton;
        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.DateTimePicker inizioTime;
        private System.Windows.Forms.DateTimePicker fineTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scontoTextBox;
        private System.Windows.Forms.CheckBox isPercentuale;
        private System.Windows.Forms.Label totaleLabel;
    }
}