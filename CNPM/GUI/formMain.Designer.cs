﻿namespace CNPM.GUI
{
    partial class formMain
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
            this.mnsManager = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phímTắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lbPercent = new System.Windows.Forms.Label();
            this.lbCountTempTable = new System.Windows.Forms.Label();
            this.lbCountFullTable = new System.Windows.Forms.Label();
            this.lbCountTable = new System.Windows.Forms.Label();
            this.fpnlTableMap = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.lbDrink = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fpnlBill = new System.Windows.Forms.FlowLayoutPanel();
            this.lstViewBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPay = new System.Windows.Forms.Panel();
            this.nudPromotion = new System.Windows.Forms.NumericUpDown();
            this.lbPromotion = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbCash = new System.Windows.Forms.TextBox();
            this.lbCash = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txbSurplus = new System.Windows.Forms.TextBox();
            this.lbSurplus = new System.Windows.Forms.Label();
            this.pnlTableControls = new System.Windows.Forms.Panel();
            this.lbSelectTemp = new System.Windows.Forms.Label();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.cbTempTable = new System.Windows.Forms.ComboBox();
            this.btnMoveTable = new System.Windows.Forms.Button();
            this.mnsManager.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.fpnlBill.SuspendLayout();
            this.pnlPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromotion)).BeginInit();
            this.pnlPrint.SuspendLayout();
            this.pnlTableControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsManager
            // 
            this.mnsManager.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.phímTắtToolStripMenuItem});
            this.mnsManager.Location = new System.Drawing.Point(0, 0);
            this.mnsManager.Name = "mnsManager";
            this.mnsManager.Size = new System.Drawing.Size(1180, 28);
            this.mnsManager.TabIndex = 0;
            this.mnsManager.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Image = global::CNPM.Properties.Resources.profiles;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Image = global::CNPM.Properties.Resources.man;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Image = global::CNPM.Properties.Resources.resume;
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            this.xemThôngTinToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::CNPM.Properties.Resources.exit;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // phímTắtToolStripMenuItem
            // 
            this.phímTắtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.thanhToánToolStripMenuItem});
            this.phímTắtToolStripMenuItem.Image = global::CNPM.Properties.Resources.loading;
            this.phímTắtToolStripMenuItem.Name = "phímTắtToolStripMenuItem";
            this.phímTắtToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.phímTắtToolStripMenuItem.Text = "Phím tắt";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.BackColor = System.Drawing.SystemColors.Info;
            this.pnlFooter.Controls.Add(this.lbPercent);
            this.pnlFooter.Controls.Add(this.lbCountTempTable);
            this.pnlFooter.Controls.Add(this.lbCountFullTable);
            this.pnlFooter.Controls.Add(this.lbCountTable);
            this.pnlFooter.Location = new System.Drawing.Point(0, 667);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1180, 23);
            this.pnlFooter.TabIndex = 0;
            // 
            // lbPercent
            // 
            this.lbPercent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPercent.AutoSize = true;
            this.lbPercent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.Location = new System.Drawing.Point(272, 1);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(37, 22);
            this.lbPercent.TabIndex = 0;
            this.lbPercent.Text = "tỷ lệ";
            // 
            // lbCountTempTable
            // 
            this.lbCountTempTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCountTempTable.AutoSize = true;
            this.lbCountTempTable.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountTempTable.Location = new System.Drawing.Point(205, 1);
            this.lbCountTempTable.Name = "lbCountTempTable";
            this.lbCountTempTable.Size = new System.Drawing.Size(43, 22);
            this.lbCountTempTable.TabIndex = 0;
            this.lbCountTempTable.Text = "trống";
            // 
            // lbCountFullTable
            // 
            this.lbCountFullTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCountFullTable.AutoSize = true;
            this.lbCountFullTable.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountFullTable.Location = new System.Drawing.Point(103, 1);
            this.lbCountFullTable.Name = "lbCountFullTable";
            this.lbCountFullTable.Size = new System.Drawing.Size(66, 22);
            this.lbCountFullTable.TabIndex = 0;
            this.lbCountFullTable.Text = "có người";
            // 
            // lbCountTable
            // 
            this.lbCountTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCountTable.AutoSize = true;
            this.lbCountTable.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountTable.Location = new System.Drawing.Point(3, 1);
            this.lbCountTable.Name = "lbCountTable";
            this.lbCountTable.Size = new System.Drawing.Size(92, 22);
            this.lbCountTable.TabIndex = 0;
            this.lbCountTable.Text = "Tổng số bàn";
            // 
            // fpnlTableMap
            // 
            this.fpnlTableMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnlTableMap.AutoScroll = true;
            this.fpnlTableMap.BackColor = System.Drawing.SystemColors.Control;
            this.fpnlTableMap.Location = new System.Drawing.Point(12, 27);
            this.fpnlTableMap.Name = "fpnlTableMap";
            this.fpnlTableMap.Size = new System.Drawing.Size(719, 552);
            this.fpnlTableMap.TabIndex = 0;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrder.Controls.Add(this.cbCategory);
            this.pnlOrder.Controls.Add(this.cbDrink);
            this.pnlOrder.Controls.Add(this.lbDrink);
            this.pnlOrder.Controls.Add(this.lbCategory);
            this.pnlOrder.Controls.Add(this.lbAmount);
            this.pnlOrder.Controls.Add(this.nudAmount);
            this.pnlOrder.Controls.Add(this.btnAdd);
            this.pnlOrder.Location = new System.Drawing.Point(736, 27);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(441, 71);
            this.pnlOrder.TabIndex = 0;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.Info;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(91, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(202, 31);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbDrink
            // 
            this.cbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrink.FormattingEnabled = true;
            this.cbDrink.Location = new System.Drawing.Point(91, 40);
            this.cbDrink.Name = "cbDrink";
            this.cbDrink.Size = new System.Drawing.Size(202, 31);
            this.cbDrink.Sorted = true;
            this.cbDrink.TabIndex = 2;
            // 
            // lbDrink
            // 
            this.lbDrink.AutoSize = true;
            this.lbDrink.Location = new System.Drawing.Point(4, 43);
            this.lbDrink.Name = "lbDrink";
            this.lbDrink.Size = new System.Drawing.Size(86, 23);
            this.lbDrink.TabIndex = 0;
            this.lbDrink.Text = "Đồ uống:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(4, 6);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(100, 23);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "Danh mục:";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(301, 6);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(91, 23);
            this.lbAmount.TabIndex = 0;
            this.lbAmount.Text = "Số lượng:";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(379, 4);
            this.nudAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(51, 30);
            this.nudAmount.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(306, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = " Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fpnlBill
            // 
            this.fpnlBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnlBill.Controls.Add(this.lstViewBill);
            this.fpnlBill.Location = new System.Drawing.Point(737, 104);
            this.fpnlBill.Name = "fpnlBill";
            this.fpnlBill.Size = new System.Drawing.Size(440, 395);
            this.fpnlBill.TabIndex = 0;
            // 
            // lstViewBill
            // 
            this.lstViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstViewBill.GridLines = true;
            this.lstViewBill.HideSelection = false;
            this.lstViewBill.Location = new System.Drawing.Point(3, 3);
            this.lstViewBill.Name = "lstViewBill";
            this.lstViewBill.Size = new System.Drawing.Size(428, 392);
            this.lstViewBill.TabIndex = 0;
            this.lstViewBill.UseCompatibleStateImageBehavior = false;
            this.lstViewBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên đồ uống";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 96;
            // 
            // pnlPay
            // 
            this.pnlPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPay.Controls.Add(this.nudPromotion);
            this.pnlPay.Controls.Add(this.lbPromotion);
            this.pnlPay.Controls.Add(this.txbTotal);
            this.pnlPay.Controls.Add(this.lbTotal);
            this.pnlPay.Controls.Add(this.btnPay);
            this.pnlPay.Location = new System.Drawing.Point(737, 502);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(440, 77);
            this.pnlPay.TabIndex = 2;
            // 
            // nudPromotion
            // 
            this.nudPromotion.DecimalPlaces = 2;
            this.nudPromotion.Location = new System.Drawing.Point(113, 8);
            this.nudPromotion.Name = "nudPromotion";
            this.nudPromotion.Size = new System.Drawing.Size(175, 30);
            this.nudPromotion.TabIndex = 0;
            this.nudPromotion.TabStop = false;
            this.nudPromotion.ValueChanged += new System.EventHandler(this.nudPromotion_ValueChanged);
            // 
            // lbPromotion
            // 
            this.lbPromotion.AutoSize = true;
            this.lbPromotion.Location = new System.Drawing.Point(3, 10);
            this.lbPromotion.Name = "lbPromotion";
            this.lbPromotion.Size = new System.Drawing.Size(130, 23);
            this.lbPromotion.TabIndex = 0;
            this.lbPromotion.Text = "Giảm giá (%):";
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbTotal.ForeColor = System.Drawing.Color.Red;
            this.txbTotal.Location = new System.Drawing.Point(113, 44);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(175, 30);
            this.txbTotal.TabIndex = 0;
            this.txbTotal.TabStop = false;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(3, 47);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(97, 23);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Tổng tiền:";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(304, 23);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(125, 32);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pnlPrint
            // 
            this.pnlPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrint.Controls.Add(this.btnCancel);
            this.pnlPrint.Controls.Add(this.txbCash);
            this.pnlPrint.Controls.Add(this.lbCash);
            this.pnlPrint.Controls.Add(this.btnAccept);
            this.pnlPrint.Controls.Add(this.txbSurplus);
            this.pnlPrint.Controls.Add(this.lbSurplus);
            this.pnlPrint.Location = new System.Drawing.Point(737, 585);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(440, 80);
            this.pnlPrint.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(305, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbCash
            // 
            this.txbCash.BackColor = System.Drawing.SystemColors.Control;
            this.txbCash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbCash.Location = new System.Drawing.Point(113, 7);
            this.txbCash.Name = "txbCash";
            this.txbCash.Size = new System.Drawing.Size(175, 30);
            this.txbCash.TabIndex = 0;
            this.txbCash.TabStop = false;
            this.txbCash.TextChanged += new System.EventHandler(this.txbCash_TextChanged);
            // 
            // lbCash
            // 
            this.lbCash.AutoSize = true;
            this.lbCash.Location = new System.Drawing.Point(3, 10);
            this.lbCash.Name = "lbCash";
            this.lbCash.Size = new System.Drawing.Size(100, 23);
            this.lbCash.TabIndex = 0;
            this.lbCash.Text = "Khách trả:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(305, 1);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(125, 32);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.TabStop = false;
            this.btnAccept.Text = "Xác Nhận";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txbSurplus
            // 
            this.txbSurplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbSurplus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txbSurplus.Location = new System.Drawing.Point(113, 44);
            this.txbSurplus.Name = "txbSurplus";
            this.txbSurplus.ReadOnly = true;
            this.txbSurplus.Size = new System.Drawing.Size(175, 30);
            this.txbSurplus.TabIndex = 0;
            this.txbSurplus.TabStop = false;
            // 
            // lbSurplus
            // 
            this.lbSurplus.AutoSize = true;
            this.lbSurplus.Location = new System.Drawing.Point(3, 47);
            this.lbSurplus.Name = "lbSurplus";
            this.lbSurplus.Size = new System.Drawing.Size(65, 23);
            this.lbSurplus.TabIndex = 0;
            this.lbSurplus.Text = "Số dư:";
            // 
            // pnlTableControls
            // 
            this.pnlTableControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableControls.Controls.Add(this.lbSelectTemp);
            this.pnlTableControls.Controls.Add(this.btnAddTable);
            this.pnlTableControls.Controls.Add(this.btnDeleteTable);
            this.pnlTableControls.Controls.Add(this.cbTempTable);
            this.pnlTableControls.Controls.Add(this.btnMoveTable);
            this.pnlTableControls.Location = new System.Drawing.Point(12, 585);
            this.pnlTableControls.Name = "pnlTableControls";
            this.pnlTableControls.Size = new System.Drawing.Size(719, 80);
            this.pnlTableControls.TabIndex = 0;
            // 
            // lbSelectTemp
            // 
            this.lbSelectTemp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbSelectTemp.AutoSize = true;
            this.lbSelectTemp.Location = new System.Drawing.Point(163, 45);
            this.lbSelectTemp.Name = "lbSelectTemp";
            this.lbSelectTemp.Size = new System.Drawing.Size(188, 23);
            this.lbSelectTemp.TabIndex = 0;
            this.lbSelectTemp.Text = "Danh sách bàn trống:";
            // 
            // btnAddTable
            // 
            this.btnAddTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddTable.Location = new System.Drawing.Point(224, 7);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(117, 32);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.TabStop = false;
            this.btnAddTable.Text = "Thêm bàn";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteTable.Location = new System.Drawing.Point(347, 8);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(117, 32);
            this.btnDeleteTable.TabIndex = 0;
            this.btnDeleteTable.TabStop = false;
            this.btnDeleteTable.Text = "Xóa bàn";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // cbTempTable
            // 
            this.cbTempTable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbTempTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTempTable.FormattingEnabled = true;
            this.cbTempTable.Location = new System.Drawing.Point(337, 42);
            this.cbTempTable.Name = "cbTempTable";
            this.cbTempTable.Size = new System.Drawing.Size(45, 31);
            this.cbTempTable.TabIndex = 0;
            this.cbTempTable.TabStop = false;
            // 
            // btnMoveTable
            // 
            this.btnMoveTable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMoveTable.Location = new System.Drawing.Point(388, 43);
            this.btnMoveTable.Name = "btnMoveTable";
            this.btnMoveTable.Size = new System.Drawing.Size(117, 32);
            this.btnMoveTable.TabIndex = 0;
            this.btnMoveTable.TabStop = false;
            this.btnMoveTable.Text = "Chuyển bàn";
            this.btnMoveTable.UseVisualStyleBackColor = true;
            this.btnMoveTable.Click += new System.EventHandler(this.btnMoveTable_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 690);
            this.Controls.Add(this.pnlTableControls);
            this.Controls.Add(this.pnlPrint);
            this.Controls.Add(this.pnlPay);
            this.Controls.Add(this.fpnlBill);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.fpnlTableMap);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.mnsManager);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnsManager;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý Tà Tứa";
            this.mnsManager.ResumeLayout(false);
            this.mnsManager.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.fpnlBill.ResumeLayout(false);
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromotion)).EndInit();
            this.pnlPrint.ResumeLayout(false);
            this.pnlPrint.PerformLayout();
            this.pnlTableControls.ResumeLayout(false);
            this.pnlTableControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsManager;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phímTắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.Label lbCountTempTable;
        private System.Windows.Forms.Label lbCountFullTable;
        private System.Windows.Forms.Label lbCountTable;
        private System.Windows.Forms.FlowLayoutPanel fpnlTableMap;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbDrink;
        private System.Windows.Forms.Label lbDrink;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel fpnlBill;
        private System.Windows.Forms.ListView lstViewBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.NumericUpDown nudPromotion;
        private System.Windows.Forms.Label lbPromotion;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbCash;
        private System.Windows.Forms.Label lbCash;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txbSurplus;
        private System.Windows.Forms.Label lbSurplus;
        private System.Windows.Forms.Panel pnlTableControls;
        private System.Windows.Forms.Label lbSelectTemp;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.ComboBox cbTempTable;
        private System.Windows.Forms.Button btnMoveTable;
    }
}