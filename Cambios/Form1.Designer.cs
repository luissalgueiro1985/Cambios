﻿
namespace Cambios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxOrigem = new System.Windows.Forms.ComboBox();
            this.ComboBoxDestino = new System.Windows.Forms.ComboBox();
            this.ButtonConverter = new System.Windows.Forms.Button();
            this.LabelResultado = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.ButtonTroca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // TextBoxValor
            // 
            this.TextBoxValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxValor.Location = new System.Drawing.Point(143, 64);
            this.TextBoxValor.Name = "TextBoxValor";
            this.TextBoxValor.Size = new System.Drawing.Size(444, 29);
            this.TextBoxValor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moeda de origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(82, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moeda de destino:";
            // 
            // ComboBoxOrigem
            // 
            this.ComboBoxOrigem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxOrigem.FormattingEnabled = true;
            this.ComboBoxOrigem.Location = new System.Drawing.Point(260, 134);
            this.ComboBoxOrigem.Name = "ComboBoxOrigem";
            this.ComboBoxOrigem.Size = new System.Drawing.Size(327, 29);
            this.ComboBoxOrigem.TabIndex = 4;
            // 
            // ComboBoxDestino
            // 
            this.ComboBoxDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxDestino.FormattingEnabled = true;
            this.ComboBoxDestino.Location = new System.Drawing.Point(260, 196);
            this.ComboBoxDestino.Name = "ComboBoxDestino";
            this.ComboBoxDestino.Size = new System.Drawing.Size(327, 29);
            this.ComboBoxDestino.TabIndex = 5;
            // 
            // ButtonConverter
            // 
            this.ButtonConverter.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonConverter.Enabled = false;
            this.ButtonConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConverter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonConverter.Location = new System.Drawing.Point(649, 64);
            this.ButtonConverter.Name = "ButtonConverter";
            this.ButtonConverter.Size = new System.Drawing.Size(117, 47);
            this.ButtonConverter.TabIndex = 6;
            this.ButtonConverter.Text = "Converter";
            this.ButtonConverter.UseVisualStyleBackColor = false;
            this.ButtonConverter.Click += new System.EventHandler(this.ButtonConverter_Click);
            // 
            // LabelResultado
            // 
            this.LabelResultado.AutoSize = true;
            this.LabelResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelResultado.Location = new System.Drawing.Point(194, 282);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.Size = new System.Drawing.Size(356, 21);
            this.LabelResultado.TabIndex = 7;
            this.LabelResultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelStatus.ForeColor = System.Drawing.Color.SteelBlue;
            this.LabelStatus.Location = new System.Drawing.Point(82, 386);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(53, 20);
            this.LabelStatus.TabIndex = 8;
            this.LabelStatus.Text = "Status";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(541, 386);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(225, 23);
            this.ProgressBar1.TabIndex = 9;
            // 
            // ButtonTroca
            // 
            this.ButtonTroca.BackgroundImage = global::Cambios.Properties.Resources.ic_change;
            this.ButtonTroca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonTroca.Enabled = false;
            this.ButtonTroca.Location = new System.Drawing.Point(674, 152);
            this.ButtonTroca.Name = "ButtonTroca";
            this.ButtonTroca.Size = new System.Drawing.Size(69, 49);
            this.ButtonTroca.TabIndex = 10;
            this.ButtonTroca.UseVisualStyleBackColor = true;
            this.ButtonTroca.Click += new System.EventHandler(this.ButtonTroca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonTroca);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.ButtonConverter);
            this.Controls.Add(this.ComboBoxDestino);
            this.Controls.Add(this.ComboBoxOrigem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxOrigem;
        private System.Windows.Forms.ComboBox ComboBoxDestino;
        private System.Windows.Forms.Button ButtonConverter;
        private System.Windows.Forms.Label LabelResultado;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Button ButtonTroca;
    }
}

