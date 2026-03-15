namespace ApkaMail
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
            Usun = new Button();
            Zatwierdz = new Button();
            Lista = new ListView();
            Emailpis = new TextBox();
            Haslopis = new TextBox();
            Nazwapis = new TextBox();
            Email = new Label();
            Imie = new Label();
            Haslo = new Label();
            Regulamin = new CheckBox();
            Cookies = new CheckBox();
            SuspendLayout();
            // 
            // Usun
            // 
            Usun.Location = new Point(632, 415);
            Usun.Name = "Usun";
            Usun.Size = new Size(75, 23);
            Usun.TabIndex = 0;
            Usun.Text = "Usun";
            Usun.UseVisualStyleBackColor = true;
            // 
            // Zatwierdz
            // 
            Zatwierdz.Location = new Point(228, 368);
            Zatwierdz.Name = "Zatwierdz";
            Zatwierdz.Size = new Size(75, 23);
            Zatwierdz.TabIndex = 1;
            Zatwierdz.Text = "Zatwierdz";
            Zatwierdz.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            Lista.Location = new Point(545, 12);
            Lista.Name = "Lista";
            Lista.Size = new Size(243, 397);
            Lista.TabIndex = 2;
            Lista.UseCompatibleStateImageBehavior = false;
            // 
            // Emailpis
            // 
            Emailpis.Location = new Point(150, 70);
            Emailpis.Name = "Emailpis";
            Emailpis.Size = new Size(231, 23);
            Emailpis.TabIndex = 3;
            Emailpis.TextChanged += textBox1_TextChanged;
            // 
            // Haslopis
            // 
            Haslopis.Location = new Point(150, 270);
            Haslopis.Name = "Haslopis";
            Haslopis.Size = new Size(231, 23);
            Haslopis.TabIndex = 4;
            // 
            // Nazwapis
            // 
            Nazwapis.Location = new Point(150, 168);
            Nazwapis.Name = "Nazwapis";
            Nazwapis.Size = new Size(231, 23);
            Nazwapis.TabIndex = 5;
            Nazwapis.TextChanged += textBox3_TextChanged;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(228, 52);
            Email.Name = "Email";
            Email.Size = new Size(69, 15);
            Email.TabIndex = 6;
            Email.Text = "Podaj Email";
            Email.Click += label1_Click;
            // 
            // Imie
            // 
            Imie.AutoSize = true;
            Imie.Location = new Point(228, 150);
            Imie.Name = "Imie";
            Imie.Size = new Size(63, 15);
            Imie.TabIndex = 7;
            Imie.Text = "Podaj imie";
            // 
            // Haslo
            // 
            Haslo.AutoSize = true;
            Haslo.Location = new Point(228, 252);
            Haslo.Name = "Haslo";
            Haslo.Size = new Size(68, 15);
            Haslo.TabIndex = 8;
            Haslo.Text = "Podaj haslo";
            Haslo.Click += label2_Click;
            // 
            // Regulamin
            // 
            Regulamin.AutoSize = true;
            Regulamin.Location = new Point(150, 311);
            Regulamin.Name = "Regulamin";
            Regulamin.Size = new Size(136, 19);
            Regulamin.TabIndex = 9;
            Regulamin.Text = "Akceptuje regulamin";
            Regulamin.UseVisualStyleBackColor = true;
            // 
            // Cookies
            // 
            Cookies.AutoSize = true;
            Cookies.Location = new Point(150, 336);
            Cookies.Name = "Cookies";
            Cookies.Size = new Size(149, 19);
            Cookies.TabIndex = 10;
            Cookies.Text = "Akceptuje pliki Cookies";
            Cookies.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cookies);
            Controls.Add(Regulamin);
            Controls.Add(Haslo);
            Controls.Add(Imie);
            Controls.Add(Email);
            Controls.Add(Nazwapis);
            Controls.Add(Haslopis);
            Controls.Add(Emailpis);
            Controls.Add(Lista);
            Controls.Add(Zatwierdz);
            Controls.Add(Usun);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Usun;
        private Button Zatwierdz;
        private ListView Lista;
        private TextBox Emailpis;
        private TextBox Haslopis;
        private TextBox Nazwapis;
        private Label Email;
        private Label Imie;
        private Label Haslo;
        private CheckBox Regulamin;
        private CheckBox Cookies;
    }
}
