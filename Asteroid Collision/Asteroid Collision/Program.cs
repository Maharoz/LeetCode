// See https://aka.ms/new-console-template for more information

int[] x = {10,2,-5 };
AsteroidCollision(x);

 static int[] AsteroidCollision(int[] asteriods)
{
    if(asteriods == null|| asteriods.Length == 0)
    {
        return null;
    }

    var stack = new Stack<int>();
    stack.Push(asteriods[0]);


    for(int i =1; i < asteriods.Length; i++)
    {
        //while (true)
        //{
            if (stack.Count > 0 && stack.Peek() > 0 && asteriods[i] < 0){
                if (Math.Abs(stack.Peek()) == Math.Abs(asteriods[i]))
                {
                    stack.Pop();
                    break;
                }
                else if (Math.Abs(stack.Peek()) < Math.Abs(asteriods[i]))
                {
                    stack.Pop();

                }
                else break;
            }
            else
            {
                stack.Push(asteriods[i]);
                break;
            }
      //  }
    }
    return stack.Reverse().ToArray();
}