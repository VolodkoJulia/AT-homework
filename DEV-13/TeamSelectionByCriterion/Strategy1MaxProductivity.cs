namespace TeamSelectionByCriterion
{
  //Realization of the Algorithm(). For search the maximum of the productivity. Use cycle: from Lead to Junior.
  public class Strategy1MaxProductivity : Strategy
  {
    public override int[] Algorithm(int userPrice)
    {
      int counterJun = 0, counterMid = 0, counterSen = 0, counterLead = 0, sum = 0; 
      for (int i = 0; sum <= userPrice; i++)
      {
        sum += junior.Salary * counterJun;
        counterJun++;
        if (sum > userPrice)
        {
          counterJun--;
          sum -= junior.Salary;
          break;
        }
        for (int j = 0; sum <= userPrice; j++)
        {
          sum += middle.Salary * counterMid;
          counterMid++;
          if (sum > userPrice)
          {
            counterMid--;
            sum -= middle.Salary;
            break;
          }
          for (int k = 0; sum <= userPrice; k++)
          {
            sum += senior.Salary * counterSen;
            counterSen++;
            if (sum > userPrice)
            {
              counterSen--;
              sum -= senior.Salary;
              break;
            };
            for (int l = 0; sum <= userPrice; l++)
            {
              sum = lead.Salary * counterLead;
              counterLead++;
              if (sum > userPrice)
              {
                counterLead--;
                sum -= lead.Salary;
                break;
              }
            }
          }
        }
      }
      int[] countResultArray = new int[] { counterLead - 1, counterSen - 1, counterMid - 1, counterJun - 1 };
      return countResultArray;
    }
  }
}