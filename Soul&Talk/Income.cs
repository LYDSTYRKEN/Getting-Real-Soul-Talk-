using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soul_Talk;

public class Income
{
    public string AmountOfHours { get; set; }
    public string AssignmentType { get; set; }
    public List<Income> Incomes { get; set; } = new List<Income>();

    public Income(String amountOfHours, string assignmentType)
    {
        this.AmountOfHours = amountOfHours;
        this.AssignmentType = assignmentType;
    }
    //public double CalculateSalary()

    public override string ToString()
    {
        return $"Amount of hours: {AmountOfHours}, Assignment type: {AssignmentType}, Salary:___"; /* {CalculateSalary()}"*/
    }
}