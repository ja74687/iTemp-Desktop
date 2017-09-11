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
        int idZmiana = 0;
        int pompaCOLicznik = 0;
        int pompaCWULicznik = 0;
        int danePoczatkowe = 0;
        string updateURL;
        int licznikCO = 0;
        int licznikCWU = 0;

        public mainForm()
        {
            InitializeComponent();
            zadanaTempLabel.Text = "00" + "°C";
            getHttpAsync(urlIndex);
            trybPracyPomp.Items.Add("Tryb Letni");
            trybPracyPomp.Items.Add("Priorytet CO");
            trybPracyPomp.Items.Add("Priorytet CWU");
            trybPracyPomp.Items.Add("Tryb reczny");
            trybPracyPomp.Items.Add("Pompy CO i CWU");
            RunUpdateLoop();
            zapiszButton.Enabled = false;
            pompaCOButton.Enabled = false;
            pompaCWUButton.Enabled = false;
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

                if (danePoczatkowe == 0)
                {
                    idZmiana = odebraneDane.idZmiana;
                    tempAlarmSet.Value = odebraneDane.tempAlarm;
                    tempCWUSet.Value = odebraneDane.tempCWUZad;
                    pompaCOLicznik = odebraneDane.coPump;
                    pompaCWULicznik = odebraneDane.cwuPump;
                    trybPracyPomp.SelectedIndex = odebraneDane.selectedMode;
                    licznikCO = odebraneDane.coPump;
                    licznikCWU = odebraneDane.cwuPump;
                }
                if (odebraneDane.selectedMode == 3)
                {
                    pompaCWUButton.Enabled = true;
                    pompaCOButton.Enabled = true;
                }
                if (odebraneDane.coPump == 1)
                {
                    pompaCOONOFF.BackColor = Color.LightGreen;
                    pompaCOONOFF.Text = "Pompa CO: ON";
                    if (danePoczatkowe == 0)
                    {
                        pompaCOButton.Text = "Pompa CO: ON";
                        pompaCOButton.BackColor = Color.LightGreen;
                    }
                }
                else
                {
                    pompaCOONOFF.BackColor = Color.LightPink;
                    pompaCOONOFF.Text = "Pompa CO: OFF";
                    if (danePoczatkowe == 0)
                    {
                        pompaCOButton.Text = "Pompa CO: OFF";
                        pompaCOButton.BackColor = Color.LightPink;
                    }
                }
                if (odebraneDane.cwuPump == 1)
                {
                    pompaCWUONOFF.BackColor = Color.LightGreen;
                    pompaCWUONOFF.Text = "Pompa CWU: ON";
                    if (danePoczatkowe == 0)
                    {
                        pompaCWUButton.Text = "Pompa CWU: ON";
                        pompaCWUButton.BackColor = Color.LightGreen;
                    }
                }
                else
                {
                    pompaCWUONOFF.BackColor = Color.LightPink;
                    pompaCWUONOFF.Text = "Pompa CWU: OFF";
                    if (danePoczatkowe == 0)
                    {
                        pompaCWUButton.Text = "Pompa CWU: OFF";
                        pompaCWUButton.BackColor = Color.LightPink;
                    }
                }
                /*
    0--Tryb Letni
    1--Priorytet CO
    2--Priorytet CWU
    3--Tryb reczny
    4--Pompy CO i CWU
   */
                switch (odebraneDane.selectedMode)
                {
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

                danePoczatkowe++;
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


        private async void setHttpAsync(string url)
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

                            if (result != null)
                            {
                                wczytajDane();
                            }

                        }
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            zapiszButton.Enabled = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            zapiszButton.Enabled = true;
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {

            try
            {
                idZmiana++;
                updateURL = "http://www.scholawgradz.gbzl.pl/kontrolerCO/update.php?serialNumber=" + serialNumber + "&coPump=" + pompaCOLicznik + "&cwuPump=" + pompaCWULicznik + "&tempCO=" + wykresCO.Value + "&tempCWU=" + wykresCWU.Value + "&tempCWUZad=" + Convert.ToString(tempCWUSet.Value) + "&tempAlarm=" + Convert.ToString(tempAlarmSet.Value) + "&selectedMode=" + trybPracyPomp.SelectedIndex + "&timeOnOff=0&timeStart=0&timeStop=0&idZmiana=" + idZmiana;
                setHttpAsync(updateURL);
                MessageBox.Show("Dane zostały zmienione.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                danePoczatkowe = 0;
                getHttpAsync(urlIndex);
            }
            catch
            {
                MessageBox.Show(updateURL, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void trybPracyPomp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trybPracyPomp.SelectedIndex == 3)
            {
                pompaCWUButton.Enabled = true;
                pompaCOButton.Enabled = true;
            }
            else
            {
                pompaCWUButton.Enabled = false;
                pompaCOButton.Enabled = false;
            }
            zapiszButton.Enabled = true;
        }

        private void pompaCOButton_Click(object sender, EventArgs e)
        {
            if (licznikCO == 0)
            {
                pompaCOButton.Text = "Pompa CO: OFF";
                pompaCOButton.BackColor = Color.LightPink;
                licznikCO++;
                pompaCOLicznik = 0;
            }
            else
            {
                pompaCOLicznik = 1;
                pompaCOButton.Text = "Pompa CO: ON";
                pompaCOButton.BackColor = Color.LightGreen;
                licznikCO = 0;

            }
            
        }

        private void pompaCWUButton_Click(object sender, EventArgs e)
        {
            if (licznikCWU == 0)
            {
                pompaCWUButton.Text = "Pompa CWU: OFF";
                pompaCWUButton.BackColor = Color.LightPink;
                pompaCWULicznik = 0;
                licznikCWU++;
            }
            else 
            {
                pompaCWULicznik = 1;
                licznikCWU = 0;
                pompaCWUButton.Text = "Pompa CWU: ON";
                pompaCWUButton.BackColor = Color.LightGreen;

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


