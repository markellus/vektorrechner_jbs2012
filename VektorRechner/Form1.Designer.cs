﻿namespace VektorRechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPlusMinus = new System.Windows.Forms.ComboBox();
            this.txtVektor23 = new System.Windows.Forms.TextBox();
            this.txtVektor22 = new System.Windows.Forms.TextBox();
            this.txtVektor21 = new System.Windows.Forms.TextBox();
            this.txtVektor13 = new System.Windows.Forms.TextBox();
            this.txtVektor12 = new System.Windows.Forms.TextBox();
            this.txtVektor11 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnAusrechnen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVektor33 = new System.Windows.Forms.TextBox();
            this.txtVektor32 = new System.Windows.Forms.TextBox();
            this.txtVektor31 = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.GroupBox();
            this.btnKurs = new System.Windows.Forms.Button();
            this.btnÜber = new System.Windows.Forms.Button();
            this.btnAnleitung = new System.Windows.Forms.Button();
            this.checkOrtsvektor = new System.Windows.Forms.CheckBox();
            this.btnWeb = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMultiplikator = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.x.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMultiplikator);
            this.groupBox1.Controls.Add(this.checkOrtsvektor);
            this.groupBox1.Controls.Add(this.cboPlusMinus);
            this.groupBox1.Controls.Add(this.txtVektor23);
            this.groupBox1.Controls.Add(this.txtVektor22);
            this.groupBox1.Controls.Add(this.txtVektor21);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtVektor13);
            this.groupBox1.Controls.Add(this.txtVektor12);
            this.groupBox1.Controls.Add(this.txtVektor11);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vektoren";
            // 
            // cboPlusMinus
            // 
            this.cboPlusMinus.FormattingEnabled = true;
            this.cboPlusMinus.Items.AddRange(new object[] {
            "+",
            "-",
            "*"});
            this.cboPlusMinus.Location = new System.Drawing.Point(152, 58);
            this.cboPlusMinus.Name = "cboPlusMinus";
            this.cboPlusMinus.Size = new System.Drawing.Size(38, 21);
            this.cboPlusMinus.TabIndex = 9;
            this.cboPlusMinus.SelectedIndexChanged += new System.EventHandler(this.cboPlusMinus_SelectedIndexChanged);
            // 
            // txtVektor23
            // 
            this.txtVektor23.Location = new System.Drawing.Point(222, 84);
            this.txtVektor23.Name = "txtVektor23";
            this.txtVektor23.Size = new System.Drawing.Size(78, 20);
            this.txtVektor23.TabIndex = 8;
            // 
            // txtVektor22
            // 
            this.txtVektor22.Location = new System.Drawing.Point(222, 58);
            this.txtVektor22.Name = "txtVektor22";
            this.txtVektor22.Size = new System.Drawing.Size(78, 20);
            this.txtVektor22.TabIndex = 7;
            // 
            // txtVektor21
            // 
            this.txtVektor21.Location = new System.Drawing.Point(222, 32);
            this.txtVektor21.Name = "txtVektor21";
            this.txtVektor21.Size = new System.Drawing.Size(78, 20);
            this.txtVektor21.TabIndex = 6;
            // 
            // txtVektor13
            // 
            this.txtVektor13.Location = new System.Drawing.Point(39, 84);
            this.txtVektor13.Name = "txtVektor13";
            this.txtVektor13.Size = new System.Drawing.Size(78, 20);
            this.txtVektor13.TabIndex = 3;
            // 
            // txtVektor12
            // 
            this.txtVektor12.Location = new System.Drawing.Point(39, 58);
            this.txtVektor12.Name = "txtVektor12";
            this.txtVektor12.Size = new System.Drawing.Size(78, 20);
            this.txtVektor12.TabIndex = 2;
            // 
            // txtVektor11
            // 
            this.txtVektor11.Location = new System.Drawing.Point(39, 32);
            this.txtVektor11.Name = "txtVektor11";
            this.txtVektor11.Size = new System.Drawing.Size(78, 20);
            this.txtVektor11.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrafik);
            this.groupBox2.Controls.Add(this.btnAusrechnen);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Berechnung";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Enabled = false;
            this.btnGrafik.Location = new System.Drawing.Point(6, 48);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(330, 23);
            this.btnGrafik.TabIndex = 1;
            this.btnGrafik.Text = "Grafische Darstellung";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnAusrechnen
            // 
            this.btnAusrechnen.Location = new System.Drawing.Point(6, 19);
            this.btnAusrechnen.Name = "btnAusrechnen";
            this.btnAusrechnen.Size = new System.Drawing.Size(330, 23);
            this.btnAusrechnen.TabIndex = 0;
            this.btnAusrechnen.Text = "Ausrechnen";
            this.btnAusrechnen.UseVisualStyleBackColor = true;
            this.btnAusrechnen.Click += new System.EventHandler(this.btnAusrechnen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVektor33);
            this.groupBox3.Controls.Add(this.txtVektor32);
            this.groupBox3.Controls.Add(this.txtVektor31);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ergebnis";
            // 
            // txtVektor33
            // 
            this.txtVektor33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVektor33.Location = new System.Drawing.Point(39, 84);
            this.txtVektor33.Name = "txtVektor33";
            this.txtVektor33.ReadOnly = true;
            this.txtVektor33.Size = new System.Drawing.Size(78, 20);
            this.txtVektor33.TabIndex = 16;
            // 
            // txtVektor32
            // 
            this.txtVektor32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVektor32.Location = new System.Drawing.Point(39, 58);
            this.txtVektor32.Name = "txtVektor32";
            this.txtVektor32.ReadOnly = true;
            this.txtVektor32.Size = new System.Drawing.Size(78, 20);
            this.txtVektor32.TabIndex = 15;
            // 
            // txtVektor31
            // 
            this.txtVektor31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVektor31.Location = new System.Drawing.Point(39, 32);
            this.txtVektor31.Name = "txtVektor31";
            this.txtVektor31.ReadOnly = true;
            this.txtVektor31.Size = new System.Drawing.Size(78, 20);
            this.txtVektor31.TabIndex = 14;
            // 
            // x
            // 
            this.x.Controls.Add(this.btnWeb);
            this.x.Controls.Add(this.btnKurs);
            this.x.Controls.Add(this.btnÜber);
            this.x.Controls.Add(this.btnAnleitung);
            this.x.Location = new System.Drawing.Point(177, 236);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(177, 135);
            this.x.TabIndex = 3;
            this.x.TabStop = false;
            this.x.Text = "Einstellungen";
            // 
            // btnKurs
            // 
            this.btnKurs.Location = new System.Drawing.Point(6, 48);
            this.btnKurs.Name = "btnKurs";
            this.btnKurs.Size = new System.Drawing.Size(165, 23);
            this.btnKurs.TabIndex = 2;
            this.btnKurs.Text = "Was sind Vektoren?";
            this.btnKurs.UseVisualStyleBackColor = true;
            this.btnKurs.Click += new System.EventHandler(this.btnKurs_Click);
            // 
            // btnÜber
            // 
            this.btnÜber.Location = new System.Drawing.Point(6, 106);
            this.btnÜber.Name = "btnÜber";
            this.btnÜber.Size = new System.Drawing.Size(165, 23);
            this.btnÜber.TabIndex = 1;
            this.btnÜber.Text = "Über...";
            this.btnÜber.UseVisualStyleBackColor = true;
            this.btnÜber.Click += new System.EventHandler(this.btnÜber_Click);
            // 
            // btnAnleitung
            // 
            this.btnAnleitung.Enabled = false;
            this.btnAnleitung.Location = new System.Drawing.Point(6, 19);
            this.btnAnleitung.Name = "btnAnleitung";
            this.btnAnleitung.Size = new System.Drawing.Size(165, 23);
            this.btnAnleitung.TabIndex = 0;
            this.btnAnleitung.Text = "Anleitung";
            this.btnAnleitung.UseVisualStyleBackColor = true;
            this.btnAnleitung.Click += new System.EventHandler(this.btnAnleitung_Click);
            // 
            // checkOrtsvektor
            // 
            this.checkOrtsvektor.AutoSize = true;
            this.checkOrtsvektor.Location = new System.Drawing.Point(39, 111);
            this.checkOrtsvektor.Name = "checkOrtsvektor";
            this.checkOrtsvektor.Size = new System.Drawing.Size(75, 17);
            this.checkOrtsvektor.TabIndex = 10;
            this.checkOrtsvektor.Text = "Ortsvektor";
            this.checkOrtsvektor.UseVisualStyleBackColor = true;
            this.checkOrtsvektor.CheckedChanged += new System.EventHandler(this.checkOrtsvektor_CheckedChanged);
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(6, 77);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(165, 23);
            this.btnWeb.TabIndex = 3;
            this.btnWeb.Text = "zur Website";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VektorRechner.Properties.Resources.vektorKlammer;
            this.pictureBox3.Location = new System.Drawing.Point(6, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 99);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VektorRechner.Properties.Resources.vektorKlammer;
            this.pictureBox2.Location = new System.Drawing.Point(189, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 99);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VektorRechner.Properties.Resources.vektorKlammer;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMultiplikator
            // 
            this.txtMultiplikator.Location = new System.Drawing.Point(222, 57);
            this.txtMultiplikator.Name = "txtMultiplikator";
            this.txtMultiplikator.Size = new System.Drawing.Size(78, 20);
            this.txtMultiplikator.TabIndex = 11;
            this.txtMultiplikator.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 380);
            this.Controls.Add(this.x);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Vektorrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.x.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtVektor13;
        private System.Windows.Forms.TextBox txtVektor12;
        private System.Windows.Forms.TextBox txtVektor11;
        private System.Windows.Forms.TextBox txtVektor23;
        private System.Windows.Forms.TextBox txtVektor22;
        private System.Windows.Forms.TextBox txtVektor21;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnAusrechnen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtVektor33;
        private System.Windows.Forms.TextBox txtVektor32;
        private System.Windows.Forms.TextBox txtVektor31;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox x;
        private System.Windows.Forms.Button btnÜber;
        private System.Windows.Forms.Button btnAnleitung;
        private System.Windows.Forms.ComboBox cboPlusMinus;
        private System.Windows.Forms.Button btnKurs;
        private System.Windows.Forms.CheckBox checkOrtsvektor;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.TextBox txtMultiplikator;
    }
}

