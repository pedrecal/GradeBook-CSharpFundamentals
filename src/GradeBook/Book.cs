using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatistics()
    {
      var average = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;

      foreach (var grade in grades)
      {
        lowGrade = Math.Min(grade, lowGrade);
        highGrade = Math.Max(grade, highGrade);
        average += grade;
      }
      average /= grades.Count;
      Console.WriteLine($"The lowest grade is {lowGrade}");
      Console.WriteLine($"The highest grade is {highGrade}");
      Console.WriteLine($"The average grade is {average:N1}");
    }

    private List<double> grades;
    private string name;
  }
}