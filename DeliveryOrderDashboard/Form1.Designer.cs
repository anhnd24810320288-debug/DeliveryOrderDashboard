namespace DeliveryOrderDashboard
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.SplitContainer splitContainerMain;

        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Panel panelProducts;

        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabShipping;

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.ComboBox cboShipping;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.DataGridView dgvProducts;

        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.StatusStrip statusStrip;

        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblQuantity;
        private System.Windows.Forms.ToolStripStatusLabel lblWeight;
        private System.Windows.Forms.ToolStripStatusLabel lblMoney;

        private System.Windows.Forms.ErrorProvider errorProvider;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            splitContainerMain =
                new System.Windows.Forms.SplitContainer();

            panelCustomer =
                new System.Windows.Forms.Panel();

            panelProducts =
                new System.Windows.Forms.Panel();

            tabControlInfo =
                new System.Windows.Forms.TabControl();

            tabCustomer =
                new System.Windows.Forms.TabPage();

            tabShipping =
                new System.Windows.Forms.TabPage();

            lblCustomerName =
                new System.Windows.Forms.Label();

            lblPhone =
                new System.Windows.Forms.Label();

            lblAddress =
                new System.Windows.Forms.Label();

            txtCustomerName =
                new System.Windows.Forms.TextBox();

            txtPhone =
                new System.Windows.Forms.TextBox();

            txtAddress =
                new System.Windows.Forms.TextBox();

            lblShipping =
                new System.Windows.Forms.Label();

            cboShipping =
                new System.Windows.Forms.ComboBox();

            lblTitle =
                new System.Windows.Forms.Label();

            dgvProducts =
                new System.Windows.Forms.DataGridView();

            colProductName =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            colQuantity =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            colWeight =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            colPrice =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            colTotal =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            btnAdd =
                new System.Windows.Forms.Button();

            btnDelete =
                new System.Windows.Forms.Button();

            btnSave =
                new System.Windows.Forms.Button();

            btnClear =
                new System.Windows.Forms.Button();

            statusStrip =
                new System.Windows.Forms.StatusStrip();

            lblTime =
                new System.Windows.Forms.ToolStripStatusLabel();

            lblQuantity =
                new System.Windows.Forms.ToolStripStatusLabel();

            lblWeight =
                new System.Windows.Forms.ToolStripStatusLabel();

            lblMoney =
                new System.Windows.Forms.ToolStripStatusLabel();

            errorProvider =
                new System.Windows.Forms.ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)
                (splitContainerMain)).BeginInit();

            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();

            panelCustomer.SuspendLayout();
            panelProducts.SuspendLayout();

            tabControlInfo.SuspendLayout();
            tabCustomer.SuspendLayout();
            tabShipping.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (dgvProducts)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (errorProvider)).BeginInit();

            SuspendLayout();

            // FORM
            AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            BackColor =
                System.Drawing.Color.White;

            ClientSize =
                new System.Drawing.Size(1350, 760);

            MinimumSize =
                new System.Drawing.Size(1050, 650);

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            Text =
                "Delivery Order Dashboard";

            FormClosing +=
                Form1_FormClosing;

            // SPLIT CONTAINER
            splitContainerMain.Dock =
                System.Windows.Forms.DockStyle.Fill;

            splitContainerMain.Orientation =
                System.Windows.Forms.Orientation.Vertical;

            splitContainerMain.SplitterDistance = 330;

            splitContainerMain.IsSplitterFixed = false;

            // LEFT PANEL
            panelCustomer.Dock =
                System.Windows.Forms.DockStyle.Fill;

            panelCustomer.Padding =
                new System.Windows.Forms.Padding(12);

            panelCustomer.BackColor =
                System.Drawing.Color.FromArgb(
                    245,
                    247,
                    250
                );

            // RIGHT PANEL
            panelProducts.Dock =
                System.Windows.Forms.DockStyle.Fill;

            panelProducts.Padding =
                new System.Windows.Forms.Padding(15);

            panelProducts.BackColor =
                System.Drawing.Color.White;

            // TAB CONTROL
            tabControlInfo.Dock =
                System.Windows.Forms.DockStyle.Fill;

            tabControlInfo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );

            // CUSTOMER TAB
            tabCustomer.Text =
                "Khách hàng";

            tabCustomer.Padding =
                new System.Windows.Forms.Padding(12);

            // CUSTOMER NAME
            lblCustomerName.AutoSize = true;

            lblCustomerName.Location =
                new System.Drawing.Point(
                    15,
                    20
                );

            lblCustomerName.Text =
                "Tên khách hàng:";

            lblCustomerName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            txtCustomerName.Location =
                new System.Drawing.Point(
                    15,
                    50
                );

            txtCustomerName.Size =
                new System.Drawing.Size(
                    280,
                    30
                );

            txtCustomerName.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // PHONE
            lblPhone.AutoSize = true;

            lblPhone.Location =
                new System.Drawing.Point(
                    15,
                    100
                );

            lblPhone.Text =
                "Số điện thoại:";

            lblPhone.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            txtPhone.Location =
                new System.Drawing.Point(
                    15,
                    130
                );

            txtPhone.Size =
                new System.Drawing.Size(
                    280,
                    30
                );

            txtPhone.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // ADDRESS
            lblAddress.AutoSize = true;

            lblAddress.Location =
                new System.Drawing.Point(
                    15,
                    180
                );

            lblAddress.Text =
                "Địa chỉ:";

            lblAddress.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            txtAddress.Location =
                new System.Drawing.Point(
                    15,
                    210
                );

            txtAddress.Size =
                new System.Drawing.Size(
                    280,
                    100
                );

            txtAddress.Multiline = true;

            txtAddress.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            txtAddress.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            tabCustomer.Controls.Add(
                lblCustomerName
            );

            tabCustomer.Controls.Add(
                txtCustomerName
            );

            tabCustomer.Controls.Add(
                lblPhone
            );

            tabCustomer.Controls.Add(
                txtPhone
            );

            tabCustomer.Controls.Add(
                lblAddress
            );

            tabCustomer.Controls.Add(
                txtAddress
            );

            // SHIPPING TAB
            tabShipping.Text =
                "Vận chuyển";

            tabShipping.Padding =
                new System.Windows.Forms.Padding(12);

            lblShipping.AutoSize = true;

            lblShipping.Location =
                new System.Drawing.Point(
                    15,
                    25
                );

            lblShipping.Text =
                "Loại vận chuyển:";

            lblShipping.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            cboShipping.Location =
                new System.Drawing.Point(
                    15,
                    60
                );

            cboShipping.Size =
                new System.Drawing.Size(
                    280,
                    30
                );

            cboShipping.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            cboShipping.Items.AddRange(
                new object[]
                {
                    "Giao hàng tiêu chuẩn",
                    "Giao hàng nhanh",
                    "Giao hàng hỏa tốc"
                }
            );

            cboShipping.SelectedIndex = 0;

            cboShipping.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            tabShipping.Controls.Add(
                lblShipping
            );

            tabShipping.Controls.Add(
                cboShipping
            );

            tabControlInfo.Controls.Add(
                tabCustomer
            );

            tabControlInfo.Controls.Add(
                tabShipping
            );

            panelCustomer.Controls.Add(
                tabControlInfo
            );

            // TITLE
            lblTitle.AutoSize = true;

            lblTitle.Location =
                new System.Drawing.Point(
                    15,
                    12
                );

            lblTitle.Text =
                "DANH SÁCH ĐƠN HÀNG";

            lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold
                );

            // DATAGRIDVIEW
            dgvProducts.Location =
                new System.Drawing.Point(
                    15,
                    60
                );

            dgvProducts.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            dgvProducts.BackgroundColor =
                System.Drawing.Color.White;

            dgvProducts.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            dgvProducts.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            dgvProducts.AllowUserToAddRows = true;

            dgvProducts.AllowUserToDeleteRows = true;

            dgvProducts.AllowUserToResizeRows = false;

            dgvProducts.AllowUserToOrderColumns = false;

            dgvProducts.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.EditMode =
                System.Windows.Forms.DataGridViewEditMode.EditOnEnter;

            dgvProducts.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.MultiSelect = false;

            dgvProducts.RowHeadersVisible = false;

            dgvProducts.RowTemplate.Height = 38;

            dgvProducts.ColumnHeadersHeight = 48;

            dgvProducts.DefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );

            dgvProducts.DefaultCellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.CellValueChanged +=
                dgvProducts_CellValueChanged;

            dgvProducts.CellEndEdit +=
                dgvProducts_CellEndEdit;

            dgvProducts.RowsRemoved +=
                dgvProducts_RowsRemoved;

            dgvProducts.DefaultValuesNeeded +=
                dgvProducts_DefaultValuesNeeded;

            dgvProducts.EditingControlShowing +=
                dgvProducts_EditingControlShowing;

            dgvProducts.KeyDown +=
                dgvProducts_KeyDown;

            // COLUMN 1
            colProductName.HeaderText =
                "Tên hàng";

            colProductName.Name =
                "colProductName";

            colProductName.FillWeight = 180;

            colProductName.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            colProductName.DefaultCellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            // COLUMN 2
            colQuantity.HeaderText =
                "Số lượng";

            colQuantity.Name =
                "colQuantity";

            colQuantity.FillWeight = 80;

            colQuantity.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            // COLUMN 3
            colWeight.HeaderText =
                "Trọng lượng (kg)";

            colWeight.Name =
                "colWeight";

            colWeight.FillWeight = 110;

            colWeight.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            // COLUMN 4
            colPrice.HeaderText =
                "Đơn giá";

            colPrice.Name =
                "colPrice";

            colPrice.FillWeight = 120;

            colPrice.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            // COLUMN 5
            colTotal.HeaderText =
                "Thành tiền";

            colTotal.Name =
                "colTotal";

            colTotal.FillWeight = 140;

            colTotal.ReadOnly = true;

            colTotal.SortMode =
                System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            dgvProducts.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    colProductName,
                    colQuantity,
                    colWeight,
                    colPrice,
                    colTotal
                }
            );

            // BUTTON ADD
            btnAdd.Text =
                "F2 - Thêm dòng";

            btnAdd.Location =
                new System.Drawing.Point(
                    15,
                    600
                );

            btnAdd.Size =
                new System.Drawing.Size(
                    150,
                    45
                );

            btnAdd.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            btnAdd.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            btnAdd.Click +=
                btnAdd_Click;

            // BUTTON DELETE
            btnDelete.Text =
                "Delete - Xóa";

            btnDelete.Location =
                new System.Drawing.Point(
                    175,
                    600
                );

            btnDelete.Size =
                new System.Drawing.Size(
                    135,
                    45
                );

            btnDelete.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            btnDelete.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            btnDelete.Click +=
                btnDelete_Click;

            // BUTTON SAVE
            btnSave.Text =
                "Lưu đơn hàng";

            btnSave.Location =
                new System.Drawing.Point(
                    320,
                    600
                );

            btnSave.Size =
                new System.Drawing.Size(
                    145,
                    45
                );

            btnSave.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            btnSave.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            btnSave.Click +=
                btnSave_Click;

            // BUTTON CLEAR
            btnClear.Text =
                "Làm mới";

            btnClear.Location =
                new System.Drawing.Point(
                    475,
                    600
                );

            btnClear.Size =
                new System.Drawing.Size(
                    125,
                    45
                );

            btnClear.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            btnClear.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            btnClear.Click +=
                btnClear_Click;

            panelProducts.Controls.Add(
                lblTitle
            );

            panelProducts.Controls.Add(
                dgvProducts
            );

            panelProducts.Controls.Add(
                btnAdd
            );

            panelProducts.Controls.Add(
                btnDelete
            );

            panelProducts.Controls.Add(
                btnSave
            );

            panelProducts.Controls.Add(
                btnClear
            );

            // STATUS STRIP
            statusStrip.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            statusStrip.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );

            lblTime.Text =
                "Thời gian: " +
                DateTime.Now.ToString(
                    "dd/MM/yyyy HH:mm:ss"
                );

            lblQuantity.Text =
                "Tổng số lượng: 0";

            lblWeight.Text =
                "Tổng trọng lượng: 0 kg";

            lblMoney.Text =
                "Tổng tiền: 0 VNĐ";

            lblTime.BorderSides =
                System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;

            lblQuantity.BorderSides =
                System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;

            lblWeight.BorderSides =
                System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;

            statusStrip.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    lblTime,
                    lblQuantity,
                    lblWeight,
                    lblMoney
                }
            );

            // ERROR PROVIDER
            errorProvider.BlinkStyle =
                System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            // ADD CONTROLS
            splitContainerMain.Panel1.Controls.Add(
                panelCustomer
            );

            splitContainerMain.Panel2.Controls.Add(
                panelProducts
            );

            Controls.Add(
                splitContainerMain
            );

            Controls.Add(
                statusStrip
            );

            // RESUME
            splitContainerMain.Panel1.ResumeLayout(
                false
            );

            splitContainerMain.Panel2.ResumeLayout(
                false
            );

            ((System.ComponentModel.ISupportInitialize)
                (splitContainerMain)).EndInit();

            splitContainerMain.ResumeLayout(
                false
            );

            panelCustomer.ResumeLayout(
                false
            );

            panelProducts.ResumeLayout(
                false
            );

            panelProducts.PerformLayout();

            tabControlInfo.ResumeLayout(
                false
            );

            tabCustomer.ResumeLayout(
                false
            );

            tabCustomer.PerformLayout();

            tabShipping.ResumeLayout(
                false
            );

            tabShipping.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (dgvProducts)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (errorProvider)).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}