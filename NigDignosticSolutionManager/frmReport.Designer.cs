﻿namespace NigDignosticSolutionManager
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPatientInfo = new System.Windows.Forms.GroupBox();
            this.PcLoader = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPatientNameRefresh = new System.Windows.Forms.Button();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.grpBillInfo = new System.Windows.Forms.GroupBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillDOB = new System.Windows.Forms.TextBox();
            this.txtBillAge = new System.Windows.Forms.TextBox();
            this.txtBillGender = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReportDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.bwLoader = new System.ComponentModel.BackgroundWorker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dgvTestResult = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grpPatientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcLoader)).BeginInit();
            this.grpBillInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatientInfo
            // 
            this.grpPatientInfo.BackColor = System.Drawing.Color.LightBlue;
            this.grpPatientInfo.Controls.Add(this.PcLoader);
            this.grpPatientInfo.Controls.Add(this.label1);
            this.grpPatientInfo.Controls.Add(this.label4);
            this.grpPatientInfo.Controls.Add(this.label5);
            this.grpPatientInfo.Controls.Add(this.label6);
            this.grpPatientInfo.Controls.Add(this.label3);
            this.grpPatientInfo.Controls.Add(this.btnPatientNameRefresh);
            this.grpPatientInfo.Controls.Add(this.txtBillId);
            this.grpPatientInfo.Controls.Add(this.txtAge);
            this.grpPatientInfo.Controls.Add(this.txtPatientName);
            this.grpPatientInfo.Controls.Add(this.txtGender);
            this.grpPatientInfo.Controls.Add(this.txtDOB);
            this.grpPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientInfo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grpPatientInfo.Location = new System.Drawing.Point(2, 3);
            this.grpPatientInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatientInfo.Name = "grpPatientInfo";
            this.grpPatientInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpPatientInfo.Size = new System.Drawing.Size(342, 238);
            this.grpPatientInfo.TabIndex = 1;
            this.grpPatientInfo.TabStop = false;
            this.grpPatientInfo.Text = "Patient Info";
            // 
            // PcLoader
            // 
            this.PcLoader.Image = ((System.Drawing.Image)(resources.GetObject("PcLoader.Image")));
            this.PcLoader.Location = new System.Drawing.Point(284, 37);
            this.PcLoader.Name = "PcLoader";
            this.PcLoader.Size = new System.Drawing.Size(26, 26);
            this.PcLoader.TabIndex = 19;
            this.PcLoader.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(76, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(72, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(56, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Patient Name";
            // 
            // btnPatientNameRefresh
            // 
            this.btnPatientNameRefresh.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPatientNameRefresh.BackgroundImage = global::NigDignosticSolutionManager.Properties.Resources.refresh1;
            this.btnPatientNameRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPatientNameRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientNameRefresh.Location = new System.Drawing.Point(230, 36);
            this.btnPatientNameRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatientNameRefresh.Name = "btnPatientNameRefresh";
            this.btnPatientNameRefresh.Size = new System.Drawing.Size(26, 26);
            this.btnPatientNameRefresh.TabIndex = 18;
            this.btnPatientNameRefresh.UseVisualStyleBackColor = false;
            this.btnPatientNameRefresh.Click += new System.EventHandler(this.BtnPatientNameRefresh_ClickAsync);
            // 
            // txtBillId
            // 
            this.txtBillId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBillId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillId.Location = new System.Drawing.Point(119, 37);
            this.txtBillId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(105, 26);
            this.txtBillId.TabIndex = 16;
            this.txtBillId.TextChanged += new System.EventHandler(this.TxtBillId_TextChanged_1);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAge.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(119, 183);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(201, 24);
            this.txtAge.TabIndex = 12;
            // 
            // txtPatientName
            // 
            this.txtPatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPatientName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPatientName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(119, 75);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(201, 24);
            this.txtPatientName.TabIndex = 2;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtGender.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(119, 111);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(201, 24);
            this.txtGender.TabIndex = 10;
            // 
            // txtDOB
            // 
            this.txtDOB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOB.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDOB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(119, 147);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(201, 24);
            this.txtDOB.TabIndex = 11;
            // 
            // grpBillInfo
            // 
            this.grpBillInfo.BackColor = System.Drawing.Color.LightBlue;
            this.grpBillInfo.Controls.Add(this.txtBarcode);
            this.grpBillInfo.Controls.Add(this.label2);
            this.grpBillInfo.Controls.Add(this.txtBillDOB);
            this.grpBillInfo.Controls.Add(this.txtBillAge);
            this.grpBillInfo.Controls.Add(this.txtBillGender);
            this.grpBillInfo.Controls.Add(this.label14);
            this.grpBillInfo.Controls.Add(this.label13);
            this.grpBillInfo.Controls.Add(this.label12);
            this.grpBillInfo.Controls.Add(this.txtReportDate);
            this.grpBillInfo.Controls.Add(this.label9);
            this.grpBillInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBillInfo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grpBillInfo.Location = new System.Drawing.Point(347, 3);
            this.grpBillInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBillInfo.Name = "grpBillInfo";
            this.grpBillInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpBillInfo.Size = new System.Drawing.Size(361, 238);
            this.grpBillInfo.TabIndex = 2;
            this.grpBillInfo.TabStop = false;
            this.grpBillInfo.Text = "Bill Info";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBarcode.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(101, 38);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(226, 24);
            this.txtBarcode.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Barcode";
            // 
            // txtBillDOB
            // 
            this.txtBillDOB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBillDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillDOB.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBillDOB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillDOB.Location = new System.Drawing.Point(101, 149);
            this.txtBillDOB.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillDOB.Name = "txtBillDOB";
            this.txtBillDOB.ReadOnly = true;
            this.txtBillDOB.Size = new System.Drawing.Size(226, 24);
            this.txtBillDOB.TabIndex = 20;
            // 
            // txtBillAge
            // 
            this.txtBillAge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBillAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillAge.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBillAge.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAge.Location = new System.Drawing.Point(101, 186);
            this.txtBillAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillAge.Name = "txtBillAge";
            this.txtBillAge.ReadOnly = true;
            this.txtBillAge.Size = new System.Drawing.Size(226, 24);
            this.txtBillAge.TabIndex = 19;
            // 
            // txtBillGender
            // 
            this.txtBillGender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBillGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillGender.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBillGender.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillGender.Location = new System.Drawing.Point(101, 112);
            this.txtBillGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillGender.Name = "txtBillGender";
            this.txtBillGender.ReadOnly = true;
            this.txtBillGender.Size = new System.Drawing.Size(226, 24);
            this.txtBillGender.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(62, 188);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Age";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(58, 151);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "DOB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(42, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Gender";
            // 
            // txtReportDate
            // 
            this.txtReportDate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReportDate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReportDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtReportDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtReportDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportDate.Location = new System.Drawing.Point(101, 75);
            this.txtReportDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtReportDate.Name = "txtReportDate";
            this.txtReportDate.ReadOnly = true;
            this.txtReportDate.Size = new System.Drawing.Size(226, 24);
            this.txtReportDate.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(2, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Report Date";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubmit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(716, 521);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(343, 33);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_ClickAsync);
            // 
            // bwLoader
            // 
            this.bwLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwLoader_DoWork);
            this.bwLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwLoader_RunWorkerCompleted);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // dgvTestResult
            // 
            this.dgvTestResult.AllowUserToOrderColumns = true;
            this.dgvTestResult.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTestResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column10,
            this.test_id,
            this.Column2});
            this.dgvTestResult.GridColor = System.Drawing.Color.Black;
            this.dgvTestResult.Location = new System.Drawing.Point(4, 247);
            this.dgvTestResult.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTestResult.Name = "dgvTestResult";
            this.dgvTestResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTestResult.RowHeadersVisible = false;
            this.dgvTestResult.RowTemplate.Height = 24;
            this.dgvTestResult.Size = new System.Drawing.Size(701, 307);
            this.dgvTestResult.TabIndex = 23;
            this.dgvTestResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTestResult_CellClick_1);
            this.dgvTestResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTestResult_CellContentClick);
            // 
            // Column8
            // 
            this.Column8.FillWeight = 50F;
            this.Column8.HeaderText = "";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.Width = 37;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 250F;
            this.Column1.HeaderText = "Test Field Name";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 184;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Test Result";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 73;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lower Ref";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 74;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Higher Ref";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 73;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Unit";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 74;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "M.Name";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 250F;
            this.Column10.HeaderText = "Test Name";
            this.Column10.Name = "Column10";
            this.Column10.Width = 184;
            // 
            // test_id
            // 
            this.test_id.HeaderText = "testId";
            this.test_id.Name = "test_id";
            this.test_id.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Field Id";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(727, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 426);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClickAsync);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(283, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 26);
            this.button1.TabIndex = 31;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(710, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 513);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Reports";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(328, 10);
            this.progressBar1.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Search Name";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(112, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 25);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 557);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpBillInfo);
            this.Controls.Add(this.grpPatientInfo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvTestResult);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.grpPatientInfo.ResumeLayout(false);
            this.grpPatientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcLoader)).EndInit();
            this.grpBillInfo.ResumeLayout(false);
            this.grpBillInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPatientInfo;
        private System.Windows.Forms.GroupBox grpBillInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtReportDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBillGender;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBillDOB;
        private System.Windows.Forms.TextBox txtBillAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillId;
        private System.ComponentModel.BackgroundWorker bwLoader;
        private System.Windows.Forms.Button btnPatientNameRefresh;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dgvTestResult;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PcLoader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}