using static System.Console;
namespace TeamSelectionByCriterion
{
   //It stores a reference to the Strategy abstact class and is associated with it by the aggregation relation.
   //Also there is a method to output result.
  class AlgorithmImplementation
  {
    public Strategy Strategy { get; set; }

    public AlgorithmImplementation(Strategy strategy)
    {
      Strategy = strategy;
    }

    public int[] ExecuteAlgorithm(int parametr)
    {
      int[] resultTeam = Strategy.Algorithm(parametr);
      return resultTeam;
    }

    public void PrintResultTeam(int[] resultTeam)
    {
      WriteLine("  Lead {0}", resultTeam[0]);
      WriteLine("Senior {0}", resultTeam[1]);
      WriteLine("Middle {0}", resultTeam[2]);
      WriteLine("Junior {0}", resultTeam[3]);
    }
  }
}