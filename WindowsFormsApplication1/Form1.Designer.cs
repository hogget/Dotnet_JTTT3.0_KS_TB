using System.ComponentModel;

namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Klucz = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Adres_strony = new System.Windows.Forms.TextBox();
            this.lista_zadan = new System.Windows.Forms.ListBox();
            this.nazwaBox = new System.Windows.Forms.TextBox();
            this.Nazwa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Klucz
            // 
            this.Klucz.Location = new System.Drawing.Point(78, 122);
            this.Klucz.Name = "Klucz";
            this.Klucz.Size = new System.Drawing.Size(118, 20);
            this.Klucz.TabIndex = 1;
            this.Klucz.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(324, 151);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(79, 30);
            this.start.TabIndex = 2;
            this.start.Text = "Wykonaj!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.WykonajZadaniaZListy);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(78, 37);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(118, 20);
            this.Email.TabIndex = 3;
            this.Email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.Location = new System.Drawing.Point(29, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj_lista";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.start_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Deserialize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Deserialize);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 22);
            this.button3.TabIndex = 7;
            this.button3.Text = "Serialize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Serialize);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(409, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Czyść";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.WyczyscListe);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "AdresStrony";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Klucz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Adres_strony
            // 
            this.Adres_strony.Location = new System.Drawing.Point(78, 83);
            this.Adres_strony.Name = "Adres_strony";
            this.Adres_strony.Size = new System.Drawing.Size(118, 20);
            this.Adres_strony.TabIndex = 12;
            this.Adres_strony.TextChanged += new System.EventHandler(this.Adres_strony_TextChanged);
            // 
            // lista_zadan
            // 
            this.lista_zadan.FormattingEnabled = true;
            this.lista_zadan.Location = new System.Drawing.Point(324, 34);
            this.lista_zadan.Name = "lista_zadan";
            this.lista_zadan.Size = new System.Drawing.Size(292, 95);
            this.lista_zadan.TabIndex = 13;
            this.lista_zadan.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // nazwaBox
            // 
            this.nazwaBox.Location = new System.Drawing.Point(78, 168);
            this.nazwaBox.Name = "nazwaBox";
            this.nazwaBox.Size = new System.Drawing.Size(117, 20);
            this.nazwaBox.TabIndex = 14;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSize = true;
            this.Nazwa.Location = new System.Drawing.Point(78, 149);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(40, 13);
            this.Nazwa.TabIndex = 15;
            this.Nazwa.Text = "Nazwa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 244);
            this.Controls.Add(this.Nazwa);
            this.Controls.Add(this.nazwaBox);
            this.Controls.Add(this.lista_zadan);
            this.Controls.Add(this.Adres_strony);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Klucz);
            this.Name = "Form1";
            this.Text = "JTTT 3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Klucz;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adres_strony;
        private System.Windows.Forms.ListBox lista_zadan;
        private System.Windows.Forms.TextBox nazwaBox;
        private System.Windows.Forms.Label Nazwa;
    }
}

