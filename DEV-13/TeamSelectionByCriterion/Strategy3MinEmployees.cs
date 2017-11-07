namespace TeamSelectionByCriterion
{
  class Strategy3MinEmployees: Strategy
  {
    //Realization of the Algorithm(). For search the minimum count of programmers. Use cycle: from Lead to Junior.
    public override int[] Algorithm(int userProductivity)
    {
      int counterJun = 0, counterMid = 0, counterSen = 0, counterLead = 0, minProd = 0;
      for (int i = 0; minProd < userProductivity; i++)
      {
        minProd += junior.Salary * counterJun;
        counterJun++;
        if (minProd > userProductivity)
        {
          counterJun--;
          minProd -= junior.Salary;
          break;
        }
        for (int j = 0; minProd < userProductivity; j++)
        {
          minProd += middle.Salary * counterMid;
          counterMid++;
          if (minProd > userProductivity)
          {
            counterMid--;
            minProd -= middle.Salary;
            break;
          }
          for (int k = 0; minProd < userProductivity; k++)
          {
            minProd += senior.Salary * counterSen;
            counterSen++;
            if (minProd > userProductivity)
            {
              counterSen--;
              minProd -= senior.Salary;
              break;
            }
            for (int l = 0; minProd < userProductivity; l++)
            {
              minProd = lead.Salary * counterLead;
              counterLead++;
              if (minProd > userProductivity)
              {
                counterLead--;
                minProd -= lead.Salary;
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