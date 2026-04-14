namespace Lab9.Purple;

public class Task1 : Purple
{
    private string _output = null;
    private string _input;
    
    public string Output => _output;
    
    public Task1(string str) : base(str)
    {
        _input = str;
    }

    public override void Review()
    {
        string[] words = _input.Split(" ");

        for (int i = 0; i < words.Length; i++)
        {
            char[] chars = words[i].ToCharArray();
            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                if (!char.IsLetterOrDigit(chars[left]))
                {
                    left++; 
                    continue;
                }

                if (!char.IsLetterOrDigit(chars[right]))
                {
                    right--; 
                    continue;
                }
                
                (chars[left], chars[right]) = (chars[right], chars[left]);

                left++;
                right--;
            }
            
            words[i] = new string(chars);
        }
        
        _output = string.Join(" ", words);
    }
}
