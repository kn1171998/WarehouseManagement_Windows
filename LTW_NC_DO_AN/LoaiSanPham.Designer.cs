namespace LTW_NC_DO_AN
{
    partial class LoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiSanPham));
            System.Windows.Forms.Label iD_LOAI_SAN_PHAMLabel;
            System.Windows.Forms.Label tEN_LOAI_SAN_PHAMLabel;
            System.Windows.Forms.Label mO_TALabel;
            this.qlkho1DataSet = new LTW_NC_DO_AN.qlkho1DataSet();
            this.sALE_LOAI_SAN_PHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALE_LOAI_SAN_PHAMTableAdapter = new LTW_NC_DO_AN.qlkho1DataSetTableAdapters.SALE_LOAI_SAN_PHAMTableAdapter();
            this.tableAdapterManager = new LTW_NC_DO_AN.qlkho1DataSetTableAdapters.TableAdapterManager();
            this.sALE_LOAI_SAN_PHAMBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sALE_LOAI_SAN_PHAMGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.iD_LOAI_SAN_PHAMSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tEN_LOAI_SAN_PHAMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mO_TATextEdit = new DevExpress.XtraEditors.TextEdit();
            iD_LOAI_SAN_PHAMLabel = new System.Windows.Forms.Label();
            tEN_LOAI_SAN_PHAMLabel = new System.Windows.Forms.Label();
            mO_TALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlkho1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALE_LOAI_SAN_PHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALE_LOAI_SAN_PHAMBindingNavigator)).BeginInit();
            this.sALE_LOAI_SAN_PHAMBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALE_LOAI_SAN_PHAMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iD_LOAI_SAN_PHAMSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEN_LOAI_SAN_PHAMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mO_TATextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // qlkho1DataSet
            // 
            this.qlkho1DataSet.DataSetName = "qlkho1DataSet";
            this.qlkho1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALE_LOAI_SAN_PHAMBindingSource
            // 
            this.sALE_LOAI_SAN_PHAMBindingSource.DataMember = "SALE_LOAI_SAN_PHAM";
            this.sALE_LOAI_SAN_PHAMBindingSource.DataSource = this.qlkho1DataSet;
            // 
            // sALE_LOAI_SAN_PHAMTableAdapter
            // 
            this.sALE_LOAI_SAN_PHAMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAU_HINHTableAdapter = null;
            this.tableAdapterManager.GROUPMENUFUNCTableAdapter = null;
            this.tableAdapterManager.HINH_ANH_SAN_PHAMTableAdapter = null;
            this.tableAdapterManager.MENUFORMTableAdapter = null;
            this.tableAdapterManager.SALE_CHI_TIET_PHIEU_DAT_HANG_NCCTableAdapter = null;
            this.tableAdapterManager.SALE_CHI_TIET_PHIEU_DAT_HANGTableAdapter = null;
            this.tableAdapterManager.SALE_CHI_TIET_PHIEU_KIEM_KETableAdapter = null;
            this.tableAdapterManager.SALE_CHI_TIET_PHIEU_NHAP_XUAT_TRA_CHUYENTableAdapter = null;
            this.tableAdapterManager.SALE_HINH_THUC_THANH_TOANTableAdapter = null;
            this.tableAdapterManager.SALE_KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.SALE_KHOTableAdapter = null;
            this.tableAdapterManager.SALE_LOAI_SAN_PHAMTableAdapter = this.sALE_LOAI_SAN_PHAMTableAdapter;
            this.tableAdapterManager.SALE_NHA_CUNG_CAPTableAdapter = null;
            this.tableAdapterManager.SALE_NHA_SAN_XUATTableAdapter = null;
            this.tableAdapterManager.SALE_NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.SALE_PHIEU_DAT_HANG_NCCTableAdapter = null;
            this.tableAdapterManager.SALE_PHIEU_DAT_HANGTableAdapter = null;
            this.tableAdapterManager.SALE_PHIEU_KIEM_KETableAdapter = null;
            this.tableAdapterManager.SALE_PHIEU_NHAP_XUAT_TRA_CHUYENTableAdapter = null;
            this.tableAdapterManager.SALE_PHIEU_THU_CHITableAdapter = null;
            this.tableAdapterManager.SALE_SAN_PHAMTableAdapter = null;
            this.tableAdapterManager.SALE_SO_DU_DAU_KY_SAN_PHAMTableAdapter = null;
            this.tableAdapterManager.SALE_TRANG_THAITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LTW_NC_DO_AN.qlkho1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sALE_LOAI_SAN_PHAMBindingNavigator
            // 
            this.sALE_LOAI_SAN_PHAMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sALE_LOAI_SAN_PHAMBindingNavigator.BindingSource = this.sALE_LOAI_SAN_PHAMBindingSource;
            this.sALE_LOAI_SAN_PHAMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sALE_LOAI_SAN_PHAMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sALE_LOAI_SAN_PHAMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem});
            this.sALE_LOAI_SAN_PHAMBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sALE_LOAI_SAN_PHAMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sALE_LOAI_SAN_PHAMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sALE_LOAI_SAN_PHAMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sALE_LOAI_SAN_PHAMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sALE_LOAI_SAN_PHAMBindingNavigator.Name = "sALE_LOAI_SAN_PHAMBindingNavigator";
            this.sALE_LOAI_SAN_PHAMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sALE_LOAI_SAN_PHAMBindingNavigator.Size = new System.Drawing.Size(845, 27);
            this.sALE_LOAI_SAN_PHAMBindingNavigator.TabIndex = 0;
            this.sALE_LOAI_SAN_PHAMBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem
            // 
            this.sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem.Image")));
            this.sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem.Name = "sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem";
            this.sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem.Text = "Save Data";
            this.sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem.Click += new System.EventHandler(this.sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem_Click);
            // 
            // sALE_LOAI_SAN_PHAMGridControl
            // 
            this.sALE_LOAI_SAN_PHAMGridControl.DataSource = this.sALE_LOAI_SAN_PHAMBindingSource;
            this.sALE_LOAI_SAN_PHAMGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sALE_LOAI_SAN_PHAMGridControl.Location = new System.Drawing.Point(0, 378);
            this.sALE_LOAI_SAN_PHAMGridControl.MainView = this.gridView1;
            this.sALE_LOAI_SAN_PHAMGridControl.Name = "sALE_LOAI_SAN_PHAMGridControl";
            this.sALE_LOAI_SAN_PHAMGridControl.Size = new System.Drawing.Size(845, 220);
            this.sALE_LOAI_SAN_PHAMGridControl.TabIndex = 1;
            this.sALE_LOAI_SAN_PHAMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sALE_LOAI_SAN_PHAMGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // iD_LOAI_SAN_PHAMLabel
            // 
            iD_LOAI_SAN_PHAMLabel.AutoSize = true;
            iD_LOAI_SAN_PHAMLabel.Location = new System.Drawing.Point(158, 70);
            iD_LOAI_SAN_PHAMLabel.Name = "iD_LOAI_SAN_PHAMLabel";
            iD_LOAI_SAN_PHAMLabel.Size = new System.Drawing.Size(117, 17);
            iD_LOAI_SAN_PHAMLabel.TabIndex = 2;
            iD_LOAI_SAN_PHAMLabel.Text = "Mã loại sản phẩm:";
            // 
            // iD_LOAI_SAN_PHAMSpinEdit
            // 
            this.iD_LOAI_SAN_PHAMSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sALE_LOAI_SAN_PHAMBindingSource, "ID_LOAI_SAN_PHAM", true));
            this.iD_LOAI_SAN_PHAMSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iD_LOAI_SAN_PHAMSpinEdit.Location = new System.Drawing.Point(303, 67);
            this.iD_LOAI_SAN_PHAMSpinEdit.Name = "iD_LOAI_SAN_PHAMSpinEdit";
            this.iD_LOAI_SAN_PHAMSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iD_LOAI_SAN_PHAMSpinEdit.Size = new System.Drawing.Size(125, 22);
            this.iD_LOAI_SAN_PHAMSpinEdit.TabIndex = 3;
            // 
            // tEN_LOAI_SAN_PHAMLabel
            // 
            tEN_LOAI_SAN_PHAMLabel.AutoSize = true;
            tEN_LOAI_SAN_PHAMLabel.Location = new System.Drawing.Point(158, 98);
            tEN_LOAI_SAN_PHAMLabel.Name = "tEN_LOAI_SAN_PHAMLabel";
            tEN_LOAI_SAN_PHAMLabel.Size = new System.Drawing.Size(123, 17);
            tEN_LOAI_SAN_PHAMLabel.TabIndex = 4;
            tEN_LOAI_SAN_PHAMLabel.Text = "Tên loại sản phẩm:";
            // 
            // tEN_LOAI_SAN_PHAMTextEdit
            // 
            this.tEN_LOAI_SAN_PHAMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sALE_LOAI_SAN_PHAMBindingSource, "TEN_LOAI_SAN_PHAM", true));
            this.tEN_LOAI_SAN_PHAMTextEdit.Location = new System.Drawing.Point(303, 95);
            this.tEN_LOAI_SAN_PHAMTextEdit.Name = "tEN_LOAI_SAN_PHAMTextEdit";
            this.tEN_LOAI_SAN_PHAMTextEdit.Size = new System.Drawing.Size(125, 22);
            this.tEN_LOAI_SAN_PHAMTextEdit.TabIndex = 5;
            // 
            // mO_TALabel
            // 
            mO_TALabel.AutoSize = true;
            mO_TALabel.Location = new System.Drawing.Point(158, 126);
            mO_TALabel.Name = "mO_TALabel";
            mO_TALabel.Size = new System.Drawing.Size(47, 17);
            mO_TALabel.TabIndex = 6;
            mO_TALabel.Text = "Mô tả:";
            // 
            // mO_TATextEdit
            // 
            this.mO_TATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sALE_LOAI_SAN_PHAMBindingSource, "MO_TA", true));
            this.mO_TATextEdit.Location = new System.Drawing.Point(303, 123);
            this.mO_TATextEdit.Name = "mO_TATextEdit";
            this.mO_TATextEdit.Size = new System.Drawing.Size(125, 22);
            this.mO_TATextEdit.TabIndex = 7;
            // 
            // LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 598);
            this.Controls.Add(iD_LOAI_SAN_PHAMLabel);
            this.Controls.Add(this.iD_LOAI_SAN_PHAMSpinEdit);
            this.Controls.Add(tEN_LOAI_SAN_PHAMLabel);
            this.Controls.Add(this.tEN_LOAI_SAN_PHAMTextEdit);
            this.Controls.Add(mO_TALabel);
            this.Controls.Add(this.mO_TATextEdit);
            this.Controls.Add(this.sALE_LOAI_SAN_PHAMGridControl);
            this.Controls.Add(this.sALE_LOAI_SAN_PHAMBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoaiSanPham";
            this.Text = "LoaiSanPham";
            this.Load += new System.EventHandler(this.LoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlkho1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALE_LOAI_SAN_PHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALE_LOAI_SAN_PHAMBindingNavigator)).EndInit();
            this.sALE_LOAI_SAN_PHAMBindingNavigator.ResumeLayout(false);
            this.sALE_LOAI_SAN_PHAMBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALE_LOAI_SAN_PHAMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iD_LOAI_SAN_PHAMSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEN_LOAI_SAN_PHAMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mO_TATextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qlkho1DataSet qlkho1DataSet;
        private System.Windows.Forms.BindingSource sALE_LOAI_SAN_PHAMBindingSource;
        private qlkho1DataSetTableAdapters.SALE_LOAI_SAN_PHAMTableAdapter sALE_LOAI_SAN_PHAMTableAdapter;
        private qlkho1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sALE_LOAI_SAN_PHAMBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl sALE_LOAI_SAN_PHAMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SpinEdit iD_LOAI_SAN_PHAMSpinEdit;
        private DevExpress.XtraEditors.TextEdit tEN_LOAI_SAN_PHAMTextEdit;
        private DevExpress.XtraEditors.TextEdit mO_TATextEdit;
    }
}