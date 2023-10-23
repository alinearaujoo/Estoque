using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Livre_Dupla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Adicionando itens no combobox
            Cmb_Lote.Items.Add("Lote 000000");
            Cmb_Lote.Items.Add("Lote 000001");
            Cmb_Lote.Items.Add("Lote 000002");
            Cmb_Lote.Items.Add("Lote 000003");
            Cmb_Lote.Items.Add("Lote 000004");
            Cmb_Lote.Items.Add("Lote 000005");

            //Definindo o evento SelectIndexChange para o ComboBox
            Cmb_Lote.SelectedIndexChanged += (comboBox1_SelectedIndexChanged);
        }

        private void Rad_Unissex_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Categorias para aparecer a mensagem na label
            Lbl_Categorias.Text = "Unissex";
            Lbl_Categorias.Visible = true;
        }

        private void Rad_Feminina_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Categorias para aparecer a mensagem na label
            Lbl_Categorias.Text = "Feminina";
            Lbl_Categorias.Visible = true;
        }

        private void Rad_Masculina_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Categorias para aparecer a mensagem na label
            Lbl_Categorias.Text = "Masculino";
            Lbl_Categorias.Visible = true;
        }

        private void Rad_Infantil_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Categorias para aparecer a mensagem na label
            Lbl_Categorias.Text = "Infantil";
            Lbl_Categorias.Visible = true;
        }

        private void Rad_Curto_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Modelos para aparecer a mensagem na label
            Lbl_Modelos.Text = "Cano Curto";
            Lbl_Modelos.Visible = true;

            //Usando IF ELSE para as imagens
            if (Rad_Unissex.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.curto_unissex;
            }

            else if (Rad_Feminina.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.curto_feminina;
            }

            else if (Rad_Masculina.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.curto_masculino;
            }

            else if (Rad_Infantil.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.curto_infantil;
            }
        }

        private void Rad_Medio_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Modelos para aparecer a mensagem na label
            Lbl_Modelos.Text = "Cano Médio";
            Lbl_Modelos.Visible = true;

            //Usando IF ELSE para as imagens
            if (Rad_Unissex.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.medio_unissex;
            }
            
            else if (Rad_Feminina.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.medio_feminino;
            }

            else if (Rad_Masculina.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.medio_masculino;
            }

            else if (Rad_Infantil.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.medio_infantil;
            }
        }

        private void Rad_Alto_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Modelos para aparecer a mensagem na label
            Lbl_Modelos.Text = "Cano Alto";
            Lbl_Modelos.Visible = true;

            //Usando IF ELSE para as imagens
            if (Rad_Unissex.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.alto_unissex;
            }

            else if (Rad_Feminina.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.alto_feminino;
            }

            else if (Rad_Masculina.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.alto_masculino;
            }

            else if (Rad_Infantil.Checked)
            {
                Pic_Imagem.Image = Properties.Resources.alto_infantil;
            }
        }

        private void Rad_1_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Tamanhos para aparecer a mensagem na label
            Lbl_Tamanhos.Text = "17-30";
            Lbl_Tamanhos.Visible = true;
        }

        private void Rad_3_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Tamanhos para aparecer a mensagem na label
            Lbl_Tamanhos.Text = "30-39";
            Lbl_Tamanhos.Visible = true;
        }

        private void Rad_2_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Tamanhos para aparecer a mensagem na label
            Lbl_Tamanhos.Text = "37-42";
            Lbl_Tamanhos.Visible = true;
        }

        private void Rad_4_CheckedChanged(object sender, EventArgs e)
        {
            //Progamando o Rad Button Tamanhos para aparecer a mensagem na label
            Lbl_Tamanhos.Text = "40-46";
            Lbl_Tamanhos.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cmb_Lote_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            //Obtém o valor selecionado no ComboBox
            string categoriaselecionada = Cmb_Lote.SelectedItem.ToString();

            //Atribui o valor selecionado no ComboBox a Label
            Lbl_ComboBox.Text = "Lote 000000";
            Lbl_ComboBox.Text = "Lote 000002";
            Lbl_ComboBox.Text = "Lote 000003";
            Lbl_ComboBox.Text = "Lote 000004";
            Lbl_ComboBox.Text = "Lote 000005";

            //Ativando os RadButton Categorias
            Rad_Unissex.Enabled = true;
            Rad_Feminina.Enabled = true;
            Rad_Masculina.Enabled = true;
            Rad_Infantil.Enabled = true;
          
            

         
        }

        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {
            //Mensagem POUPAP informativa
            
            MessageBox.Show("Solicitação enviada com sucesso!");

            //Apagando o valor do combobox
            Cmb_Lote.Items.Remove("Lote 000000");
            Cmb_Lote.Items.Remove("Lote 000001");
            Cmb_Lote.Items.Remove("Lote 000002");
            Cmb_Lote.Items.Remove("Lote 000003");
            Cmb_Lote.Items.Remove("Lote 000004");
            Cmb_Lote.Items.Remove("Lote 000005");

            //Desativando os Radbutton do GrupoBox Categotias
            Rad_Unissex.Enabled = false;
            Rad_Feminina.Enabled = false;
            Rad_Masculina.Enabled = false;
            Rad_Infantil.Enabled = false;

            //Desativando os Radbutton do GrupoBox Modelos
            Rad_Curto.Enabled = false;
            Rad_Medio.Enabled = false;
            Rad_Alto.Enabled = false;

            //Desativando os Radbutton do GrupoBox Tamanhos
            Rad_17e30.Enabled = false;
            Rad_30e39.Enabled = false;
            Rad_37e42.Enabled = false;
            Rad_40e46.Enabled = false;

            //Apagando o valor da Label do GrupoBox Requisição
            Lbl_ComboBox.Text = "";
            Lbl_Categorias.Text = "";
            Lbl_Modelos.Text = "";
            Lbl_Tamanhos.Text = "";
        }

        private void Lbl_ComboBox_Click(object sender, EventArgs e)
        {

        }

        private void Grp_label_Enter(object sender, EventArgs e)
        {

        }

        private void Lbl_Modelos_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grp_Categorias_Enter(object sender, EventArgs e)
        {
            //Ativando os RadButton do GrupoBox Modelos
            Rad_Curto.Enabled = true;
            Rad_Medio.Enabled = true;
            Rad_Alto.Enabled = true;
        }

        private void Grp_Modelos_Enter(object sender, EventArgs e)
        {
            //Ativando os RadButton do GrupoBox Tamanho
            Rad_17e30.Enabled = true;
            Rad_30e39.Enabled = true;
            Rad_37e42.Enabled = true;
            Rad_40e46.Enabled = true;
        }

        private void Grp_Tamanhos_Enter(object sender, EventArgs e)
        {
            //Ativando o botão solicitar
            Btn_Solicitar.Enabled = true;
        }
    }
}
