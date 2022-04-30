namespace proba
{
    partial class Prodaja_update
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_data = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.ComboBox();
            this.toolsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.text_surname = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progect_MPGG1DataSet8 = new proba.Progect_MPGG1DataSet8();
            this.employeeTableAdapter = new proba.Progect_MPGG1DataSet8TableAdapters.EmployeeTableAdapter();
            this.progect_MPGG1DataSet7 = new proba.Progect_MPGG1DataSet7();
            this.toolsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolsTableAdapter = new proba.Progect_MPGG1DataSet7TableAdapters.ToolsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Название инструмента";
            // 
            // text_data
            // 
            this.text_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_data.Location = new System.Drawing.Point(302, 97);
            this.text_data.Name = "text_data";
            this.text_data.Size = new System.Drawing.Size(210, 26);
            this.text_data.TabIndex = 34;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(51, 95);
            this.price.Name = "price";
            this.price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.price.Size = new System.Drawing.Size(139, 24);
            this.price.TabIndex = 33;
            this.price.Text = "Дата продажи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 152);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Сумма";
            // 
            // text_price
            // 
            this.text_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_price.Location = new System.Drawing.Point(302, 152);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(210, 26);
            this.text_price.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 214);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Фамилия сотрудника";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(111)))), ((int)(((byte)(14)))));
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.Font = new System.Drawing.Font("Freestyle Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_update.Location = new System.Drawing.Point(366, 287);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(111, 30);
            this.button_update.TabIndex = 42;
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
            this.button_back.Location = new System.Drawing.Point(76, 288);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(111, 30);
            this.button_back.TabIndex = 41;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // text_name
            // 
            this.text_name.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.toolsBindingSource2, "id_tool", true));
            this.text_name.DataSource = this.toolsBindingSource2;
            this.text_name.DisplayMember = "name";
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_name.FormattingEnabled = true;
            this.text_name.Location = new System.Drawing.Point(302, 41);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(210, 28);
            this.text_name.TabIndex = 43;
            this.text_name.ValueMember = "id_tool";
            // 
            // toolsBindingSource1
            // 
            this.toolsBindingSource1.DataMember = "Tools";
            // 
            // toolsBindingSource
            // 
            this.toolsBindingSource.DataMember = "Tools";
            // 
            // text_surname
            // 
            this.text_surname.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "id_employee", true));
            this.text_surname.DataSource = this.employeeBindingSource;
            this.text_surname.DisplayMember = "surname";
            this.text_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_surname.FormattingEnabled = true;
            this.text_surname.Location = new System.Drawing.Point(302, 210);
            this.text_surname.Name = "text_surname";
            this.text_surname.Size = new System.Drawing.Size(210, 28);
            this.text_surname.TabIndex = 44;
            this.text_surname.ValueMember = "id_employee";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.progect_MPGG1DataSet8;
            // 
            // progect_MPGG1DataSet8
            // 
            this.progect_MPGG1DataSet8.DataSetName = "Progect_MPGG1DataSet8";
            this.progect_MPGG1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // progect_MPGG1DataSet7
            // 
            this.progect_MPGG1DataSet7.DataSetName = "Progect_MPGG1DataSet7";
            this.progect_MPGG1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolsBindingSource2
            // 
            this.toolsBindingSource2.DataMember = "Tools";
            this.toolsBindingSource2.DataSource = this.progect_MPGG1DataSet7;
            // 
            // toolsTableAdapter
            // 
            this.toolsTableAdapter.ClearBeforeFill = true;
            // 
            // Prodaja_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(140)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(560, 336);
            this.Controls.Add(this.text_surname);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_data);
            this.Controls.Add(this.price);
            this.Name = "Prodaja_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа изменение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.global_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progect_MPGG1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_data;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ComboBox text_name;
        private System.Windows.Forms.BindingSource toolsBindingSource;
        private System.Windows.Forms.ComboBox text_surname;
        private Progect_MPGG1DataSet8 progect_MPGG1DataSet8;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Progect_MPGG1DataSet8TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource toolsBindingSource1;
        private Progect_MPGG1DataSet7 progect_MPGG1DataSet7;
        private System.Windows.Forms.BindingSource toolsBindingSource2;
        private Progect_MPGG1DataSet7TableAdapters.ToolsTableAdapter toolsTableAdapter;
    }
}