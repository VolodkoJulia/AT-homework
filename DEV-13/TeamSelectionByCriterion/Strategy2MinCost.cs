namespace TeamSelectionByCriterion
{
  class Strategy2MinCost: Strategy
  { 
    //Realization of the Algorithm(). For search the minimum of the price. Use cycle: from Junior to Lead.
    public override int[] Algorithm(int userProductivity)
    {
      int counterJun = 0, counterMid = 0, counterSen = 0, counterLead = 0, minProd = 0;
      for (int i = 0; minProd < userProductivity; i++)
      {
        minProd += lead.Productivity * counterLead;
        counterLead++;
        if (minProd > userProductivity)
        {
          counterLead--;
          minProd -= lead.Productivity;
          break;
        }
        for (int j = 0; minProd < userProductivity; j++)
        {
          minProd += senior.Productivity * counterSen;
          counterSen++;
          if (minProd > userProductivity)
          {
            counterSen--;
            minProd -= senior.Productivity;
            break;
          }
          for (int k = 0; minProd < userProductivity; k++)
          {
            minProd += middle.Productivity * counterMid;
            counterMid++;
            if (minProd > userProductivity)
            {
              counterMid--;
              minProd -= middle.Productivity;
              break;
            }
            for (int l = 0; minProd < userProductivity; l++)
            {
              minProd = junior.Productivity * counterJun;
              counterJun++;
              if (minProd > userProductivity)
              {
                counterJun--;
                minProd -= junior.Productivity;
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