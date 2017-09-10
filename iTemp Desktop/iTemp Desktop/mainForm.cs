using iTemp_Desktop.Function;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTemp_Desktop.Function.privateValues;

namespace iTemp_Desktop
{
    public partial class mainForm : Form
    {
        string result = null;
        public mainForm()
        {
            InitializeComponent();
            zadanaTempLabel.Text = "00" + "°C";
            getHttpAsync(urlIndex);
            RunUpdateLoop();
        }



        async void RunUpdateLoop()
        {
            int licznik = 0;
            while (true)
            {
                if (licznik == 0)
                {
                    getHttpAsync(urlIndex);
                    licznik = 20000;

                }
                licznikLabel.Text = "Odświerzenie za: " + Convert.ToString(licznik / 1000) + "s.";
                licznik -= 1000;
                await Task.Delay(1000);
                //tekst.Text = string.Format("{0} ticks!", count++);
            }

        }

        void wczytajDane()
        {
            try
            {
                modelJson odebraneDane = JsonConvert.DeserializeObject<modelJson>(result);
                wykresCO.Value = odebraneDane.tempCO;
                tempCOLabel.Text = Convert.ToString(odebraneDane.tempCO) + "°C";
                wykresCWU.Value = odebraneDane.tempCWU;
                tempCWULabel.Text = Convert.ToString(odebraneDane.tempCWU) + "°C";
                zadanaTempLabel.Text = Convert.ToString(odebraneDane.tempCWUZad) + "°C"; 
                tempAlarmLabel.Text = Convert.ToString(odebraneDane.tempAlarm) + "°C"; 
                if (odebraneDane.coPump == 1)
                {
                    pompaCOONOFF.BackColor = Color.LightGreen;
                    pompaCOONOFF.Text = "Pompa CO: ON";
                }
                else
                {
                    pompaCOONOFF.BackColor = Color.LightPink;
                    pompaCOONOFF.Text = "Pompa CO: OFF";
                }
                if (odebraneDane.cwuPump == 1)
                {
                    pompaCWUONOFF.BackColor = Color.LightGreen;
                    pompaCWUONOFF.Text = "Pompa CWU: ON";
                }
                else
                {
                    pompaCWUONOFF.BackColor = Color.LightPink;
                    pompaCWUONOFF.Text = "Pompa CWU: OFF";
                }
                /*
    0--Tryb Letni
    1--Priorytet CO
    2--Priorytet CWU
    3--Tryb reczny
    4--Pompy CO i CWU
   */
                switch(odebraneDane.selectedMode){
                    case 0:
                        trybPracyLabel.Text = "Tryb Letni";
                        break;
                    case 1:
                        trybPracyLabel.Text = "Priorytet CO";
                        break;
                    case 2:
                        trybPracyLabel.Text = "Priorytet CWU";
                        break;
                    case 3:
                        trybPracyLabel.Text = "Tryb reczny";
                        break;
                    case 4:
                        trybPracyLabel.Text = "Pompy CO i CWU";
                        break;

                }
                    

            }
            catch
            {

            }
        }
        async void getHttpAsync(string url)
        {

            using (HttpClientHandler ClientHandler = new HttpClientHandler())
            using (HttpClient Client = new HttpClient(ClientHandler))
            {
                using (HttpResponseMessage ResponseMessage = await Client.GetAsync(url))
                {
                    if (ResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        using (HttpContent Content = ResponseMessage.Content)
                        {
                            result = await Content.ReadAsStringAsync();
                            // tekst.Text = result;
                            if (result != null)
                            {
                                wczytajDane();
                            }

                        }
                    }
                }
            }
        }




    }

    public class VerticalProgressBar : System.Windows.Forms.ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }
}


