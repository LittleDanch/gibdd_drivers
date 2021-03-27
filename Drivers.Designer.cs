namespace gibdd_drivers
{
    partial class Drivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drivers));
            System.Windows.Forms.Label gUIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label passportLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label registrationAddressLabel;
            System.Windows.Forms.Label residentialAddressLabel;
            System.Windows.Forms.Label placeOfWorkLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label mobilePhoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label commentsLabel;
            this.dB_DriversDataSet = new gibdd_drivers.DB_DriversDataSet();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new gibdd_drivers.DB_DriversDataSetTableAdapters.DriverTableAdapter();
            this.tableAdapterManager = new gibdd_drivers.DB_DriversDataSetTableAdapters.TableAdapterManager();
            this.driverBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.driverBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gUIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.registrationAddressTextBox = new System.Windows.Forms.TextBox();
            this.residentialAddressTextBox = new System.Windows.Forms.TextBox();
            this.placeOfWorkTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.mobilePhoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            gUIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            registrationAddressLabel = new System.Windows.Forms.Label();
            residentialAddressLabel = new System.Windows.Forms.Label();
            placeOfWorkLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            mobilePhoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DriversDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingNavigator)).BeginInit();
            this.driverBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dB_DriversDataSet
            // 
            this.dB_DriversDataSet.DataSetName = "DB_DriversDataSet";
            this.dB_DriversDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.dB_DriversDataSet;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorizationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DriversLicenseTableAdapter = null;
            this.tableAdapterManager.DriverTableAdapter = this.driverTableAdapter;
            this.tableAdapterManager.UpdateOrder = gibdd_drivers.DB_DriversDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // driverBindingNavigator
            // 
            this.driverBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.driverBindingNavigator.BindingSource = this.driverBindingSource;
            this.driverBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.driverBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.driverBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.driverBindingNavigatorSaveItem});
            this.driverBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.driverBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.driverBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.driverBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.driverBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.driverBindingNavigator.Name = "driverBindingNavigator";
            this.driverBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.driverBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.driverBindingNavigator.TabIndex = 0;
            this.driverBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // driverBindingNavigatorSaveItem
            // 
            this.driverBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("driverBindingNavigatorSaveItem.Image")));
            this.driverBindingNavigatorSaveItem.Name = "driverBindingNavigatorSaveItem";
            this.driverBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.driverBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.driverBindingNavigatorSaveItem.Click += new System.EventHandler(this.driverBindingNavigatorSaveItem_Click);
            // 
            // gUIDLabel
            // 
            gUIDLabel.AutoSize = true;
            gUIDLabel.Location = new System.Drawing.Point(80, 70);
            gUIDLabel.Name = "gUIDLabel";
            gUIDLabel.Size = new System.Drawing.Size(37, 13);
            gUIDLabel.TabIndex = 1;
            gUIDLabel.Text = "GUID:";
            // 
            // gUIDTextBox
            // 
            this.gUIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "GUID", true));
            this.gUIDTextBox.Location = new System.Drawing.Point(193, 67);
            this.gUIDTextBox.Name = "gUIDTextBox";
            this.gUIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.gUIDTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(80, 96);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(193, 93);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(80, 122);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(193, 119);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 6;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(80, 148);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(72, 13);
            middleNameLabel.TabIndex = 7;
            middleNameLabel.Text = "Middle Name:";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(193, 145);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 8;
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(80, 174);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(51, 13);
            passportLabel.TabIndex = 9;
            passportLabel.Text = "Passport:";
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(193, 171);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(100, 20);
            this.passportTextBox.TabIndex = 10;
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(80, 200);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(55, 13);
            postcodeLabel.TabIndex = 11;
            postcodeLabel.Text = "Postcode:";
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(193, 197);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postcodeTextBox.TabIndex = 12;
            // 
            // registrationAddressLabel
            // 
            registrationAddressLabel.AutoSize = true;
            registrationAddressLabel.Location = new System.Drawing.Point(80, 226);
            registrationAddressLabel.Name = "registrationAddressLabel";
            registrationAddressLabel.Size = new System.Drawing.Size(107, 13);
            registrationAddressLabel.TabIndex = 13;
            registrationAddressLabel.Text = "Registration Address:";
            // 
            // registrationAddressTextBox
            // 
            this.registrationAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "RegistrationAddress", true));
            this.registrationAddressTextBox.Location = new System.Drawing.Point(193, 223);
            this.registrationAddressTextBox.Name = "registrationAddressTextBox";
            this.registrationAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.registrationAddressTextBox.TabIndex = 14;
            // 
            // residentialAddressLabel
            // 
            residentialAddressLabel.AutoSize = true;
            residentialAddressLabel.Location = new System.Drawing.Point(80, 252);
            residentialAddressLabel.Name = "residentialAddressLabel";
            residentialAddressLabel.Size = new System.Drawing.Size(103, 13);
            residentialAddressLabel.TabIndex = 15;
            residentialAddressLabel.Text = "Residential Address:";
            // 
            // residentialAddressTextBox
            // 
            this.residentialAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "ResidentialAddress", true));
            this.residentialAddressTextBox.Location = new System.Drawing.Point(193, 249);
            this.residentialAddressTextBox.Name = "residentialAddressTextBox";
            this.residentialAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.residentialAddressTextBox.TabIndex = 16;
            // 
            // placeOfWorkLabel
            // 
            placeOfWorkLabel.AutoSize = true;
            placeOfWorkLabel.Location = new System.Drawing.Point(80, 278);
            placeOfWorkLabel.Name = "placeOfWorkLabel";
            placeOfWorkLabel.Size = new System.Drawing.Size(80, 13);
            placeOfWorkLabel.TabIndex = 17;
            placeOfWorkLabel.Text = "Place Of Work:";
            // 
            // placeOfWorkTextBox
            // 
            this.placeOfWorkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "PlaceOfWork", true));
            this.placeOfWorkTextBox.Location = new System.Drawing.Point(193, 275);
            this.placeOfWorkTextBox.Name = "placeOfWorkTextBox";
            this.placeOfWorkTextBox.Size = new System.Drawing.Size(100, 20);
            this.placeOfWorkTextBox.TabIndex = 18;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(80, 304);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 19;
            positionLabel.Text = "Position:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(193, 301);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 20;
            // 
            // mobilePhoneLabel
            // 
            mobilePhoneLabel.AutoSize = true;
            mobilePhoneLabel.Location = new System.Drawing.Point(80, 330);
            mobilePhoneLabel.Name = "mobilePhoneLabel";
            mobilePhoneLabel.Size = new System.Drawing.Size(75, 13);
            mobilePhoneLabel.TabIndex = 21;
            mobilePhoneLabel.Text = "Mobile Phone:";
            // 
            // mobilePhoneTextBox
            // 
            this.mobilePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "MobilePhone", true));
            this.mobilePhoneTextBox.Location = new System.Drawing.Point(193, 327);
            this.mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            this.mobilePhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobilePhoneTextBox.TabIndex = 22;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(80, 356);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(193, 353);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 24;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(80, 382);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(38, 13);
            photoLabel.TabIndex = 25;
            photoLabel.Text = "Photo:";
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(193, 379);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(100, 20);
            this.photoTextBox.TabIndex = 26;
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(80, 408);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 27;
            commentsLabel.Text = "Comments:";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(193, 405);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.commentsTextBox.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 62);
            this.button1.TabIndex = 29;
            this.button1.Text = "Переход к авторизации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 65);
            this.button2.TabIndex = 30;
            this.button2.Text = "Переход к лицензиям";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(gUIDLabel);
            this.Controls.Add(this.gUIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(registrationAddressLabel);
            this.Controls.Add(this.registrationAddressTextBox);
            this.Controls.Add(residentialAddressLabel);
            this.Controls.Add(this.residentialAddressTextBox);
            this.Controls.Add(placeOfWorkLabel);
            this.Controls.Add(this.placeOfWorkTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(mobilePhoneLabel);
            this.Controls.Add(this.mobilePhoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.driverBindingNavigator);
            this.Name = "Drivers";
            this.Text = "Drivers";
            this.Load += new System.EventHandler(this.Drivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_DriversDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingNavigator)).EndInit();
            this.driverBindingNavigator.ResumeLayout(false);
            this.driverBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_DriversDataSet dB_DriversDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private DB_DriversDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private DB_DriversDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator driverBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton driverBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gUIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox registrationAddressTextBox;
        private System.Windows.Forms.TextBox residentialAddressTextBox;
        private System.Windows.Forms.TextBox placeOfWorkTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox mobilePhoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}