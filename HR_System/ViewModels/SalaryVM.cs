using HR_System.Models;
using System.ComponentModel.DataAnnotations;

namespace HR_System.ViewModels;
public class SalaryVM
{
    [Display(Name = "Name")]
    public string employeeName { get; set; }
    [Display(Name = "Department")]
    public string departmentName { get; set; }
    [Display(Name = "Fixed Salary")]
    public int fixedSalary { get; set; }
    [Display(Name = "Attendence Days")]

    public int attendenceDays {  get; set; }
    [Display(Name = "Abscense Days")]

    public int abscenseDays {  get; set; }

    [Display(Name = "Bonus Hours")]
    public decimal BonusHours { get; set; }
    [Display(Name = "Minus Hours")]
    public decimal MinusHours { get; set; }
    [Display(Name = "Total Bonus")]
    public decimal TotalBonus { get; set; }
    [Display(Name = "Total Minus")]

    public decimal TotalMinus { get; set; }
    [Display(Name = "Net Salary")]


    public decimal NetSalary { get; set; }








}
