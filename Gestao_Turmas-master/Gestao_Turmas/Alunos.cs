using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Gestao_Turmas
{
    public partial class Alunos : Form
    {
        C_Alunos auxnovo1 = new();
        List<C_Alunos> info_alunos = new List<C_Alunos>();
        string caminho_a = @"c:\C\Cprojetos\Gestao_Turmas-master\alunos.txt";
        List<C_Turmas> turmas = new List<C_Turmas>();
        string caminho_t = @"c:\C\Cprojetos\Gestao_Turmas-master\turmas.txt";
        public Alunos()
        {
            InitializeComponent();
        }

        public void bt_menu_Click(object sender, EventArgs e)
        {
            Menu anterior = new Menu();
            anterior.Show();
            Hide();
        }

        public void bt_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_nome_alunos.Text != "" && txt_email_alunos.Text != "" && txt_contacto_alunos.Text != "" && txt_num_aluno.Text != "" && check_genero.CheckedItems.Count != 0)
            {
                var alfa = int.TryParse(txt_nome_alunos.Text, out _);
                if (alfa)
                {
                    MessageBox.Show("Introduza apenas letras!", "Nome Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    auxnovo1.Nome = txt_nome_alunos.Text;
                }

                if (txt_email_alunos.Text.Contains('@'))
                {
                    auxnovo1.Email = txt_email_alunos.Text;
                }
                else
                {
                    MessageBox.Show("Introduza um formato correto", "Email Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                auxnovo1.Contacto = txt_contacto_alunos.Text;
                auxnovo1.Data_Nascimento = dt_nasc.Value;

                var numerico = int.TryParse(txt_num_aluno.Text, out _);
                if (numerico)
                {
                    auxnovo1.Número_Aluno = Convert.ToInt32(txt_num_aluno.Text);
                }
                else
                {
                    MessageBox.Show("Introduza apenas números", "Número de Aluno Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Deseja adicionar as informações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    info_alunos.Add(auxnovo1);
                }
                foreach (string item_check in check_genero.CheckedItems)
                {
                    auxnovo1.Género = item_check;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            serial();
            dgv_alunos.ClearSelection();
        }

        public void Alunos_Load(object sender, EventArgs e)
        {
            dt_nasc.MaxDate = DateTime.Now.Date.AddDays(-365);
            dt_nasc.Value = dt_nasc.MaxDate;

            check_genero.Items.Add("Masculino");
            check_genero.Items.Add("Feminino");
            check_genero.CheckedItems.Contains("Masculino");
            check_genero.CheckedItems.Contains("Feminino");

            string auxtxt = string.Empty;
            string auxtxt2 = string.Empty;
            try
            {
                auxtxt = File.ReadAllText(caminho_a);
                auxtxt2 = File.ReadAllText(caminho_t);
            }
            catch (Exception ex){ }
            if (auxtxt.Length > 0)
            {
                info_alunos = JsonSerializer.Deserialize<List<C_Alunos>>(auxtxt);
            }
            if (auxtxt2.Length > 0)
            {
                turmas = JsonSerializer.Deserialize<List<C_Turmas>>(auxtxt2);
            }

            foreach (var item in turmas)
            {
                cb_turmas.Items.Add(item.Nome_Turma);
            }

            dgv_alunos.DataSource = info_alunos;
            dgv_alunos.ClearSelection();

        }
        
        private void serial() 
        {
            string auxlista = JsonSerializer.Serialize(info_alunos);
            File.WriteAllText(caminho_a, auxlista);
            string aux_txt = File.ReadAllText(caminho_a);
            info_alunos = JsonSerializer.Deserialize<List<C_Alunos>>(aux_txt);
            dgv_alunos.DataSource = info_alunos;
        }
        private void cb_turmas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void check_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemx = 0; itemx < check_genero.CheckedItems.Count; itemx++)
            {
                if (itemx != check_genero.SelectedIndex)
                {
                    check_genero.SetItemCheckState(itemx, CheckState.Unchecked);
                }
            }
        }

        private void dgv_alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_r = dgv_alunos.CurrentRow.Index;
            txt_nome_alunos.Text = info_alunos[index_r].Nome;
            txt_email_alunos.Text = info_alunos[index_r].Email;
            txt_contacto_alunos.Text = info_alunos[index_r].Contacto;
            dt_nasc.Value = Convert.ToDateTime(info_alunos[index_r].Data_Nascimento);
            txt_num_aluno.Text = Convert.ToString(info_alunos[index_r].Número_Aluno);
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            if (dgv_alunos.SelectedCells.Count >= 1)
            {
                var numerico = int.TryParse(txt_num_aluno.Text, out _);
                if (numerico)
                {
                    if (MessageBox.Show("Deseja editar as informações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int index_c = dgv_alunos.CurrentCell.RowIndex;
                        info_alunos[index_c].Nome = txt_nome_alunos.Text;
                        info_alunos[index_c].Email = txt_email_alunos.Text;
                        info_alunos[index_c].Contacto = txt_contacto_alunos.Text;
                        info_alunos[index_c].Turma = cb_turmas.Text;
                        info_alunos[index_c].Data_Nascimento = dt_nasc.Value;
                        foreach (string item_check in check_genero.CheckedItems)
                        {
                            info_alunos[index_c].Género = item_check;
                        }
                        info_alunos[index_c].Número_Aluno = Convert.ToInt32(txt_num_aluno.Text);
                    }
                else
                {
                    MessageBox.Show("Introduza apenas números", "Número de Aluno Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            serial();
            dgv_alunos.ClearSelection();

                }
            }
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            if (dgv_alunos.CurrentRow != null)
            {
                if (MessageBox.Show("Deseja remover as informações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    info_alunos.RemoveAt(dgv_alunos.CurrentRow.Index);
                    txt_nome_alunos.Text = string.Empty;
                    dt_nasc.Value = dt_nasc.MaxDate;
                    check_genero.Text = string.Empty;
                    txt_email_alunos.Text = string.Empty;
                    txt_contacto_alunos.Text = string.Empty;
                    cb_turmas.Text = string.Empty;

                }
            }
            serial();
            dgv_alunos.ClearSelection();
        }

        private void cb_turmas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void search_nome_TextChanged(object sender, EventArgs e)
        {
            var auxprocura = procurar_turma.Text;
            if (procurar_turma.Text == "")
            {
                dgv_alunos.DataSource = info_alunos;
            }
            else
            {
                dgv_alunos.DataSource = info_alunos.Where(x => x.Turma.Contains(auxprocura)).ToList();
            }
        }
    }
}
