using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;

namespace RadioPlayer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            notifyIcon1.Icon = new Icon(GetType(), "placeholder.ico");
        }
        string nomeRadio;
        string IPRadio;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool allowVisible = true;
        private bool allowClose;
        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);       }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dtGrid_Radios.DataSource = GetAll();
            cbb_filtro.DataSource = GetFiltros();
          
        }
        public List<Radio> GetAll()
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                dr = db.ExecuteReader("select * from tb_listRadio");
                
                List<Radio> radioList = new List<Radio>();
                while (dr.Read())
                {
                    Radio radio = new Radio();
                    radio.nomeRadio = Convert.ToString(dr["nome"]);
                    radio.IpRadio = Convert.ToString(dr["Ip"]);
                    radio.genero = Convert.ToString(dr["genero"]);
                    radio.pais = Convert.ToString(dr["pais"]);
                    radioList.Add(radio);
                }
                return radioList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }
        }
        public List<string> GetFiltros()
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                dr = db.ExecuteReader("SELECT genero FROM tb_listRadio GROUP BY genero");

                List<string> generoList = new List<string>();
                generoList.Add("TODOS");
                while (dr.Read())
                {
                  generoList.Add(Convert.ToString(dr["genero"]));
                }
                return generoList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }
        }       
        public List<Radio> GetFiltro(string filtro)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@genero", filtro, DbType.String);               
                dr = db.ExecuteReader("SELECT * FROM tb_listRadio WHERE genero = @genero");

                List<Radio> radioList = new List<Radio>();
                while (dr.Read())
                {
                    Radio radio = new Radio();
                    radio.nomeRadio = Convert.ToString(dr["nome"]);
                    radio.IpRadio = Convert.ToString(dr["Ip"]);
                    radio.genero = Convert.ToString(dr["genero"]);
                    radio.pais = Convert.ToString(dr["pais"]);
                    radioList.Add(radio);
                }
                return radioList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }
        }
        private void DtGrid_Radios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

             nomeRadio = dtGrid_Radios[0, e.RowIndex].Value.ToString();
             IPRadio   = dtGrid_Radios[1, e.RowIndex].Value.ToString();
             txt_ip.Text = IPRadio;
             lbl_radioAtual.Text = "Rádio: " + nomeRadio;
             WindowsMP.settings.autoStart = true;
             WindowsMP.URL = IPRadio;                     

        }

        private void WindowsMP_Enter(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            IPRadio = txt_ip.Text;          
            WindowsMP.settings.autoStart = true;
            WindowsMP.URL = IPRadio;
        }

        private void DtGrid_Radios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeRadio = dtGrid_Radios[0, e.RowIndex].Value.ToString();
            IPRadio = dtGrid_Radios[1, e.RowIndex].Value.ToString();
            txt_ip.Text = IPRadio;
            lbl_radioAtual.Text = "Rádio: " + nomeRadio;
        }

        private void Cbb_filtro_TextChanged(object sender, EventArgs e)
        {
            if (cbb_filtro.Text != " " && cbb_filtro.Text != "TODOS")
            {               
                dtGrid_Radios.DataSource = GetFiltro(cbb_filtro.Text);      
            }
        }

        private void Cbb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            allowVisible = true;
            Show();
        }

        private void Home_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            allowClose = true;
            this.Close();


        }
    }
}
