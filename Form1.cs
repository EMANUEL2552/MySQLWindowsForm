using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GravarDadosMYSQL



{
    public partial class Form1 : Form

    {
        private MySqlConnection conexao;
        private string data_source = "datasource=localhost;" +
                    "username=root;password=1234;database=contatos";

        public Form1()
        {
            InitializeComponent();

            list_contatos.View = View.Details;
            list_contatos.LabelEdit = true;
            list_contatos.AllowColumnReorder = true;    
            list_contatos.FullRowSelect = true;
            list_contatos.GridLines = true;

            list_contatos.Columns.Add("ID" , 30, HorizontalAlignment.Left);
            list_contatos.Columns.Add("nome", 150, HorizontalAlignment.Left);
            list_contatos.Columns.Add("telefone", 150, HorizontalAlignment.Left);
            list_contatos.Columns.Add("email", 150, HorizontalAlignment.Left);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                //criar conexao com mysql
                conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO informacoes_contato (nome,email, telefone ) " +
                       "VALUES('" + txtNome.Text + "', '"
                    + txtTelefone.Text + "', '" + txtEmail.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                comando.ExecuteReader();

                MessageBox.Show("contato inserido");



                //executar comando insert

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtBuscar.Text + "%'";
                conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                   " FROM informacoes_contato " +
                   "WHERE nome LIKE " + q + "OR email LIKE " + q;

                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                
                MySqlDataReader reader =  comando.ExecuteReader();
                list_contatos.Items.Clear();

                while (reader.Read()) 
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                    var linha_listview = new ListViewItem(row);

                    list_contatos.Items.Add(linha_listview);
                }

                              
                               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally 
            {
                conexao.Close();
            }
        }
    }
}