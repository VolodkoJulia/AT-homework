namespace TeamSelectionByCriterion
{
  public class Senior : Programmer
  {
    //Constants are chosen in such way that the weight is: 2600/1000 = 2.6.
    const int SALARYSENIOR = 1000;
    const int PRODUCTIVITYSENIOR = 2600;

    public Senior()
    {
      Salary = SALARYSENIOR;
      Productivity = PRODUCTIVITYSENIOR;
    }
  }
}