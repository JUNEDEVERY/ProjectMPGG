namespace proba
{
    partial class PosleRegistracii
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_id_pol = new System.Windows.Forms.ComboBox();
            this.polBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progect_MPGG1DataSet6 = new proba.Progect_MPGG1DataSet6();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.date_of_birth = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PoleReg1 = new System.Windows.Forms.TextBox();
            this.PoleReg3 = new System.Windows.Forms.TextBox();
            this.PoleReg2 = new System.Windows.Forms.TextBox();
            this.polTableAdapter = new proba.Progect_MPGG1DataSet6TableAdapters.PolTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(140)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.text_id_pol);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.surname);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.date_of_birth);
            this.panel1.Controls.Add(this.patronymic);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.PoleReg1);
            this.panel1.Controls.Add(this.PoleReg3);
            this.panel1.Controls.Add(this.PoleReg2);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 440);
            this.panel1.TabIndex = 2;
            // 
            // text_id_pol
            // 
            this.text_id_pol.DataSource = this.polBindingSource;
            this.text_id_pol.DisplayMember = "pol";
            this.text_id_pol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_id_pol.FormattingEnabled = true;
            this.text_id_pol.Location = new System.Drawing.Point(496, 18);
            this.text_id_pol.Name = "text_id_pol";
            this.text_id_pol.Size = new System.Drawing.Size(210, 28);
            this.text_id_pol.TabIndex = 37;
            // 
            // polBindingSource
            // 
            this.polBindingSource.DataMember = "Pol";
            this.polBindingSource.DataSource = this.progect_MPGG1DataSet6;
            // 
            // progect_MPGG1DataSet6
            // 
            this.progect_MPGG1DataSet6.DataSetName = "Progect_MPGG1DataSet6";
            this.progect_MPGG1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(379, 129);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(379, 70);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(379, 18);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 129);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Фамилия";
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.surname.Location = new System.Drawing.Point(122, 15);
            this.surname.MaxLength = 15;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(231, 26);
            this.surname.TabIndex = 30;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(122, 70);
            this.name.MaxLength = 15;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(231, 26);
            this.name.TabIndex = 29;
            // 
            // date_of_birth
            // 
            this.date_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.date_of_birth.Location = new System.Drawing.Point(535, 70);
            this.date_of_birth.MaxLength = 10;
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.ShortcutsEnabled = false;
            this.date_of_birth.Size = new System.Drawing.Size(171, 26);
            this.date_of_birth.TabIndex = 28;
            this.date_of_birth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date_of_birth_KeyPress);
            // 
            // patronymic
            // 
            this.patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.patronymic.Location = new System.Drawing.Point(122, 129);
            this.patronymic.MaxLength = 15;
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(231, 26);
            this.patronymic.TabIndex = 27;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phone.Location = new System.Drawing.Point(475, 126);
            this.phone.MaxLength = 11;
            this.phone.Name = "phone";
            this.phone.ShortcutsEnabled = false;
            this.phone.Size = new System.Drawing.Size(231, 26);
            this.phone.TabIndex = 26;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 189);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Придумайте логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 242);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Придумайте пароль";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(15, 301);
            this.description.Name = "description";
            this.description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.description.Size = new System.Drawing.Size(202, 24);
            this.description.TabIndex = 22;
            this.description.Text = "Подтвердите пароль";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(111)))), ((int)(((byte)(14)))));
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.Font = new System.Drawing.Font("Freestyle Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(126, 370);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(91, 30);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "НАЗАД";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(111)))), ((int)(((byte)(14)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Freestyle Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(416, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PoleReg1
            // 
            this.PoleReg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PoleReg1.Location = new System.Drawing.Point(219, 189);
            this.PoleReg1.MaxLength = 15;
            this.PoleReg1.Name = "PoleReg1";
            this.PoleReg1.ShortcutsEnabled = false;
            this.PoleReg1.Size = new System.Drawing.Size(231, 26);
            this.PoleReg1.TabIndex = 3;
            this.PoleReg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PoleReg1_KeyPress);
            // 
            // PoleReg3
            // 
            this.PoleReg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PoleReg3.Location = new System.Drawing.Point(219, 301);
            this.PoleReg3.MaxLength = 25;
            this.PoleReg3.Name = "PoleReg3";
            this.PoleReg3.ShortcutsEnabled = false;
            this.PoleReg3.Size = new System.Drawing.Size(231, 26);
            this.PoleReg3.TabIndex = 2;
            this.PoleReg3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PoleReg3_KeyPress);
            // 
            // PoleReg2
            // 
            this.PoleReg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PoleReg2.Location = new System.Drawing.Point(219, 242);
            this.PoleReg2.MaxLength = 25;
            this.PoleReg2.Name = "PoleReg2";
            this.PoleReg2.ShortcutsEnabled = false;
            this.PoleReg2.Size = new System.Drawing.Size(231, 26);
            this.PoleReg2.TabIndex = 2;
            this.PoleReg2.Tag = "";
            this.PoleReg2.UseSystemPasswordChar = true;
            this.PoleReg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PoleReg2_KeyPress);
            // 
            // polTableAdapter
            // 
            this.polTableAdapter.ClearBeforeFill = true;
            // 
            // PosleRegistracii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 431);
            this.Controls.Add(this.panel1);
            this.Name = "PosleRegistracii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.global_FormClosed);
            this.Load += new System.EventHandler(this.PosleRegistracii_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PoleReg1;
        private System.Windows.Forms.TextBox PoleReg2;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox PoleReg3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox date_of_birth;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox text_id_pol;
        private Progect_MPGG1DataSet6 progect_MPGG1DataSet6;
        private System.Windows.Forms.BindingSource polBindingSource;
        private Progect_MPGG1DataSet6TableAdapters.PolTableAdapter polTableAdapter;
    }
}