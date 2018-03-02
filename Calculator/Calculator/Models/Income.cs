namespace Calculator.Models
{
    public class Income
    {
        public enum IncomeType
        {
            Undef = 0,

            MonthlyCredit,

            YearlyIncome,

            ChristmasBonus,

            VacationBonus
        }


        public IncomeType Type { get; set; }

        public decimal PreTaxIncome { get; set; }

        public decimal NationalInsurance { get; set; }

        public decimal IncomeTax { get; set; }

        public decimal AfterTaxIncome { get; set; }
    }
}
