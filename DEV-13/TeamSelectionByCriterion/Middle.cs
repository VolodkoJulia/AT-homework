namespace TeamSelectionByCriterion
{
  public class Middle: Programmer
  {
    //Constants are chosen in such way that the weight is: 1100/500 = 2.2.
    const int SALARYMID = 500;
    const int PRODUCTIVITYMID = 1100;

    public Middle()
    {
      Salary = SALARYMID;
      Productivity = PRODUCTIVITYMID;
    }
  }
}