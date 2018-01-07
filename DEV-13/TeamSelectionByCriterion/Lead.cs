namespace TeamSelectionByCriterion
{
  public class Lead: Programmer
  {
    //Constants are chosen in such way that the weight is: 6200/2000 = 3.1.
    const int SALARYLEAD = 2000;
    const int PRODUCTIVITYLEAD = 6200;

    public Lead()
    {
      Salary = SALARYLEAD;
      Productivity = PRODUCTIVITYLEAD;
    }
  }
}