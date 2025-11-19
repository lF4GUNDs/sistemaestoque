using controleEstoque.entity;
using MySql.Data.MySqlClient;

namespace controleEstoque
{

    public partial class formPrincipal : Form
    {
        private Form? frmAtivo;


        public formPrincipal()
        {
            InitializeComponent();
            MaximizarFormulario();
            //  this.WindowState = FormWindowState.Maximized;
            timer1.Start();


        }


        private void MaximizarFormulario()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

        }

        public void ususariologado(String usuariologado)
        {
            labelUsuario.Text = usuariologado;
        }


        public void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        public void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();

            }
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelSideMenu.Controls)
            {
                ctrl.ForeColor = Color.Black;

                frmAtivo.ForeColor = Color.Red;
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            // ActiveButton(btnHome);
            ActiveFormClose();
        }

        private void btnProduto_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnProduto);
            FormShow(new formProdutos());
        }

        private void labelEstoque_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            ActiveButton(btnFuncionario);
            FormShow(new FuncionariosForms());

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formPrincipal_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja sair do sistema?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                Application.Exit();
            }

        }

        private void bntEntrada_Click(object sender, EventArgs e)
        {
            ActiveButton(bntEntrada);
            FormShow(new EntradaProdutosForm());
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            ActiveButton(btnRelatorioSaida);
            FormShow(new MovimentaEstoqueSaida());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ActiveButton(btnFornecedor);
            FormShow(new FornecedorFormPrincipal());


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnRelatorioEntrada_Click(object sender, EventArgs e)
        {
            ActiveButton(btnRelatorioEntrada);
            FormShow(new MovimentaEstoqueEntradaForms());
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEstoque);
            FormShow(new EstoqueForms());
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSaida);
            FormShow(new SaidaDeProdutos());
        }

    }
}