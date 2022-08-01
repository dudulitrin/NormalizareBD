using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PrimaSGBD
{
    public partial class Form2 : Form
    {
        
        public OracleConnection conn = new OracleConnection();
        public Form2()

        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            String user = Form1.SetValueForText1;
            conn.ConnectionString = "user id="+user+"; password=sgbd; data source=xe;";
            conn.Open();
            PopuleazaComboBox();
        }
        private void PopuleazaComboBox()
        {

            string sql = "select table_name from tabs";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                cmbTabel1.Items.Add(dr.GetString(0));
                cmbTabel2.Items.Add(dr.GetString(0));
            }

        }

        private void cmbTabel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbColoana1.Items.Clear();
            cmbColoana1.ResetText();
            string sql = "select column_name from user_tab_cols where table_name ='" + cmbTabel1.SelectedItem.ToString() + "'";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
                cmbColoana1.Items.Add(dr.GetString(0));
               

            }
            cmbColoana1.SelectedIndex = 0;
        }

        private void cmbTabel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbColoana2.Items.Clear();
            cmbColoana2.ResetText();
            string sql = "select column_name from user_tab_cols where table_name ='" + cmbTabel2.SelectedItem.ToString() + "'";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbColoana2.Items.Add(dr.GetString(0));
                

            }
            cmbColoana2.SelectedIndex = 0;
        }

        public void btnAdaugaFK_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "ALTER TABLE " + cmbTabel1.SelectedItem.ToString() + @"
                          ADD CONSTRAINT FK_" + cmbColoana1.SelectedItem.ToString() +"_"+cmbColoana2.SelectedItem.ToString() + @"
                          FOREIGN KEY (" + cmbColoana1.SelectedItem.ToString() + @")
                          REFERENCES " + cmbTabel2.SelectedItem.ToString() + "(" + cmbColoana2.SelectedItem.ToString() +") ";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteReader();
                MessageBox.Show("FK Adaugat !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }
           
        }
    }
}
