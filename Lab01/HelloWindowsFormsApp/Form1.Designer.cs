namespace HelloWindowsFormsApp
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
            this.LabelImie = new System.Windows.Forms.Label();
            this.textBoximie = new System.Windows.Forms.TextBox();
            this.textBoxnazwisko = new System.Windows.Forms.TextBox();
            this.LabelNazwisko = new System.Windows.Forms.Label();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelKomunikat1 = new System.Windows.Forms.Label();
            this.labelKomunikat2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelImie
            // 
            this.LabelImie.AutoSize = true;
            this.LabelImie.BackColor = System.Drawing.SystemColors.Control;
            this.LabelImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelImie.ForeColor = System.Drawing.Color.White;
            this.LabelImie.Location = new System.Drawing.Point(47, 26);
            this.LabelImie.Name = "LabelImie";
            this.LabelImie.Size = new System.Drawing.Size(43, 20);
            this.LabelImie.TabIndex = 0;
            this.LabelImie.Text = "Imię:";
            this.LabelImie.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoximie
            // 
            this.textBoximie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoximie.ForeColor = System.Drawing.Color.White;
            this.textBoximie.Location = new System.Drawing.Point(116, 23);
            this.textBoximie.Name = "textBoximie";
            this.textBoximie.Size = new System.Drawing.Size(100, 26);
            this.textBoximie.TabIndex = 1;
            // 
            // textBoxnazwisko
            // 
            this.textBoxnazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxnazwisko.ForeColor = System.Drawing.Color.White;
            this.textBoxnazwisko.Location = new System.Drawing.Point(116, 58);
            this.textBoxnazwisko.Name = "textBoxnazwisko";
            this.textBoxnazwisko.Size = new System.Drawing.Size(100, 26);
            this.textBoxnazwisko.TabIndex = 3;
            this.textBoxnazwisko.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LabelNazwisko
            // 
            this.LabelNazwisko.AutoSize = true;
            this.LabelNazwisko.BackColor = System.Drawing.SystemColors.Control;
            this.LabelNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNazwisko.ForeColor = System.Drawing.Color.White;
            this.LabelNazwisko.Location = new System.Drawing.Point(14, 58);
            this.LabelNazwisko.Name = "LabelNazwisko";
            this.LabelNazwisko.Size = new System.Drawing.Size(80, 20);
            this.LabelNazwisko.TabIndex = 2;
            this.LabelNazwisko.Text = "Nazwisko:";
            this.LabelNazwisko.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWiek.ForeColor = System.Drawing.Color.White;
            this.textBoxWiek.Location = new System.Drawing.Point(116, 92);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(100, 26);
            this.textBoxWiek.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wiek:";
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOK.ForeColor = System.Drawing.Color.Green;
            this.buttonOK.Location = new System.Drawing.Point(99, 146);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(128, 34);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Sprawdź!";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelKomunikat1
            // 
            this.labelKomunikat1.AutoSize = true;
            this.labelKomunikat1.Location = new System.Drawing.Point(36, 236);
            this.labelKomunikat1.Name = "labelKomunikat1";
            this.labelKomunikat1.Size = new System.Drawing.Size(85, 13);
            this.labelKomunikat1.TabIndex = 7;
            this.labelKomunikat1.Text = "labelKomunikat1";
            this.labelKomunikat1.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelKomunikat2
            // 
            this.labelKomunikat2.AutoSize = true;
            this.labelKomunikat2.Location = new System.Drawing.Point(36, 273);
            this.labelKomunikat2.Name = "labelKomunikat2";
            this.labelKomunikat2.Size = new System.Drawing.Size(85, 13);
            this.labelKomunikat2.TabIndex = 8;
            this.labelKomunikat2.Text = "labelKomunikat2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKomunikat2);
            this.Controls.Add(this.labelKomunikat1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxnazwisko);
            this.Controls.Add(this.LabelNazwisko);
            this.Controls.Add(this.textBoximie);
            this.Controls.Add(this.LabelImie);
            this.Name = "Form1";
            this.Text = "Aplikacja okienkowa: Witaj";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelImie;
        private System.Windows.Forms.TextBox textBoximie;
        private System.Windows.Forms.TextBox textBoxnazwisko;
        private System.Windows.Forms.Label LabelNazwisko;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelKomunikat1;
        private System.Windows.Forms.Label labelKomunikat2;
    }
}

