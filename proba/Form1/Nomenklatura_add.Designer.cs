namespace proba
{
    partial class Nomenklatura_add
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.id_view_tools = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.id_supplier = new System.Windows.Forms.Label();
            this.data_manufacture = new System.Windows.Forms.Label();
            this.id_country = new System.Windows.Forms.Label();
            this.text_id_view_tools = new System.Windows.Forms.TextBox();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.text_description = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.text_id_supplier = new System.Windows.Forms.TextBox();
            this.text_data_manufacture = new System.Windows.Forms.TextBox();
            this.text_id_country = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progect_MPGG1DataSet1 = new proba.Progect_MPGG1DataSet1();
            this.progectMPGG1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewtoolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progectMPGG1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new proba.Progect_MPGG1DataSet1TableAdapters.CountryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progectMPGG1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtoolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progectMPGG1DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(111)))), ((int)(((byte)(14)))));
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.Font = new System.Drawing.Font("Freestyle Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(63, 391);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(111, 30);
            this.button_back.TabIndex = 11;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(111)))), ((int)(((byte)(14)))));
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.Font = new System.Drawing.Font("Freestyle Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_save.Location = new System.Drawing.Point(353, 390);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(111, 30);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_view_tools
            // 
            this.id_view_tools.AutoSize = true;
            this.id_view_tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_view_tools.Location = new System.Drawing.Point(48, 46);
            this.id_view_tools.Name = "id_view_tools";
            this.id_view_tools.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_view_tools.Size = new System.Drawing.Size(216, 24);
            this.id_view_tools.TabIndex = 13;
            this.id_view_tools.Text = "Код вида инструмента";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(48, 136);
            this.description.Name = "description";
            this.description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.description.Size = new System.Drawing.Size(100, 24);
            this.description.TabIndex = 13;
            this.description.Text = "Описание";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(48, 181);
            this.price.Name = "price";
            this.price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.price.Size = new System.Drawing.Size(54, 24);
            this.price.TabIndex = 13;
            this.price.Text = "Цена";
            // 
            // id_supplier
            // 
            this.id_supplier.AutoSize = true;
            this.id_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_supplier.Location = new System.Drawing.Point(48, 228);
            this.id_supplier.Name = "id_supplier";
            this.id_supplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_supplier.Size = new System.Drawing.Size(156, 24);
            this.id_supplier.TabIndex = 13;
            this.id_supplier.Text = "Код поставщика";
            // 
            // data_manufacture
            // 
            this.data_manufacture.AutoSize = true;
            this.data_manufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_manufacture.Location = new System.Drawing.Point(48, 273);
            this.data_manufacture.Name = "data_manufacture";
            this.data_manufacture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data_manufacture.Size = new System.Drawing.Size(142, 24);
            this.data_manufacture.TabIndex = 13;
            this.data_manufacture.Text = "Дата поставки";
            // 
            // id_country
            // 
            this.id_country.AutoSize = true;
            this.id_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_country.Location = new System.Drawing.Point(48, 318);
            this.id_country.Name = "id_country";
            this.id_country.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_country.Size = new System.Drawing.Size(209, 24);
            this.id_country.TabIndex = 13;
            this.id_country.Text = "Страна производства";
            // 
            // text_id_view_tools
            // 
            this.text_id_view_tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_id_view_tools.Location = new System.Drawing.Point(288, 46);
            this.text_id_view_tools.Name = "text_id_view_tools";
            this.text_id_view_tools.Size = new System.Drawing.Size(210, 29);
            this.text_id_view_tools.TabIndex = 14;
            // 
            // tex_name
            // 
            this.tex_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tex_name.Location = new System.Drawing.Point(288, 87);
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(210, 29);
            this.tex_name.TabIndex = 14;
            // 
            // text_description
            // 
            this.text_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_description.Location = new System.Drawing.Point(288, 133);
            this.text_description.Name = "text_description";
            this.text_description.Size = new System.Drawing.Size(210, 29);
            this.text_description.TabIndex = 14;
            // 
            // text_price
            // 
            this.text_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_price.Location = new System.Drawing.Point(288, 178);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(210, 29);
            this.text_price.TabIndex = 14;
            // 
            // text_id_supplier
            // 
            this.text_id_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_id_supplier.Location = new System.Drawing.Point(288, 223);
            this.text_id_supplier.Name = "text_id_supplier";
            this.text_id_supplier.Size = new System.Drawing.Size(210, 29);
            this.text_id_supplier.TabIndex = 14;
            // 
            // text_data_manufacture
            // 
            this.text_data_manufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_data_manufacture.Location = new System.Drawing.Point(288, 270);
            this.text_data_manufacture.Name = "text_data_manufacture";
            this.text_data_manufacture.Size = new System.Drawing.Size(210, 29);
            this.text_data_manufacture.TabIndex = 14;
            // 
            // text_id_country
            // 
            this.text_id_country.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.countryBindingSource, "id_country", true));
            this.text_id_country.DataSource = this.countryBindingSource;
            this.text_id_country.DisplayMember = "country";
            this.text_id_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_id_country.FormattingEnabled = true;
            this.text_id_country.Location = new System.Drawing.Point(288, 315);
            this.text_id_country.Name = "text_id_country";
            this.text_id_country.Size = new System.Drawing.Size(210, 32);
            this.text_id_country.TabIndex = 15;
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
            // viewtoolsBindingSource
            // 
            this.viewtoolsBindingSource.DataMember = "View_tools";
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // Nomenklatura_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(140)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.text_id_country);
            this.Controls.Add(this.text_data_manufacture);
            this.Controls.Add(this.text_id_supplier);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.text_description);
            this.Controls.Add(this.tex_name);
            this.Controls.Add(this.text_id_view_tools);
            this.Controls.Add(this.price);
            this.Controls.Add(this.id_supplier);
            this.Controls.Add(this.description);
            this.Controls.Add(this.id_country);
            this.Controls.Add(this.data_manufacture);
            this.Controls.Add(this.id_view_tools);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_back);
            this.Name = "Nomenklatura_add";
            this.Load += new System.EventHandler(this.Nomenklatura_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progectMPGG1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewtoolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progectMPGG1DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label id_view_tools;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label id_supplier;
        private System.Windows.Forms.Label data_manufacture;
        private System.Windows.Forms.Label id_country;
        private System.Windows.Forms.TextBox text_id_view_tools;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.TextBox text_description;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.TextBox text_id_supplier;
        private System.Windows.Forms.TextBox text_data_manufacture;
        private System.Windows.Forms.ComboBox text_id_country;
        private System.Windows.Forms.BindingSource progectMPGG1DataSetBindingSource;
        private System.Windows.Forms.BindingSource viewtoolsBindingSource;

        private System.Windows.Forms.BindingSource progectMPGG1DataSetBindingSource1;
        private Progect_MPGG1DataSet1 progect_MPGG1DataSet1;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private Progect_MPGG1DataSet1TableAdapters.CountryTableAdapter countryTableAdapter;
    }
}