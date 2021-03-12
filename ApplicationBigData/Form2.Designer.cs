
using System;

namespace ApplicationBigData
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ajoutAuteur = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtDomicile = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ajoutLivre = new System.Windows.Forms.Button();
            this.txtNumLivre = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ajoutRelation = new System.Windows.Forms.Button();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.txtTitreR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listeAuteurs = new System.Windows.Forms.Button();
            this.listeLivres = new System.Windows.Forms.Button();
            this.demenstration = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ajoutAuteur);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.txtDomicile);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auteur";
            // 
            // ajoutAuteur
            // 
            this.ajoutAuteur.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ajoutAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutAuteur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ajoutAuteur.Location = new System.Drawing.Point(420, 65);
            this.ajoutAuteur.Name = "ajoutAuteur";
            this.ajoutAuteur.Size = new System.Drawing.Size(108, 34);
            this.ajoutAuteur.TabIndex = 24;
            this.ajoutAuteur.Text = "Ajouter";
            this.ajoutAuteur.UseVisualStyleBackColor = false;
            this.ajoutAuteur.Click += new System.EventHandler(this.ajoutAuteur_Click);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(211, 129);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(160, 29);
            this.txtNum.TabIndex = 12;
            // 
            // txtDomicile
            // 
            this.txtDomicile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicile.Location = new System.Drawing.Point(211, 97);
            this.txtDomicile.Name = "txtDomicile";
            this.txtDomicile.Size = new System.Drawing.Size(160, 29);
            this.txtDomicile.TabIndex = 11;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(211, 57);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(160, 29);
            this.txtPrenom.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(211, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 29);
            this.txtName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numéro :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Domicile :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ajoutLivre);
            this.groupBox2.Controls.Add(this.txtNumLivre);
            this.groupBox2.Controls.Add(this.txtPrix);
            this.groupBox2.Controls.Add(this.txtTitre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Livre";
            // 
            // ajoutLivre
            // 
            this.ajoutLivre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ajoutLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutLivre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ajoutLivre.Location = new System.Drawing.Point(420, 64);
            this.ajoutLivre.Name = "ajoutLivre";
            this.ajoutLivre.Size = new System.Drawing.Size(108, 31);
            this.ajoutLivre.TabIndex = 25;
            this.ajoutLivre.Text = "Ajouter";
            this.ajoutLivre.UseVisualStyleBackColor = false;
            this.ajoutLivre.Click += new System.EventHandler(this.ajoutLivre_Click);
            // 
            // txtNumLivre
            // 
            this.txtNumLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumLivre.Location = new System.Drawing.Point(211, 98);
            this.txtNumLivre.Name = "txtNumLivre";
            this.txtNumLivre.Size = new System.Drawing.Size(160, 29);
            this.txtNumLivre.TabIndex = 19;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(211, 58);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(160, 29);
            this.txtPrix.TabIndex = 18;
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(211, 24);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(160, 29);
            this.txtTitre.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Numero :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prix :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Titre :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ajoutRelation);
            this.groupBox3.Controls.Add(this.txtAuteur);
            this.groupBox3.Controls.Add(this.txtTitreR);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 103);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relation";
            // 
            // ajoutRelation
            // 
            this.ajoutRelation.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ajoutRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutRelation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ajoutRelation.Location = new System.Drawing.Point(420, 34);
            this.ajoutRelation.Name = "ajoutRelation";
            this.ajoutRelation.Size = new System.Drawing.Size(108, 31);
            this.ajoutRelation.TabIndex = 26;
            this.ajoutRelation.Text = "Ajouter";
            this.ajoutRelation.UseVisualStyleBackColor = false;
            this.ajoutRelation.Click += new System.EventHandler(this.ajoutRelation_Click);
            // 
            // txtAuteur
            // 
            this.txtAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuteur.Location = new System.Drawing.Point(211, 58);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(160, 29);
            this.txtAuteur.TabIndex = 24;
            // 
            // txtTitreR
            // 
            this.txtTitreR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitreR.Location = new System.Drawing.Point(211, 23);
            this.txtTitreR.Name = "txtTitreR";
            this.txtTitreR.Size = new System.Drawing.Size(160, 29);
            this.txtTitreR.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(74, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nom Auteur :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(74, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Titre :";
            // 
            // listeAuteurs
            // 
            this.listeAuteurs.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listeAuteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeAuteurs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listeAuteurs.Location = new System.Drawing.Point(382, 455);
            this.listeAuteurs.Name = "listeAuteurs";
            this.listeAuteurs.Size = new System.Drawing.Size(221, 42);
            this.listeAuteurs.TabIndex = 31;
            this.listeAuteurs.Text = "Afficher la liste d\'auteurs";
            this.listeAuteurs.UseVisualStyleBackColor = false;
            this.listeAuteurs.Click += new System.EventHandler(this.listeAuteurs_Click);
            // 
            // listeLivres
            // 
            this.listeLivres.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listeLivres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeLivres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listeLivres.Location = new System.Drawing.Point(183, 455);
            this.listeLivres.Name = "listeLivres";
            this.listeLivres.Size = new System.Drawing.Size(199, 42);
            this.listeLivres.TabIndex = 30;
            this.listeLivres.Text = "Afficher liste des livres";
            this.listeLivres.UseVisualStyleBackColor = false;
            this.listeLivres.Click += new System.EventHandler(this.listeLivres_Click);
            // 
            // demenstration
            // 
            this.demenstration.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.demenstration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demenstration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.demenstration.Location = new System.Drawing.Point(12, 455);
            this.demenstration.Name = "demenstration";
            this.demenstration.Size = new System.Drawing.Size(165, 42);
            this.demenstration.TabIndex = 29;
            this.demenstration.Text = "Demenstration";
            this.demenstration.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 503);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(567, 120);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 635);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listeAuteurs);
            this.Controls.Add(this.listeLivres);
            this.Controls.Add(this.demenstration);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtDomicile;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button ajoutAuteur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumLivre;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Button ajoutLivre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.TextBox txtTitreR;
        private System.Windows.Forms.Button ajoutRelation;
        private System.Windows.Forms.Button listeAuteurs;
        private System.Windows.Forms.Button listeLivres;
        private System.Windows.Forms.Button demenstration;
        private System.Windows.Forms.ListView listView1;
        private EventHandler txtTitreR_TextChanged;
        private EventHandler txtName_TextChanged;
    }
}