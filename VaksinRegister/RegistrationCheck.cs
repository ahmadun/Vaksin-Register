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
    public partial class RegistrationCheck : Form
    {
        string nik;
        string names;
        string period;
        public RegistrationCheck()
        {
           
            InitializeComponent();
            Function.CreateConn();
            period = Function.Period;
            LbChecked.Text = Convert.ToInt16(Function.EXEScalar("select count(No_vak) from [Participant_vaccine] where Flag=1 and Period = '" + period +"'")).ToString();
            LbTarget.Text = Convert.ToInt16(Function.EXEScalar("select count(No_vak) from [Participant_vaccine] where Period = '" + period + "'")).ToString();
            
        }

        private void DisplayInfo(Boolean check)
        {
              
            if (check)
            {
                LbInfo.BackColor = Color.BlueViolet;
                LbInfo.Text = "Thank You";
            }
            else
            {
                LbInfo.BackColor = Color.Red;
                LbInfo.Text = "ID anda telah Discan";
            }



            Txt_scan_nik.Text = "";
            LbName.Text = nik+"-"+names;
           

        }


        System.Windows.Forms.Timer timerinfo = null;
        private void StartTimerInfo()
        {
            startTime = DateTime.Now.TimeOfDay;
            timerinfo = new System.Windows.Forms.Timer();
            timerinfo.Interval = 1000;
            timerinfo.Tick += new EventHandler(timerinfo_Tick);
            timerinfo.Enabled = true;
            timerinfo.Start();
        }

        private TimeSpan startTime;
        private void timerinfo_Tick(object sender, EventArgs e)
        {
            var diffInSeconds = (DateTime.Now.TimeOfDay - startTime).TotalSeconds;

            if (diffInSeconds > 5)
            {
                RemoveInfo();
                timerinfo.Enabled = false;
                timerinfo.Stop();
            }
        }

        private void RemoveInfo()
        {
    
            LbName.Text = "";
            LbInfo.Text = "";    
            LbInfo.BackColor = Color.White;
        }

        private Boolean SaveData(string no)
        {
            string qr;
            qr = "update [Participant_vaccine] set flag=1,uptdate=getdate()";
            qr = qr + " where No_vak='"+no+"' and Period='"+ period + "'";
            if (Function.EXEcuteQuery(qr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      

        private void Txt_scan_nik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                nik = Txt_scan_nik.Text.Trim();
                names = Function.EXEScalar("select name from [Participant_vaccine] where no_vak='" + nik + "' and Period='"+ period + "'");
                if (names != null)
                {
                    if (!Function.EXEcuteCheckData("select count(No_vak) from [Participant_vaccine] where Flag=1 and no_vak='" + nik + "' and Period='" + period + "'"))
                    {
                        if (SaveData(nik))
                        {
                            DisplayInfo(true);
                            StartTimerInfo();
                            LbChecked.Text = (Convert.ToUInt16(LbChecked.Text) + 1).ToString();
                            Txt_scan_nik.SelectAll();
                        }
                        else
                        {
                            RemoveInfo();
                            Txt_scan_nik.SelectAll();

                        }

                    }
                    else
                    {
                        DisplayInfo(false);
                        StartTimerInfo();

                    }

                }
                else
                {
                    RemoveInfo();
                    MessageBox.Show("Peserta Tidak Terdaftar", "VAKSIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (e.KeyCode == Keys.F2)
            {

                ParticipantMaint mw = new ParticipantMaint("2");
                mw.ShowDialog();
            }
            else if (e.KeyCode == Keys.F9)
            {

                LbChecked.Text = Convert.ToInt16(Function.EXEScalar("select count(No_vak) from [Participant_vaccine] where Flag=1 and Period = '" + period + "'")).ToString();
            }
            else if (e.KeyCode == Keys.F8)
            {
                ListParticipant mw = new ListParticipant(null, this);
                mw.ShowDialog();
            }
            else if (e.KeyCode == Keys.F7)
            {
                AddParticipant mw = new AddParticipant(this);
                mw.ShowDialog();
            }
        }
    }
}
