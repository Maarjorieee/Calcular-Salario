namespace Calcular_Salario
{
    public partial class CalculoDoSalario : Form
    {
        public CalculoDoSalario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularSalario calcularSalario = new CalcularSalario();

            calcularSalario.CPF = mtbCPF.Text;
            calcularSalario.Nome = txtNome.Text;
            calcularSalario.ValorHora = double.Parse(txtValorHora.Text);
            calcularSalario.HorasTrabalhadas = int.Parse(txtHorasTrabalhadas.Text);

            calcularSalario.CalculoDoSalario();

            txtSalario.Text = calcularSalario.Salario.ToString();
        }
    }
}