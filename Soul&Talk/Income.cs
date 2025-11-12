using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soul_Talk;

public class Income
{
    public readonly int HoursWorked;
    //public List<AssignmentType> assignmentType;
    //public List<Income> Incomes { get; set; } = new List<Income>();
    public readonly TaskType task;
    public readonly int salary;

    public enum CostumerType
    {
        OffenligInstitution = 1,
        PrivatInstitution = 2,
        Privat = 3,
    }
    public enum TaskType
    {
        OffenligInstitution_Fysisk = 550,
        OffenligInstitution_Ikke_Fysisk = 550,
        PrivatInstitution_Fysisk = 450,
        PrivatInstitution_Ikke_Fysisk = 350,
        Privat_Fysisk = 450,
        Privat_IkkeFysisk = 350,
    }


    public Income(int hoursWorked, TaskType task)
    {
        this.HoursWorked = hoursWorked;
        this.task = task;
        this.salary = hoursWorked * (int)task; // TODO: Find out if casting an Enum to int is correct solution
    }
    public double CalculateSalary()
    {   
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"hoursWorked: {this.HoursWorked}, Task: {this.task}";
    }
}