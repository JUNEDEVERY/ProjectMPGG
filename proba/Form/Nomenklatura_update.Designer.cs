namespace proba
{
    partial class Nomenklatura_update
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
            this.text_id_view_tools = new System.Windows.Forms.ComboBox();
            this.viewtoolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progect_MPGG1DataSet3 = new proba.Progect_MPGG1DataSet3();
            this.text_id_suplier = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.progect_MPGG1DataSet = new proba.Progect_MPGG1DataSet();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progect_MPGG1DataSet4 = new proba.Progect_MPGG1DataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.text_id_country = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progect_MPGG1DataSet5 = new proba.Progect_MPGG1DataSet5();
            this.text_data_manufacture = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.id_supplier = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.id_country = new System.Windows.Forms.Label();
            this.data_manufacture = new System.Windows.Forms.Label();
            this.id_view_tools = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.view_toolsTableAdapter = new proba.Progect_MPGG1DataSet3TableAdapters.View_toolsTableAdapter();
            this.supplierTableAdapter = new proba.Progect_MPGG1DataSet4TableAdapters.SupplierTableAdapter();
            this.countryTableAdapter = new proba.Progect_MPGG1DataSet5TableAdapters.CountryTableAdapter();
            this.text_description = new System.Windows.Forms.TextBox();
            this.supplierTableAdapter1 = new proba.Progect_MPGG1DataSetTableAdapters.SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewtoolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // text_id_view_tools
            // 
            this.text_id_view_tools.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viewtoolsBindingSource, "id_view_tools", true));
            this.text_id_view_tools.DataSource = this.viewtoolsBindingSource;
            this.text_id_view_tools.DisplayMember = "view_tools";
            this.text_id_view_tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_id_view_tools.FormattingEnabled = true;
            this.text_id_view_tools.Location = new System.Drawing.Point(303, 26);
            this.text_id_view_tools.Name = "text_id_view_tools";
            this.text_id_view_tools.Size = new System.Drawing.Size(210, 28);
            this.text_id_view_tools.TabIndex = 34;
            this.text_id_view_tools.ValueMember = "id_view_tools";
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
            // text_id_suplier
            // 
            this.text_id_suplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierBindingSource1, "id_supplier", true));
            this.text_id_suplier.DataSource = this.supplierBindingSource1;
            this.text_id_suplier.DisplayMember = "name_organization";
            this.text_id_suplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_id_suplier.FormattingEnabled = true;
            this.text_id_suplier.Location = new System.Drawing.Point(303, 240);
            this.text_id_suplier.Name = "text_id_suplier";
            this.text_id_suplier.Size = new System.Drawing.Size(210, 28);
            this.text_id_suplier.TabIndex = 33;
            this.text_id_suplier.ValueMember = "id_supplier";
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "Supplier";
            this.supplierBindingSource1.DataSource = this.progect_MPGG1DataSet;
            // 
            // progect_MPGG1DataSet
            // 
            this.progect_MPGG1DataSet.DataSetName = "Progect_MPGG1DataSet";
            this.progect_MPGG1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.progect_MPGG1DataSet4;
            // 
            // progect_MPGG1DataSet4
            // 
            this.progect_MPGG1DataSet4.DataSetName = "Progect_MPGG1DataSet4";
            this.progect_MPGG1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 72);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Наименование";
            // 
            // text_id_country
            // 
            this.text_id_country.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.countryBindingSource, "id_country", true));
            this.text_id_country.DataSource = this.countryBindingSource;
            this.text_id_country.DisplayMember = "country";
            this.text_id_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_id_country.FormattingEnabled = true;
            this.text_id_country.Location = new System.Drawing.Point(303, 334);
            this.text_id_country.Name = "text_id_country";
            this.text_id_country.Size = new System.Drawing.Size(210, 28);
            this.text_id_country.TabIndex = 31;
            this.text_id_country.ValueMember = "id_country";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.progect_MPGG1DataSet5;
            // 
            // progect_MPGG1DataSet5
            // 
            this.progect_MPGG1DataSet5.DataSetName = "Progect_MPGG1DataSet5";
            this.progect_MPGG1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // text_data_manufacture
            // 
            this.text_data_manufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_data_manufacture.Location = new System.Drawing.Point(303, 289);
            this.text_data_manufacture.Name = "text_data_manufacture";
            this.text_data_manufacture.Size = new System.Drawing.Size(210, 26);
            this.text_data_manufacture.TabIndex = 27;
            // 
            // text_price
            // 
            this.text_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_price.Location = new System.Drawing.Point(303, 197);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(210, 26);
            this.text_price.TabIndex = 28;
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_name.Location = new System.Drawing.Point(303, 69);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(210, 26);
            this.text_name.TabIndex = 30;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(63, 200);
            this.price.Name = "price";
            this.price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.price.Size = new System.Drawing.Size(54, 24);
            this.price.TabIndex = 21;
            this.price.Text = "Цена";
            // 
            // id_supplier
            // 
            this.id_supplier.AutoSize = true;
            this.id_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_supplier.Location = new System.Drawing.Point(63, 247);
            this.id_supplier.Name = "id_supplier";
            this.id_supplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_supplier.Size = new System.Drawing.Size(108, 24);
            this.id_supplier.TabIndex = 22;
            this.id_supplier.Text = "Поставщик";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(63, 114);
            this.description.Name = "description";
            this.description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.description.Size = new System.Drawing.Size(100, 24);
            this.description.TabIndex = 23;
            this.description.Text = "Описание";
            // 
            // id_country
            // 
            this.id_country.AutoSize = true;
            this.id_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_country.Location = new System.Drawing.Point(63, 337);
            this.id_country.Name = "id_country";
            this.id_country.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_country.Size = new System.Drawing.Size(209, 24);
            this.id_country.TabIndex = 24;
            this.id_country.Text = "Страна производства";
            // 
            // data_manufacture
            // 
            this.data_manufacture.AutoSize = true;
            this.data_manufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_manufacture.Location = new System.Drawing.Point(63, 292);
            this.data_manufacture.Name = "data_manufacture";
            this.data_manufacture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data_manufacture.Size = new System.Drawing.Size(142, 24);
            this.data_manufacture.TabIndex = 25;
            this.data_manufacture.Text = "Дата поставки";
            // 
            // id_view_tools
            // 
            this.id_view_tools.AutoSize = true;
            this.id_view_tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_view_tools.Location = new System.Drawing.Point(63, 26);
            this.id_view_tools.Name = "id_view_tools";
            this.id_view_tools.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_view_tools.Size = new System.Drawing.Size(167, 24);
            this.id_view_tools.TabIndex = 26;
            this.id_view_tools.Text = "Вид инструмента";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(111)))), ((int)(((byte)(14)))));
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.Font = new System.Drawing.Font("Freestyle Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_update.Location = new System.Drawing.Point(368, 393);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(111, 30);
            this.button_update.TabIndex = 20;
            this.button_update.Text = "Изменить";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(111)))), ((int)(((byte)(14)))));
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.Font = new System.Drawing.Font("Freestyle Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(78, 394);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(111, 30);
            this.button_back.TabIndex = 19;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // view_toolsTableAdapter
            // 
            this.view_toolsTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // text_description
            // 
            this.text_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_description.Location = new System.Drawing.Point(193, 114);
            this.text_description.Multiline = true;
            this.text_description.Name = "text_description";
            this.text_description.Size = new System.Drawing.Size(320, 70);
            this.text_description.TabIndex = 35;
            // 
            // supplierTableAdapter1
            // 
            this.supplierTableAdapter1.ClearBeforeFill = true;
            // 
            // Nomenklatura_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(140)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.text_description);
            this.Controls.Add(this.text_id_view_tools);
            this.Controls.Add(this.text_id_suplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_id_country);
            this.Controls.Add(this.text_data_manufacture);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.price);
            this.Controls.Add(this.id_supplier);
            this.Controls.Add(this.description);
            this.Controls.Add(this.id_country);
            this.Controls.Add(this.data_manufacture);
            this.Controls.Add(this.id_view_tools);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_back);
            this.Name = "Nomenklatura_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение номенклатуры";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.global_FormClosed);
            this.Load += new System.EventHandler(this.Nomenklatura_update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewtoolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox text_id_view_tools;
        private System.Windows.Forms.ComboBox text_id_suplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox text_id_country;
        private System.Windows.Forms.TextBox text_data_manufacture;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label id_supplier;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label id_country;
        private System.Windows.Forms.Label data_manufacture;
        private System.Windows.Forms.Label id_view_tools;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_back;
        private Progect_MPGG1DataSet3 progect_MPGG1DataSet3;
        private System.Windows.Forms.BindingSource viewtoolsBindingSource;
        private Progect_MPGG1DataSet3TableAdapters.View_toolsTableAdapter view_toolsTableAdapter;
        private Progect_MPGG1DataSet4 progect_MPGG1DataSet4;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Progect_MPGG1DataSet4TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private Progect_MPGG1DataSet5 progect_MPGG1DataSet5;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private Progect_MPGG1DataSet5TableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.TextBox text_description;
        private Progect_MPGG1DataSet progect_MPGG1DataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private Progect_MPGG1DataSetTableAdapters.SupplierTableAdapter supplierTableAdapter1;
    }
}