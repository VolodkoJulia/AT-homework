using System;

namespace TeamSelectionByCriterion
{
  class WrongParametrException: Exception
  {
    const string PRICEEXCEPTION = "The price should be higher than 250$ and productivity should be minimum 500.";
    public override string Message
    {
      get
      {
        return PRICEEXCEPTION;
      }
    }
  }
}