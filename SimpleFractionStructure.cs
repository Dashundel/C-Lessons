namespace HW456;

struct  SimpleFractionStructure: IComparable<SimpleFractionStructure>
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }

    public SimpleFractionStructure(int numerator, int denominator)
    {
        if (denominator < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(denominator), "Denominator must be positive.");
        }
        
        Numerator = numerator;
        Denominator = denominator;
    }

    public static int CommonDivisor(int x, int y)
    {
        try
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
        }
        catch (DivideByZeroException) when(y == 0)
        {
            throw new InvalidOperationException("you cannot divided by 0");
        }
        catch (InvalidDataException) when(y < 0)
        {
            throw new ArgumentException("Denominator must be positive");
        }
        return x;
    }

    public static SimpleFractionStructure Reduction(SimpleFractionStructure number)
    {
        int numerator = 0;
        int denominator = 0;

        int comonNum = CommonDivisor(number.Numerator, number.Denominator);

        try
        {
            numerator = number.Numerator / comonNum;
            denominator = number.Denominator / comonNum;
        }
        catch (DivideByZeroException) when(number.Denominator == 0)
        {
            throw new InvalidOperationException("you cannot divided by 0");
        }
        return new SimpleFractionStructure(numerator, denominator);
    }

    public static SimpleFractionStructure Add(SimpleFractionStructure first, SimpleFractionStructure second)
    {
        int numerator = 0;
        int denominator = 0;
        
        try
        {
            numerator = first.Numerator * second.Denominator + second.Numerator * first.Denominator;
            denominator = first.Denominator * second.Denominator;
        }
        catch (DivideByZeroException) when( first.Denominator == 0 || second.Denominator == 0)
        {
            throw new InvalidOperationException("you cannot divided by 0");
        }
        catch (InvalidDataException) when(first.Denominator < 0 || second.Denominator < 0)
        {
            throw new ArgumentException("Denominator must be positive");
        }
        return Reduction(new SimpleFractionStructure(numerator, denominator));
    }

    public static SimpleFractionStructure Subtract(SimpleFractionStructure first, SimpleFractionStructure second)
    {
        int numerator = 0;
        int denominator = 0;
        
        try
        {
            numerator = first.Numerator * second.Denominator - second.Numerator * first.Denominator;
            denominator = first.Denominator * second.Denominator;
        }
        catch (DivideByZeroException) when( first.Denominator == 0 || second.Denominator == 0)
        {
            throw new InvalidOperationException("you cannot divided by 0");
        }
        catch (InvalidDataException) when(first.Denominator < 0 || second.Denominator < 0)
        {
            throw new ArgumentException("Denominator must be positive");
        }
        return Reduction(new SimpleFractionStructure(numerator, denominator));
    }

    public static SimpleFractionStructure Multiply(SimpleFractionStructure first, SimpleFractionStructure second)
    {
        int numerator = 0;
        int denominator = 0;
        
        try
        {
            numerator = first.Numerator * second.Numerator;
            denominator = first.Denominator * second.Denominator;
        }
        catch (DivideByZeroException) when( first.Denominator == 0 || second.Denominator == 0)
        {
            throw new InvalidOperationException("you cannot divided by 0");
        }
        catch (InvalidDataException) when(first.Denominator < 0 || second.Denominator < 0)
        {
            throw new ArgumentException("Denominator must be positive");
        }
        return Reduction(new SimpleFractionStructure(numerator, denominator));
    }

    public static SimpleFractionStructure Divisive(SimpleFractionStructure first, SimpleFractionStructure second)
    {
        int numerator = 0;
        int denominator = 0;

        try
        {
            numerator = first.Numerator * second.Denominator;
            denominator = first.Denominator * second.Numerator;
        }
        catch (DivideByZeroException) when( first.Denominator == 0 || second.Denominator == 0)
        {
            throw new InvalidOperationException("you cannot divided by 0");
        }
        catch (InvalidDataException) when(first.Denominator < 0 || second.Denominator < 0)
        {
            throw new ArgumentException("Denominator must be positive");
        }
        return Reduction(new SimpleFractionStructure(numerator, denominator));
    }
    
    public int CompareTo(SimpleFractionStructure fraction)
    {
        int compareLeft = Numerator * fraction.Denominator;
        int compareRight = fraction.Numerator * Denominator;

        if (compareLeft > compareRight)
            return 1;
        if (compareLeft < compareRight)       
            return -1;
        return 0;
    }
}