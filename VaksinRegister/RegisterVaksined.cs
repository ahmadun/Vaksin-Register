using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaksinRegister.Classes;

namespace VaksinRegister
{
    public partial class RegisterVaksined : Form
    {
        string nik;
        string names;
        string dosis;
        int tahap1;
        int tahap2;
        string prd;
        string thp1;
        string thp2;
        public RegisterVaksined()
        {
            InitializeComponent();
            Function.CreateConn();
      
          

            IniFile ini = new IniFile(@"C:\DirSystem\SystemVaccine\Configuration.ini");
            thp1 = ini.IniReadValue("App", "tahap1");
            thp2 = ini.IniReadValue("App", "tahap2");
            dosis = ini.IniReadValue("App", "dosis");
         



            StartTimer();
            tahap1 = Convert.ToInt16(Function.EXEScalar("select count(nik) as jumlah from [Emp_vaccinated_new] where Dosis = '" + dosis + "' and convert(date,EntDate) = '"+thp1+"'"));
            tahap2 = Convert.ToInt16(Function.EXEScalar("select count(nik) as jumlah from [Emp_vaccinated_new] where Dosis = '" + dosis + "' and convert(date,EntDate) = '"+thp2+"'"));
            Lb_jumlah.Text = (tahap1+tahap2).ToString();
            Tahap_1.Text = tahap1.ToString();
            Tahap_2.Text = tahap2.ToString();
            prd = Function.Period;


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

        System.Windows.Forms.Timer t = null;
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            Lb_time.Text = DateTime.Now.ToString();
        }

        private void RemoveInfo()
        {
            Pc_member.Image = null;
            Txt_nik.Text = "";
            Txt_name.Text = "";
            Lb_message.Text = "";
            Pn_status.BackColor = Color.White;
        }

        public void Logs(string status)
        {

            using (StreamWriter sw = new StreamWriter(@"C:\SystemVaccine\log.txt", true))
            {
                sw.WriteLineAsync(nik + status);
            }
          
        }

      
        
        private void Txt_scan_nik_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
             
                nik = Txt_scan_nik.Text.Trim();

                if (String.IsNullOrEmpty(nik))
                    return;

                bool nomor = nik.All(char.IsDigit);

                if (nomor & nik.Length<=6)
                {

                    names = Function.EXEScalar("select name from [Participant_vaccine] where no_vak='" + nik + "' and period='" + prd + "' union select Name from [emp_mst] where nik='"+nik+"'");
                    if (names != null)
                    {
                        if (!Function.EXEcuteCheckData("select count(nik) from [Emp_vaccinated_new] where nik='" + nik + "' and Dosis='" + dosis + "'"))
                        {
                            if (SaveData())
                            {
                                DisplayInfo(true,true);
                                StartTimerInfo();
                                Tahap_1.Text = (Convert.ToUInt16(Tahap_1.Text) + 1).ToString();
                                Lb_jumlah.Text = (Convert.ToInt16(Tahap_1.Text) + Convert.ToInt16(Tahap_2.Text)).ToString();
                            }
                            else
                            {

                                RemoveInfo();
                                Txt_scan_nik.SelectAll();

                            }

                        }
                        else
                        {

                            DisplayInfo(false,true);
                            StartTimerInfo();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee Not Found", "VAKSIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string last = Function.EXEScalar("select max(nik)+1 from Emp_vaccinated_new where len(Nik)<=4");
                    string a;
                    if (last != null)
                    {
                        a = last;
                    }
                    else
                    {
                        a = "9000";
                    }
                    string qr;
                    qr = "insert [Emp_vaccinated_new] values";
                    qr = qr + " ('" + a + "','" + Txt_scan_nik.Text + "','" + dosis + "',getdate(),host_name())";
                    if (Function.EXEcuteQuery(qr))
                    {
                        DisplayInfo(true,false);
                        StartTimerInfo();
                        Tahap_1.Text = (Convert.ToUInt16(Tahap_2.Text) + 1).ToString();
                        Lb_jumlah.Text = (Convert.ToInt16(Tahap_1.Text) + Convert.ToInt16(Tahap_2.Text)).ToString();
                    }
                }


            }
            else if (e.KeyCode == Keys.F8)
            {

                ListParticipant mw = new ListParticipant(this,null);
                mw.ShowDialog();
            }
            else if (e.KeyCode == Keys.F2)
            {

                ParticipantMaint mw = new ParticipantMaint("1");
                mw.ShowDialog();
            }
            else if (e.KeyCode == Keys.F9)
            {

                tahap1 = Convert.ToInt16(Function.EXEScalar("select count(nik) as jumlah from [Emp_vaccinated_new] where Dosis = '" + dosis + "' and convert(date,EntDate) = '" + thp1 + "'"));
                tahap2 = Convert.ToInt16(Function.EXEScalar("select count(nik) as jumlah from [Emp_vaccinated_new] where Dosis = '" + dosis + "' and convert(date,EntDate) = '" + thp2 + "'"));
                Lb_jumlah.Text = (tahap1 + tahap2).ToString();
                Tahap_1.Text = tahap1.ToString();
                Tahap_2.Text = tahap2.ToString();
            }
        }

        private void DisplayInfo(Boolean check,Boolean ass)
        {
         

                Lb_message.Text = "Peserta Tervaksin";
                if (check)
                {
                    Pn_status.BackColor = Color.BlueViolet;
                    Txt_status.Text = "Thank You";
                }
                else
                {
                    Pn_status.BackColor = Color.Red;
                    Txt_status.Text = "ID anda telah Discan"; 
                }
            
            
          
            Txt_scan_nik.Text = "";
            if (ass)
            {
                Txt_nik.Text = nik;
                Txt_name.Text = names;
            }
            else
            {
                Txt_nik.Text = nik;
            }
            
            try
            {
                Pc_member.Image = Image.FromFile(@"\\sbisus\jpgtraining\" + nik + ".jpg" + "");
            }
            catch (Exception)
            {

            }
     
        }

    
        private bool SaveData()
        {
            string qr;
            qr = "insert [Emp_vaccinated_new] values";
            qr = qr + " ('" + nik + "','"+names+"','" + dosis + "',getdate(),host_name())";
            if (Function.EXEcuteQuery(qr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
