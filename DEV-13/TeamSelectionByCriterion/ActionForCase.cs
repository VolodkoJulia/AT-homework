using System;
using static System.Console;

namespace TeamSelectionByCriterion
{
  //Implemented a choice of the criterion in accordance with which the team is selected.
  //Also there is present a validation of the input data.
  public class ActionForCase
  {
    const string ENTERPRICE = "Enter the price which you want to invest in your project:\n >>";
    const string SELECTCCRITERION = "Choose criterion:\n 1)Maximum productivity.\n 2)Minimum price.\n 3)Selection criterion.\n  >>";
    const string MAXPRODUCTIVITY = "Enter the max productivity for these case:";
    const string ENTERPRODUCTIVITY = "\nEnter the productivity which you can use in the next cases:\n >>";
    const string TRYAGAIN = "Try again.\n";

    //In every case the algorithm of actions is called.
   public void CallAlgorithmForCase()
    {
      bool choice = true;
      while (choice)
      {
        choice = false;
        Write(SELECTCCRITERION);
        try
        {
          switch (int.Parse(ReadLine()))
          {
            case 1:
              Write(ENTERPRICE);
              choice = true;
              DoForCase(new Strategy1MaxProductivity());             
              break;
            case 2:
              Write(ENTERPRODUCTIVITY);
              choice = true;
              DoForCase(new Strategy2MinCost());
              break;
            case 3:
              Write(ENTERPRODUCTIVITY);
              choice = true;
              DoForCase(new Strategy3MinEmployees());
              break;
            case 4:
              choice = false;
              break;
            default:
              Write(TRYAGAIN);
              choice = true;
              break;
          }
        }
        catch (WrongParametrException ex)
        {
          WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
          WriteLine(ex.Message);
        }
      }
    }

    //For verify input information and to calling the method with different strategy fo every case.
    //Also for outputing result array of coders.
    public void DoForCase(Strategy strategy)
    {
      int param = int.Parse(ReadLine());
      bool checkParam = CheckInputPrice(param);
      if (!checkParam)
      {
        throw new WrongParametrException();
      }
      int[] resultTeam = new AlgorithmImplementation(strategy).ExecuteAlgorithm(param);
      new AlgorithmImplementation(strategy).PrintResultTeam(resultTeam);
    }

    public bool CheckInputPrice(int price )
    {
      return price > new Junior().Salary;
    }

    public bool CheckInputProductivity(int productivity)
    {
      return productivity > new Junior().Productivity;
    }
  }
}