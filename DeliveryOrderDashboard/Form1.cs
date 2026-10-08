```csharp
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DeliveryOrderDashboard
{
    public partial class Form1 : Form
    {
        TextBox txtMaDon;
        TextBox txtKhachHang;
        TextBox txtSoDienThoai;
        TextBox txtDiaChi;
        ComboBox cboTrangThai;
        Button btnThem;
        Button btnXoa;
        Button btnLamMoi;
        DataGridView dgvDonHang;
        ErrorProvider errorProvider;
        StatusStrip statusStrip;
        ToolStripStatusLabel lblStatus;

        public Form1()
        {
            InitializeComponent();
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            this.Text = "Delivery Order Dashboard";
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;

            Panel panelTop = new Panel();
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 60;
            panelTop.BackColor = Color.SteelBlue;

            Label lblTitle = new Label();
            lblTitle.Text = "QUẢN LÝ ĐƠN GIAO HÀNG";
            lblTitle.Font = new Font("Arial", 20, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(25, 15);

            panelTop.Controls.Add(lblTitle);

            Panel panelInput = new Panel();
            panelInput.Dock = DockStyle.Left;
            panelInput.Width = 350;
            panelInput.Padding = new Padding(15);
            panelInput.BackColor = Color.WhiteSmoke;

            Label lblMaDon = TaoLabel("Mã đơn hàng:", 20, 20);
            txtMaDon = TaoTextBox(20, 45);

            Label lblKhachHang = TaoLabel("Tên khách hàng:", 20, 90);
            txtKhachHang = TaoTextBox(20, 115);

            Label lblSDT = TaoLabel("Số điện thoại:", 20, 160);
            txtSoDienThoai = TaoTextBox(20, 185);

            Label lblDiaChi = TaoLabel("Địa chỉ:", 20, 230);
            txtDiaChi = TaoTextBox(20, 255);

            Label lblTrangThai = TaoLabel("Trạng thái:", 20, 300);

            cboTrangThai = new ComboBox();
            cboTrangThai.Location = new Point(20, 325);
            cboTrangThai.Width = 280;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Items.Add("Chờ xử lý");
            cboTrangThai.Items.Add("Đang giao");
            cboTrangThai.Items.Add("Đã giao");
            cboTrangThai.Items.Add("Đã hủy");

            btnThem = new Button();
            btnThem.Text = "THÊM ĐƠN HÀNG";
            btnThem.Location = new Point(20, 380);
            btnThem.Size = new Size(130, 40);
            btnThem.Click += BtnThem_Click;

            btnXoa = new Button();
            btnXoa.Text = "XÓA";
            btnXoa.Location = new Point(165, 380);
            btnXoa.Size = new Size(65, 40);
            btnXoa.Click += BtnXoa_Click;

            btnLamMoi = new Button();
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.Location = new Point(235, 380);
            btnLamMoi.Size = new Size(80, 40);
            btnLamMoi.Click += BtnLamMoi_Click;

            panelInput.Controls.Add(lblMaDon);
            panelInput.Controls.Add(txtMaDon);
            panelInput.Controls.Add(lblKhachHang);
            panelInput.Controls.Add(txtKhachHang);
            panelInput.Controls.Add(lblSDT);
            panelInput.Controls.Add(txtSoDienThoai);
            panelInput.Controls.Add(lblDiaChi);
            panelInput.Controls.Add(txtDiaChi);
            panelInput.Controls.Add(lblTrangThai);
            panelInput.Controls.Add(cboTrangThai);
            panelInput.Controls.Add(btnThem);
            panelInput.Controls.Add(btnXoa);
            panelInput.Controls.Add(btnLamMoi);

            dgvDonHang = new DataGridView();
            dgvDonHang.Dock = DockStyle.Fill;
            dgvDonHang.AllowUserToAddRows = false;
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonHang.MultiSelect = false;
            dgvDonHang.ReadOnly = true;

            dgvDonHang.Columns.Add("MaDon", "Mã đơn hàng");
            dgvDonHang.Columns.Add("KhachHang", "Khách hàng");
            dgvDonHang.Columns.Add("SoDienThoai", "Số điện thoại");
            dgvDonHang.Columns.Add("DiaChi", "Địa chỉ");
            dgvDonHang.Columns.Add("TrangThai", "Trạng thái");

            Panel panelGrid = new Panel();
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Padding = new Padding(10);
            panelGrid.Controls.Add(dgvDonHang);

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            statusStrip = new StatusStrip();

            lblStatus = new ToolStripStatusLabel();
            lblStatus.Text = "Sẵn sàng";

            statusStrip.Items.Add(lblStatus);

            this.Controls.Add(panelGrid);
            this.Controls.Add(panelInput);
            this.Controls.Add(panelTop);
            this.Controls.Add(statusStrip);
        }

        private Label TaoLabel(string text, int x, int y)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            label.AutoSize = true;
            label.Font = new Font("Arial", 10, FontStyle.Bold);

            return label;
        }

        private TextBox TaoTextBox(int x, int y)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(x, y);
            textBox.Width = 280;

            return textBox;
        }

        private bool KiemTraDuLieu()
        {
            bool hopLe = true;

            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtMaDon.Text))
            {
                errorProvider.SetError(
                    txtMaDon,
                    "Mã đơn hàng không được để trống!"
                );

                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtKhachHang.Text))
            {
                errorProvider.SetError(
                    txtKhachHang,
                    "Tên khách hàng không được để trống!"
                );

                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                errorProvider.SetError(
                    txtSoDienThoai,
                    "Số điện thoại không được để trống!"
                );

                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                errorProvider.SetError(
                    txtDiaChi,
                    "Địa chỉ không được để trống!"
                );

                hopLe = false;
            }

            if (cboTrangThai.SelectedIndex == -1)
            {
                errorProvider.SetError(
                    cboTrangThai,
                    "Vui lòng chọn trạng thái!"
                );

                hopLe = false;
            }

            if (!hopLe)
            {
                lblStatus.Text = "Dữ liệu không hợp lệ!";
            }
            else
            {
                lblStatus.Text = "Dữ liệu hợp lệ!";
            }

            return hopLe;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra lại các trường bị lỗi!",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            dgvDonHang.Rows.Add(
                txtMaDon.Text,
                txtKhachHang.Text,
                txtSoDienThoai.Text,
                txtDiaChi.Text,
                cboTrangThai.Text
            );

            MessageBox.Show(
                "Thêm đơn hàng thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            lblStatus.Text = "Đã thêm đơn hàng thành công.";

            LamMoi();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn hàng cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            dgvDonHang.Rows.RemoveAt(
                dgvDonHang.SelectedRows[0].Index
            );

            lblStatus.Text = "Đã xóa đơn hàng.";
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaDon.Clear();
            txtKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();

            cboTrangThai.SelectedIndex = -1;

            errorProvider.Clear();

            lblStatus.Text = "Đã làm mới dữ liệu.";

            txtMaDon.Focus();
        }
    }
}
```
