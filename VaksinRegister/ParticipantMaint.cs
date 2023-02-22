using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaksinRegister.Classes;

namespace VaksinRegister
{
    public partial class ParticipantMaint : Form
    {
        DataTable dt = new DataTable();
        string a;
        public ParticipantMaint(string b)
        {
            Function.CreateConn();
            InitializeComponent();
            a = b;
            ShowData(b);
        }

        private void ShowData(string b)
        {

            string qr;

            if (b == "1")
            {
                qr = "select nik as No_vak,Name,'Booster' as status from Emp_vaccinated_new where convert(date,entdate)='"+Function.Period+ "' ORDER BY EntDate DESC";
            }
            else
            {
                qr = "select No_vak,Name, case when Flag=1 then 'PESERTA MASUK' else 'BELUM' end as status from Participant_vaccine where Period='" + Function.Period + "' ORDER BY EntDate DESC";
            }
            
            dt = Function.GetDataTable(qr);
            Dgv.AutoGenerateColumns = false;
            Dgv.DataSource = dt;
            Dgv.Columns[0].DataPropertyName = "No_vak";
            Dgv.Columns[1].DataPropertyName = "Name";
            Dgv.Columns[2].DataPropertyName = "status";
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (Dgv.Rows[rowIndex].Cells[3].Selected == true && Dgv.Columns[columnIndex].Name == "Column4")
            {
                string no = Dgv.Rows[rowIndex].Cells[0].Value.ToString();

                const string message = "Are You Sure You Want To Delete?";
                const string caption = "Confirmation";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    if (a == "2")
                    {

                        if (Function.EXEcuteQuery("update Participant_vaccine set flag=0 where period='" + Function.Period + "' and no_vak='" + no + "'"))
                        {
                            ShowData(a);
                        }
                        else
                        {
                            MessageBox.Show("GAGAL MENGHAPUS", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (Function.EXEcuteQuery("delete Emp_vaccinated_new where nik='" + no + "'"))
                        {
                            ShowData(a);
                        }
                        else
                        {
                            MessageBox.Show("GAGAL MENGHAPUS", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                 
                }


            }
        }

        private void Txt_nama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Name like '%{0}%' or No_vak like '%{1}%'", Txt_nama.Text, Txt_nama.Text);
                Dgv.DataSource = dv;

            }
            catch (Exception)
            {

            }
        }
    }
}
