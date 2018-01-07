namespace TeamSelectionByCriterion
{
  //It determines the method Algorithm() wich returned result array of the team.
  public abstract class Strategy
  {
   public Programmer junior = new Junior();
   public  Programmer middle = new Middle();
   public Programmer senior = new Senior();
   public Programmer lead = new Lead();

   public abstract int[] Algorithm(int parametr);
  }
}