namespace ClassLib;

public class StringClass: IComparable<StringClass>
{
    private string value;
    private int length;

    public string Value
    {
        get => value;
        set => this.value = value ?? throw new ArgumentNullException(nameof(value));
    }
    public int Length
    {
        get => length;
        set => length = value;
    }

    public StringClass(string value)
    {
        this.value = value;
        length = value.Length;
    }

    public bool Search(char input)
    {
        return value.Contains(input);
    }
    public string ChangeOrder()
    {
        char[] charArray = value.ToCharArray();
        int left = 0;
        int right = value.Length - 1;

        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;
            right--;
        }

        return new string(charArray);
    }
    public void AddString(string input)
    {
        value += input;
    }

    public override string ToString()
    {
        return "String is {" + value + "} length = " + length;
    }


    public int CompareTo(StringClass? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return string.Compare(value, other.value, StringComparison.Ordinal);
    }
}
