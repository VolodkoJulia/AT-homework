namespace TeamSelectionByCriterion
{
  public class Junior: Programmer
  {    
    //Constants are chosen in such way that the weight is: 500/250 = 2.
    const int SALARYJUN = 250;
    const int PRODUCTIVITYJUN = 500;

    public Junior()
    {
      Salary = SALARYJUN;
      Productivity = PRODUCTIVITYJUN;
    }
  }
}