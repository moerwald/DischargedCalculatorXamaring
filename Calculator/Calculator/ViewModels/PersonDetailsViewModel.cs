using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator.ViewModels
{
    public class PersonDetailsViewModel : ViewModelsBase
    {

        public PersonDetailsViewModel()
        {
            this.Commands["Add"] = new Command(() => { FirstName = "Button pushed"; });
            this.Commands["CalculateIncome"] = new Command(async () => await this.CalculateIncomes());
        }

        private async Task CalculateIncomes()
        {
            var income = decimal.Parse(this.IncomeBeforeTax);
            var values = new Dictionary<string, string>
            {
                { "alleinverdienerabsetzbetrag", "0" },
                { "arbeitsverhaeltnis","1" },
                { "brutto",$"Brutto:+{income}" },
                { "einkommen","0" },
                { "freibetrag","Freibetrag+monatlich:+0,00" },
                { "kinder","Kinder:+0" },
                { "mehrKinder","0" },
                { "pendeltage","3" },
                { "sachbezug","Sachbezug+monatlich:+0,00" },
                { "sachbezugKFZ","0" },
                { "submitAction","submit" },
                { "verkehrsmittel","1" },
                { "wegstrecke","Wegstrecke+in+km:+0,00" },
            };

            var content = new FormUrlEncodedContent(values);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync("http://bruttonetto.arbeiterkammer.at/", content);

                var responseString = await response.Content.ReadAsStringAsync();
                var responseText = await response.Content.ReadAsStringAsync();



            }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged(nameof(FirstName)); }
        }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string  ZipCode { get; set; }

        public string IncomeBeforeTax { get; set; }


    }
}
