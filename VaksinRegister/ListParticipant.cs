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
    public partial class ListParticipant : Form
    {
        DataTable dt = new DataTable();
        private readonly RegisterVaksined fmafter;
        private readonly RegistrationCheck fmabefore;
        public ListParticipant(RegisterVaksined after,RegistrationCheck before)
        {
            InitializeComponent();
            ShowData();
            fmafter = after;
            fmabefore = before;
        }

        private void ShowData()
        {

            string qr;

     
            qr = "select replace(No_vak,' ','') as no_vak,Name from Participant_vaccine where period='"+Function.Period+"' order by No_vak ";
            
            dt = Function.GetDataTable(qr);
            Dgv.AutoGenerateColumns = false;
            Dgv.DataSource = dt;
            Dgv.Columns[0].DataPropertyName = "no_vak";
            Dgv.Columns[1].DataPropertyName = "Name";

        }

        private void Txt_nama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Name like '%{0}%' or no_vak like '%{1}%'", Txt_nama.Text, Txt_nama.Text);
                Dgv.DataSource = dv;

            }
            catch (Exception)
            {

            }
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
      
     
            string no = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            if (fmafter == null)
            {
                fmabefore.Txt_scan_nik.Text = no;
            }
            else
            {
                fmafter.Txt_scan_nik.Text = no;
            }

            if (!String.IsNullOrEmpty(no))
                this.Close();


            
        }
    }
}
