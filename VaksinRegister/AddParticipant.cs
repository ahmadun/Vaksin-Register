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
    public partial class AddParticipant : Form
    {

        private readonly RegistrationCheck fm;
        string dosis;
        public AddParticipant(RegistrationCheck fms)
        {
            InitializeComponent();

            fm = fms;
            IniFile ini = new IniFile(@"C:\DirSystem\SystemVaccine\Configuration.ini");
            dosis = ini.IniReadValue("App", "dosis");
            LbNourut.Text = GenId();
            Txt_nik.Focus();
        }


        private string GenId()
        {
            return Function.EXEScalar("select max(No_vak) from [Participant_vaccine] where len(No_vak)=4 and period='"+Function.Period+"'");
        }

        private Boolean SaveData(string nik,string name)
        {
            string qr;


            qr = "insert [Participant_vaccine] values ";
            qr = qr + " ('"+Function.Period+"','" + nik + "','" + name + "','0',getdate(),null)";


            if (Function.EXEcuteQuery(qr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnSavekar_Click(object sender, EventArgs e)
        {
            if (!Function.EXEcuteCheckData("select count(No_vak) from [Participant_vaccine] where no_vak='" + Txt_nik.Text + "' and period='"+Function.Period+"'"))
            {

                if (SaveData(Txt_nik.Text, Txt_name.Text))
                {

                    fm.LbChecked.Text = (Convert.ToUInt16(fm.LbChecked.Text) + 1).ToString();
                           
                    Txt_nik.SelectAll();

                }
                else
                {
                    MessageBox.Show("Gagal Tersimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
           
        }

        private void BtnPeserta_Click(object sender, EventArgs e)
        {
            if (!Function.EXEcuteCheckData("select count(No_vak) from [Participant_vaccine] where no_vak='" + Txt_peserta.Text + "' and period='"+Function.Period +"'"))
            {

                if (SaveData(Txt_peserta.Text, Txt_peserta_name.Text))
                {

                    fm.LbChecked.Text = (Convert.ToUInt16(fm.LbChecked.Text) + 1).ToString();
                    Txt_nik.SelectAll();
                    LbNourut.Text = Txt_peserta.Text;

                }
                else
                {
                    MessageBox.Show("Gagal Tersimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

     
        private void Txt_nik_TextChanged(object sender, EventArgs e)
        {
            if (Txt_nik.Text.Length == 6)
            {
                string nik = Txt_nik.Text.Trim();
                string names = Function.EXEScalar("select name from [EMP_MST] where nik='" + nik + "'");
                if (names != null)
                {
                    Txt_name.Text = names;
                    Txt_nik.Text = nik;
                    Txt_nik.SelectAll();

                }
                else
                {
                    MessageBox.Show("Employee Not Found", "VAKSIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }
    }
}
