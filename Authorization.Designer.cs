namespace gibdd_drivers
{
    partial class Authorization
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
            this.dB_DriversDataSet = new gibdd_drivers.DB_DriversDataSet();
            this.authorizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorizationTableAdapter = new gibdd_drivers.DB_DriversDataSetTableAdapters.AuthorizationTableAdapter();
            this.tableAdapterManager = new gibdd_drivers.DB_DriversDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DriversDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_DriversDataSet
            // 
            this.dB_DriversDataSet.DataSetName = "DB_DriversDataSet";
            this.dB_DriversDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorizationBindingSource
            // 
            this.authorizationBindingSource.DataMember = "Authorization";
            this.authorizationBindingSource.DataSource = this.dB_DriversDataSet;
            // 
            // authorizationTableAdapter
            // 
            this.authorizationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorizationTableAdapter = this.authorizationTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DriversLicenseTableAdapter = null;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gibdd_drivers.DB_DriversDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Перейти к водителям";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_DriversDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_DriversDataSet dB_DriversDataSet;
        private System.Windows.Forms.BindingSource authorizationBindingSource;
        private DB_DriversDataSetTableAdapters.AuthorizationTableAdapter authorizationTableAdapter;
        private DB_DriversDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}