namespace Aula13_Atv
{
    public partial class Form1 : Form
    {
        List<Pessoa> Pessoas = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
        }
        void atualiza()
        {
            listView1.Clear();
            for (int i = 0; i < Pessoas.Count; i++)
            {
                listView1.Items.Add(Pessoas[i].nome);
                txtCidade.Clear();
                txtIdade.Clear();
                txtNome.Clear();
                txtRua.Clear();
                txtNome.Focus();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text, rua = txtRua.Text, cidade = txtCidade.Text;
            int idade = int.Parse(txtIdade.Text);

            Pessoa pessoa = new Pessoa(nome, cidade, rua, idade);
            Pessoas.Add(pessoa);
            atualiza();
        }
    }
}