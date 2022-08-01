using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace PrimaSGBD
{
    public partial class Form1 : Form
    {
        public static string SetValueForText1 = "";
        public string del = "";
        public OracleConnection conn = new OracleConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "user id=system; password=sgbd; data source=xe;";
            UmpleComboBox();
            btnLogOut.Visible = false;
            lblNumeUser.Visible = false;
            panel1.Visible = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.ConnectionString = "User Id=" + cmbUser.Text +
                                    ";Password=" + txtParola.Text +
                                    ";Data Source=xe;";
            
            try
            {
                conn.Open();
                panel1.Visible = true;
                vizibilitateCampuri(false);
                IncarcaTabele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tabele_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdaugaSursaDataGrids();
            CHECKTEXT();
            CHECK2ATRIBUTE();
            CHECK2CSAcelasiTabel();
            CHECKCSTabel1_Tabel1();
            lblOp.Text = tabele.SelectedItem.ToString();
        }
     
        private void UmpleComboBox()
        {
            conn.Open();
            string sql = "SELECT username FROM all_users WHERE created>='02/feb/2021'";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbUser.Items.Add(dr.GetString(0));
            }
        }
        private void CHECK2ATRIBUTE()
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            string sql = @"SELECT ucc.column_name
                         FROM user_constraints uc
                         LEFT JOIN user_cons_columns ucc ON ucc.constraint_name = uc.constraint_name
                         WHERE uc.constraint_type = 'R' AND ucc.table_name='" + tabele.SelectedItem.ToString() + "'" +
                         "ORDER BY ucc.column_name ";
            string sql1 = @"SELECT DISTINCT ucc.column_name
                         FROM user_constraints uc
                         LEFT JOIN user_cons_columns ucc ON ucc.constraint_name = uc.constraint_name
                         WHERE uc.constraint_type = 'R' AND ucc.table_name='" + tabele.SelectedItem.ToString() + "'" +
                         "ORDER BY ucc.column_name ";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            OracleCommand cmd1 = new OracleCommand(sql1, conn);
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr1 = cmd1.ExecuteReader();

            while (dr.Read())
            {
               listBox2.Items.Add(dr.GetString(0));
            }
            while (dr1.Read())
            {
                listBox3.Items.Add(dr1.GetString(0));
            }

            for (int i = 0; i < listBox2.Items.Count - 1 ; i++)
            {
                if (listBox2.Items[i] == listBox2.Items[i + 1])
                {
                   textBox2.Text = (string)listBox2.Items[i + 1];
                }
            }

            if (listBox2.Items.Count > listBox3.Items.Count)
            {
                MessageBox.Show("Cheia Straina " + textBox2.Text + " este legata de 2 atribute. Te oblig sa o stergi ! "," ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void CHECKTEXT()
        {
            listBox1.Items.Clear();
            listfk.Items.Clear();
            string sql = @"SELECT data_type
                         FROM user_tab_columns 
                         WHERE table_name = 'ANGAJATI'  AND data_type='VARCHAR2'
                         AND column_name=ANY
                         (SELECT ucc.column_name FROM user_cons_columns ucc
                         LEFT JOIN user_constraints uc ON ucc.constraint_name = uc.constraint_name
                         WHERE uc.constraint_type = 'R' AND ucc.table_name='" + tabele.SelectedItem.ToString() + "' )";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listBox1.Items.Add(dr.GetString(0));
            }

            string sql1 = @"SELECT column_name
                          FROM user_tab_columns
                          WHERE data_type='VARCHAR2'AND column_name=ANY
                          (SELECT ucc.column_name FROM user_cons_columns ucc
                          LEFT JOIN user_constraints uc ON ucc.constraint_name = uc.constraint_name
                          WHERE uc.constraint_type = 'R' AND ucc.table_name='ANGAJATI')";
            OracleCommand cmd1 = new OracleCommand(sql1, conn);
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr1 = cmd1.ExecuteReader();


            while (dr1.Read())
            {
                listfk.Items.Add(dr1.GetString(0));
            }


            if (listBox1.Items.Count > 0)
            {
                MessageBox.Show("Cheia Straina de pe coloana " + listfk.Items[0] + " este GRESITA", " ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CHECK2CSAcelasiTabel()
        {
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            string sql = @"SELECT cons_r.table_name
                        FROM user_constraints cons
                        LEFT JOIN user_cons_columns cols ON cols.constraint_name = cons.constraint_name
                        LEFT JOIN user_constraints cons_r ON cons_r.constraint_name = cons.r_constraint_name
                        LEFT JOIN user_cons_columns cols_r ON cols_r.constraint_name = cons.r_constraint_name
                        WHERE cols_r.column_name IS NOT NULL AND cons.table_name='" + tabele.SelectedItem.ToString() + "'";
            string sql1 = @"SELECT distinct cons_r.table_name
                        FROM user_constraints cons
                        LEFT JOIN user_cons_columns cols ON cols.constraint_name = cons.constraint_name
                        LEFT JOIN user_constraints cons_r ON cons_r.constraint_name = cons.r_constraint_name
                        LEFT JOIN user_cons_columns cols_r ON cols_r.constraint_name = cons.r_constraint_name
                        WHERE cols_r.column_name IS NOT NULL AND cons.table_name='" + tabele.SelectedItem.ToString() + "'";
                      
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            OracleCommand cmd1 = new OracleCommand(sql1, conn);
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr1 = cmd1.ExecuteReader();

            while (dr.Read())
            {
                listBox4.Items.Add(dr.GetString(0));
            }
            while (dr1.Read())
            {
                listBox5.Items.Add(dr1.GetString(0));
            }

            for (int i = 1; i < listBox4.Items.Count - 1; i++)
            {
                if (listBox4.Items[i-1] == listBox4.Items[i])
                {
                    textBox3.Text = (string)listBox4.Items[i + 1];
                }
            }

            if (listBox4.Items.Count > listBox5.Items.Count)
            {
                MessageBox.Show("Exista 2 Chei Straine care sunt referite in acelasi tabel. Te oblig sa o stergi ! ", " ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CHECKCSTabel1_Tabel1()
        {
            listBox6.Items.Clear();
            string sql = @"SELECT
                        cons_r.table_name
                        FROM user_constraints cons
                        LEFT JOIN user_cons_columns cols ON cols.constraint_name = cons.constraint_name
                        LEFT JOIN user_constraints cons_r ON cons_r.constraint_name = cons.r_constraint_name
                        LEFT JOIN user_cons_columns cols_r ON cols_r.constraint_name = cons.r_constraint_name
                        WHERE cols_r.column_name IS NOT NULL AND cons_r.table_name=cons.table_name AND cons.table_name='" + tabele.SelectedItem.ToString() + "'";

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                listBox6.Items.Add(dr.GetString(0));
            }
           
            if(listBox6.Items.Count > 0)
            {
                MessageBox.Show("Exista Cheie Straina referita in acelasi tabel. Corecteaza sau Sterge !", " ATENTIE", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AdaugaSursaDataGrids()
        {
            string sql = "SELECT column_name,data_type,nullable FROM user_tab_cols WHERE table_name ='" + tabele.SelectedItem.ToString() + "'";
            
            DataTable table = new DataTable();
            dgv.DataSource = table;
            table.Columns.Add("Nume Coloana", typeof(String));
            table.Columns.Add("Tip Date", typeof(String));
            table.Columns.Add("NULL", typeof(String));

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    table.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                }

            string sql1 = @"SELECT ucc.column_name,ucc.constraint_name FROM user_cons_columns ucc
                            LEFT JOIN user_constraints uc ON ucc.constraint_name = uc.constraint_name
                            WHERE uc.constraint_type = 'R' AND ucc.table_name='" + tabele.SelectedItem.ToString() + @"'
                            ORDER BY ucc.column_name";

            DataTable table1 = new DataTable();
            dgv1.DataSource = table1;
            table1.Columns.Add("Coloana CS", typeof(String));
            table1.Columns.Add("Nume Constrangere", typeof(String));
            OracleCommand cmd1 = new OracleCommand(sql1, conn);
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                table1.Rows.Add(dr1.GetString(0),dr1.GetString(1));
            }

            string sql2 = @"SELECT
                        cols_r.column_name,cons_r.table_name
                        FROM user_constraints cons
                        LEFT JOIN user_cons_columns cols ON cols.constraint_name = cons.constraint_name
                        LEFT JOIN user_constraints cons_r ON cons_r.constraint_name = cons.r_constraint_name
                        LEFT JOIN user_cons_columns cols_r ON cols_r.constraint_name = cons.r_constraint_name
                        WHERE cols_r.column_name IS NOT NULL AND cons.table_name='" + tabele.SelectedItem.ToString() + @"' 
                        ORDER BY COLS.COLUMN_NAME ";

            DataTable table2 = new DataTable();
            dgv2.DataSource = table2;
            table2.Columns.Add("Coloana Referita", typeof(String));
            table2.Columns.Add("Nume Tabel", typeof(String));
            OracleCommand cmd2 = new OracleCommand(sql2, conn);
            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                table2.Rows.Add(dr2.GetString(0), dr2.GetString(1));

            }

            OracleCommand cmd3 = new OracleCommand("SELECT * FROM " + tabele.SelectedItem.ToString() + "", conn);
            cmd3.CommandType = CommandType.Text;
            OracleDataReader reader = cmd3.ExecuteReader();
            DataTable table3 = new DataTable();
            table3.Load(reader);
            dgv3.DataSource = table3;
        }

        private void vizibilitateCampuri(bool v)
        { 
            btnLogOut.Visible = !v;
            btnConnect.Visible = v;
            cmbUser.Visible = v;
            txtParola.Visible = v;
            lblParola.Visible = v; 
            lblNumeUser.Visible = !v;
            lblNumeUser.Text = cmbUser.Text;
            btnLogOut.Visible = !v;
            cmbUser.SelectedItem = -1;
            txtParola.Clear();
        }

        private void IncarcaTabele()
        {
            tabele.Items.Clear();
            string sql = "select table_name from tabs";
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tabele.Items.Add(dr.GetString(0));
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            del = dgv1.Rows[dgv1.CurrentRow.Index].Cells["Nume Constrangere"].Value.ToString();
        }

        private void btnAddFK_Click(object sender, EventArgs e)
        {
            SetValueForText1 = lblNumeUser.Text;
            Form2 form = new Form2();
            form.Show();
        }

        private void btnStergeCS_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Alter table " + tabele.SelectedItem.ToString() + " DROP CONSTRAINT " + del + "";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Constrangere stearsa cu SUCCES!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            conn.Close();
            tabele.Items.Clear();
            vizibilitateCampuri(true);
            panel1.Visible = false;
        }

        //private bool validareCampuriObligatorii()
        //{
        //    if (cmbUser.Text == "")
        //    {
        //        MessageBox.Show("Alegeti User !");
        //        cmbUser.Focus();
        //        return false;
        //    }
        //    if (txtParola.Text == "")
        //    {
        //        MessageBox.Show("Completati Parola !");
        //        txtParola.Focus();
        //        return false;
        //    }

        //    return true;
        //}
    }

}

