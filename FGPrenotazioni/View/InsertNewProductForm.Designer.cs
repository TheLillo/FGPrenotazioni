using System.Windows.Forms;

namespace FGPrenotazioni.View
{
    partial class InsertNewProductForm
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
            this.venditaText = new System.Windows.Forms.TextBox();
            this.descrizioneText = new System.Windows.Forms.TextBox();
            this.marcaText = new System.Windows.Forms.TextBox();
            this.noleggioText = new System.Windows.Forms.TextBox();
            this.tipologyCombo = new System.Windows.Forms.ComboBox();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.confermaButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // venditaText
            // 
            this.venditaText.Location = new System.Drawing.Point(106, 118);
            this.venditaText.Name = "venditaText";
            this.venditaText.Size = new System.Drawing.Size(166, 20);
            this.venditaText.TabIndex = 0;
            // 
            // descrizioneText
            // 
            this.descrizioneText.Location = new System.Drawing.Point(106, 66);
            this.descrizioneText.Name = "descrizioneText";
            this.descrizioneText.Size = new System.Drawing.Size(166, 20);
            this.descrizioneText.TabIndex = 1;
            // 
            // marcaText
            // 
            this.marcaText.Location = new System.Drawing.Point(106, 92);
            this.marcaText.Name = "marcaText";
            this.marcaText.Size = new System.Drawing.Size(166, 20);
            this.marcaText.TabIndex = 2;
            // 
            // noleggioText
            // 
            this.noleggioText.Location = new System.Drawing.Point(106, 144);
            this.noleggioText.Name = "noleggioText";
            this.noleggioText.Size = new System.Drawing.Size(166, 20);
            this.noleggioText.TabIndex = 3;
            // 
            // tipologyCombo
            // 
            this.tipologyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipologyCombo.FormattingEnabled = true;
            this.tipologyCombo.Location = new System.Drawing.Point(85, 12);
            this.tipologyCombo.Name = "tipologyCombo";
            this.tipologyCombo.Size = new System.Drawing.Size(187, 21);
            this.tipologyCombo.TabIndex = 4;
            // 
            // categoryCombo
            // 
            this.categoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(85, 39);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(187, 21);
            this.categoryCombo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipologia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrizione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prezzo Vendita";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prezzo Noleggio";
            // 
            // confermaButton
            // 
            this.confermaButton.Location = new System.Drawing.Point(197, 226);
            this.confermaButton.Name = "confermaButton";
            this.confermaButton.Size = new System.Drawing.Size(75, 23);
            this.confermaButton.TabIndex = 12;
            this.confermaButton.Text = "Conferma";
            this.confermaButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(116, 226);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Indietro";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // InsertNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confermaButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.tipologyCombo);
            this.Controls.Add(this.noleggioText);
            this.Controls.Add(this.marcaText);
            this.Controls.Add(this.descrizioneText);
            this.Controls.Add(this.venditaText);
            this.Name = "InsertNewProductForm";
            this.Text = "InsertNewProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox venditaText;
        private System.Windows.Forms.TextBox descrizioneText;
        private System.Windows.Forms.TextBox marcaText;
        private System.Windows.Forms.TextBox noleggioText;
        private System.Windows.Forms.ComboBox tipologyCombo;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button confermaButton;
        private System.Windows.Forms.Button backButton;
    }
}