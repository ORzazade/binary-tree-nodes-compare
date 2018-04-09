using System;

namespace BTNCompare
{
  class Program
  {
    static void Main()
    {
      // create first BTN data
      var firstBtn = new Btn
      {
        Val = 1,
        Right = new Btn
        {
          Val = 2,
          Right = new Btn
          {
            Val = 3
          }
        }
      };

      // create second BTN data
      var secondBtn = new Btn
      {
        Val = 1,
        Right = new Btn
        {
          Val = 2,
          Right = new Btn
          {
            Val = 3
          }
        }
      };

      // compare btn
      bool isEqual = CompareBtn(firstBtn, secondBtn);

      //console the result
      Console.WriteLine("Is Equal: " + isEqual);
      Console.ReadLine();
    }

    public static bool CompareBtn(Btn firstBtn, Btn secondBtn)
    {
      //base case : check both are null
      if (firstBtn == null && secondBtn == null)
        return true;
      //base case :  check any of these is null
      if (firstBtn == null || secondBtn == null)
        return false;

      if (firstBtn.Val == secondBtn.Val)
      {
        //subtrees
        bool left = CompareBtn(firstBtn.Left, secondBtn.Left);
        bool right = CompareBtn(firstBtn.Right, secondBtn.Right);
        return (left && right);
      }
      else
      {
        return false;
      }
    }

  }
}
