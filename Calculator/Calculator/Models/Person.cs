using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Models
{
    public class Person
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public DateTime BirthDate { get; set; }

        public int ZipCode { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public List<Income> Incomes { get; set; } = new List<Income>
        {
            new Income { Type = Income.IncomeType.ChristmasBonus },
            new Income { Type = Income.IncomeType.MonthlyCredit },
            new Income { Type = Income.IncomeType.VacationBonus },
            new Income { Type = Income.IncomeType.YearlyIncome },
        };
    }
}
