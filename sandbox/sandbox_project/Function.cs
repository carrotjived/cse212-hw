using System.Diagnostics;

public static class Function
{

    public static bool CheckBraces(string line)
    {
        var stack = new Stack<char>();
        foreach (var item in line)
        {
            if (item is '(' or '[' or '{')
            {
                stack.Push(item);
            }
            else if (item is ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']')
            {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}')
            {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }

    public static string Run(string text)
    {
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter);

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;


    }

    private static bool IsFloat(string text)
    {
        return float.TryParse(text, out _);
    }

    public static float Run2(string text)
    {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' '))
        {
            if (item == "+" || item == "-" || item == "*" || item == "/")
            {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+")
                {
                    res = op1 + op2;
                }
                else if (item == "-")
                {
                    res = op1 - op2;
                }
                else if (item == "*")
                {
                    res = op1 * op2;
                }
                else
                {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }

                stack.Push(res);
            }
            else if (IsFloat(item))
            {
                stack.Push(float.Parse(item));
            }
            else if (item == "")
            {
            }
            else
            {
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();
    }

    public static bool IsAnagram(string word1, string word2)
    {
        
        // TODO Problem 3 - ADD YOUR CODE HERE
        var anagramDictionaries = new Dictionary<string, string>();
        word1 = word1.ToLower().Replace(" ", "");
        word2 = word2.ToLower().Replace(" ", "");


        if (word1.Count() == word2.Count())
        {
            anagramDictionaries.Add("FirstWord", word1);
            anagramDictionaries.Add("SecondWord", word2);
            bool identify = true;
            foreach (var letter in word2)
            {
                if (anagramDictionaries["FirstWord"].Contains(letter))
                {
                    anagramDictionaries["FirstWord"] = word1.Remove(word1.IndexOf(letter), 1);
                    anagramDictionaries["SecondWord"] = word2.Remove(word2.IndexOf(letter), 1);
                    identify = true;
                }
                else
                {
                    identify = false;
                    break;
                }

            }
            return identify;

            
        }
        else
        {
            return false;

        }
        







    }




}