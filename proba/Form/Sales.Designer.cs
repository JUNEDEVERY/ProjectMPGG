namespace proba
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextForSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.text_id_country = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progect_MPGG1DataSet1 = new proba.Progect_MPGG1DataSet1();
            this.text_id_view_tools = new System.Windows.Forms.ComboBox();
            this.viewtoolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progect_MPGG1DataSet3 = new proba.Progect_MPGG1DataSet3();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_price2 = new System.Windows.Forms.TextBox();
            this.text_price1 = new System.Windows.Forms.TextBox();
            this.text_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_buy = new System.Windows.Forms.Button();
            this.progectMPGG1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_toolsTableAdapter = new proba.Progect_MPGG1DataSet3TableAdapters.View_toolsTableAdapter();
            this.countryTableAdapter = new proba.Progect_MPGG1DataSet1TableAdapters.CountryTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtoolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progectMPGG1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(933, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "ПОИСК МУЗЫКАЛЬНОГО ИНСТРУМЕНТА";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Модуль поиска";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(844, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // TextForSearch
            // 
            this.TextForSearch.AutoSize = true;
            this.TextForSearch.Location = new System.Drawing.Point(370, 11);
            this.TextForSearch.Name = "TextForSearch";
            this.TextForSearch.Size = new System.Drawing.Size(125, 13);
            this.TextForSearch.TabIndex = 23;
            this.TextForSearch.Text = "Название инструмента";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.text_id_country);
            this.panel2.Controls.Add(this.text_id_view_tools);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.text_price2);
            this.panel2.Controls.Add(this.text_price1);
            this.panel2.Controls.Add(this.text_description);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.text_name);
            this.panel2.Controls.Add(this.TextForSearch);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(24, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 150);
            this.panel2.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Вид инструмента";
            // 
            // text_id_country
            // 
            this.text_id_country.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.countryBindingSource, "id_country", true));
            this.text_id_country.DataSource = this.countryBindingSource;
            this.text_id_country.DisplayMember = "country";
            this.text_id_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_id_country.FormattingEnabled = true;
            this.text_id_country.Location = new System.Drawing.Point(638, 27);
            this.text_id_country.Name = "text_id_country";
            this.text_id_country.Size = new System.Drawing.Size(181, 28);
            this.text_id_country.TabIndex = 39;
            this.text_id_country.ValueMember = "id_country";
            this.text_id_country.SelectedIndexChanged += new System.EventHandler(this.text_id_country_SelectedIndexChanged);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.progect_MPGG1DataSet1;
            // 
            // progect_MPGG1DataSet1
            // 
            this.progect_MPGG1DataSet1.DataSetName = "Progect_MPGG1DataSet1";
            this.progect_MPGG1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // text_id_view_tools
            // 
            this.text_id_view_tools.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viewtoolsBindingSource, "id_view_tools", true));
            this.text_id_view_tools.DataSource = this.viewtoolsBindingSource;
            this.text_id_view_tools.DisplayMember = "view_tools";
            this.text_id_view_tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_id_view_tools.FormattingEnabled = true;
            this.text_id_view_tools.Location = new System.Drawing.Point(32, 25);
            this.text_id_view_tools.Name = "text_id_view_tools";
            this.text_id_view_tools.Size = new System.Drawing.Size(198, 28);
            this.text_id_view_tools.TabIndex = 38;
            this.text_id_view_tools.ValueMember = "id_view_tools";
            this.text_id_view_tools.SelectedIndexChanged += new System.EventHandler(this.text_id_view_tools_SelectedIndexChanged);
            // 
            // viewtoolsBindingSource
            // 
            this.viewtoolsBindingSource.DataMember = "View_tools";
            this.viewtoolsBindingSource.DataSource = this.progect_MPGG1DataSet3;
            // 
            // progect_MPGG1DataSet3
            // 
            this.progect_MPGG1DataSet3.DataSetName = "Progect_MPGG1DataSet3";
            this.progect_MPGG1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(676, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Страна производства";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "До";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "От";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Цена";
            // 
            // text_price2
            // 
            this.text_price2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_price2.Location = new System.Drawing.Point(619, 109);
            this.text_price2.Name = "text_price2";
            this.text_price2.Size = new System.Drawing.Size(140, 26);
            this.text_price2.TabIndex = 31;
            this.text_price2.TextChanged += new System.EventHandler(this.text_price2_TextChanged);
            // 
            // text_price1
            // 
            this.text_price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_price1.Location = new System.Drawing.Point(461, 109);
            this.text_price1.Name = "text_price1";
            this.text_price1.Size = new System.Drawing.Size(140, 26);
            this.text_price1.TabIndex = 30;
            this.text_price1.TextChanged += new System.EventHandler(this.text_price1_TextChanged);
            // 
            // text_description
            // 
            this.text_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_description.Location = new System.Drawing.Point(22, 74);
            this.text_description.Multiline = true;
            this.text_description.Name = "text_description";
            this.text_description.Size = new System.Drawing.Size(320, 70);
            this.text_description.TabIndex = 29;
            this.text_description.TextChanged += new System.EventHandler(this.text_description_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Описание";
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_name.Location = new System.Drawing.Point(318, 27);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(242, 26);
            this.text_name.TabIndex = 26;
            this.text_name.TextChanged += new System.EventHandler(this.text_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Данные заполняются последовательно слева на право!!!";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(111)))), ((int)(((byte)(14)))));
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.Font = new System.Drawing.Font("Freestyle Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(34, 420);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(111, 30);
            this.button_back.TabIndex = 28;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click_1);
            // 
            // button_buy
            // 
            this.button_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(111)))), ((int)(((byte)(14)))));
            this.button_buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_buy.Font = new System.Drawing.Font("Freestyle Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_buy.Location = new System.Drawing.Point(772, 418);
            this.button_buy.Name = "button_buy";
            this.button_buy.Size = new System.Drawing.Size(111, 30);
            this.button_buy.TabIndex = 29;
            this.button_buy.Text = "Приобрести";
            this.button_buy.UseVisualStyleBackColor = false;
            this.button_buy.Click += new System.EventHandler(this.button_buy_Click);
            // 
            // progectMPGG1DataSet1BindingSource
            // 
            this.progectMPGG1DataSet1BindingSource.DataSource = this.progect_MPGG1DataSet1;
            this.progectMPGG1DataSet1BindingSource.Position = 0;
            // 
            // view_toolsTableAdapter
            // 
            this.view_toolsTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(852, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(140)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(933, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_buy);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск музыкального инструмента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.global_FormClosed);
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtoolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progectMPGG1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TextForSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_description;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_buy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_price2;
        private System.Windows.Forms.TextBox text_price1;
        private System.Windows.Forms.ComboBox text_id_view_tools;
        private System.Windows.Forms.BindingSource progectMPGG1DataSet1BindingSource;
        private Progect_MPGG1DataSet1 progect_MPGG1DataSet1;
        private Progect_MPGG1DataSet3 progect_MPGG1DataSet3;
        private System.Windows.Forms.BindingSource viewtoolsBindingSource;
        private Progect_MPGG1DataSet3TableAdapters.View_toolsTableAdapter view_toolsTableAdapter;
        private System.Windows.Forms.ComboBox text_id_country;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private Progect_MPGG1DataSet1TableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
    }
}