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

    public enum TaskType
    {
        Online = 80,
        Physical = 100,
        Phone = 120
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