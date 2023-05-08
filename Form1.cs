namespace WinFormsAppFrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button Calculate = new Button();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button Calculate = new Button();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            @@ -170,6 + 174,92 @@ static string textToBinary(string input)
        }
        return answer.Remove(answer.Length - 1); // Removes final space from string
    }
    static string decimalToText(List<int> input)
    {
        string answer = "";
        foreach (int num in input)
        {
            answer += ((char)num).ToString(); // This very simply uses the built in function to convert decimal into ascii.
        }
        return answer;
    }
    static string binaryToText(List<string> input)
    {
        List<int> numbers = new List<int>();
        foreach (string binary in input) // Loops over each binary number
        {
            numbers.Add(binaryToDecimal(binary)); // Converts and adds to list of decimal numbers to perform decimal to text calculation
        }
        return decimalToText(numbers);
    }
    static string hexToText(List<string> input)
    {
        List<int> numbers = new List<int>();
        foreach (string hex in input) // Loops over each hex number
        {
            numbers.Add(hexToDecimal(hex)); // Converts and adds to list of decimal numbers to perform decimal to text calculation
        }
        return decimalToText(numbers);
    }
    static string octalToText(List<string> input)
    {
        List<int> numbers = new List<int>();
        foreach (string octal in input) // Loops over each octal number
        {
            numbers.Add(octalToDecimal(octal)); // Converts and adds to list of decimal numbers to perform decimal to text calculation
        }
        return decimalToText(numbers);
    }
    static string decimalToOctal(int input)
    {
        string answer = "";
        int remainder;

        while (input != 0)
        {
            remainder = input % 8; // Gets the remainder of the input divided by 8
            input = input / 8; // Divides the number by 8
            answer = remainder.ToString() + answer; // Adds the number to the start of the answer
        }
        return answer;
    }
}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            static int binaryToDecimal(string input)
            {
                int answer = 0;
                int power = 1; // Used to store the current power, as using Math.Pow will produce rounding errors
                for (int n = input.Length - 1; n >= 0; n--) // Iterates over each character in input string, starting from the end of the string
                {
                    int binary = Int32.Parse(input[n].ToString()); // Gets the value of the int
                    answer += (Convert.ToInt32(Math.Pow(2, n)) * binary); // Uses the formula to get answer
                    answer += binary * power; // Uses the formula to get answer
                    power *= 2; // Increases the power by factor of 1
                }
                return answer;
            }
        }
static string binaryToOctal(string input)
{
    // To convert binary to octal, you must convert to decimal, then to octal
    // As these functions have already been created, this simply uses those functions to acquire the answer.
    int number = binaryToDecimal(input);
    string answer = decimalToOctal(number);
    return answer;
}

private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            static int hexToDecimal(string input)
            {
                int answer = 0;
                int power = 1; // Used to store the current power, as using Math.Pow will produce rounding errors
                for (int n = input.Length - 1; n >= 0; n--) // Iterates over each character in input string, starting from the end of the string
                {
                    char hex = input[n]; // Gets the value of the int
@@ -27,19 + 30,20 @@ static int hexToDecimal(string input)
                    {
                        number = hex - 'A' + 10;
                    }
                    answer += (Convert.ToInt32(Math.Pow(16, n)) * number); // Uses the formula to get answer
                    answer += number * power; // Uses the formula to get answer
                    power *= 16; // Increases the power by factor of 1
                }
                return answer;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            static int octalToDecimal(string input)
            {
                int answer = 0;
                int powerOfEight = 1; // Used to store the current power of eight, as the usual Math.Pow method will produce rounding errors
                int power = 1; // Used to store the current power, as using Math.Pow will produce rounding errors
                for (int n = input.Length - 1; n >= 0; n--) // Iterates over each character in input string, starting from the end of the string
                {
                    int octal = input[n] - '0';
                    answer += octal * powerOfEight; // Uses the formula to get answer
                    powerOfEight *= 8; // Increases the power by 1 e.g 8*8 + *8
                    answer += octal * power; // Uses the formula to get answer
                    power *= 8; // Increases the power by factor of 1
                }
                return answer;
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






static string binaryToOctal(string input)
{
    // To convert binary to octal, you must convert to decimal, then to octal
    // As these functions have already been created, this simply uses those functions to acquire the answer.
    int number = binaryToDecimal(input);
    string answer = decimalToOctal(number);
    return answer;
}
static string hexToOctal(string input)
{
    // To convert hex to octal, you must convert to decimal, then to octal
    // As these functions have already been created, this simply uses those functions to acquire the answer.
    int number = hexToDecimal(input);
    string answer = decimalToOctal(number);
    return answer;
}
static string[] textToOctal(string input)
{
    // To convert text to octal, you need to convert each individual char into decimal, then into octal
    // Thus we will use the function textToDecimal, and then convert each individual decimal into octal
    string[] answer = new string[input.Length];
    int[] numbers = textToDecimal(input); // Converts string into list of decimal numbers
    for (int n = 0; n <= numbers.Length - 1; n++) // Iterates over each number in list
    {
        answer[n] = decimalToOctal(numbers[n]);
    }
    return answer;
}
static string hexToRGB(string input)
{
    string answer = "";
    answer += $"{hexToDecimal(input.Substring(0, 2))}, ";
    answer += $"{hexToDecimal(input.Substring(2, 2))}, ";
    answer += hexToDecimal(input.Substring(4, 2));
    // Console.WriteLine($"{r}, {g}, {b}");
    return answer;
}
static void Main(string[] args)
{
    Console.WriteLine("1)    Binary to Decimal");
@@ -185,84 + 275,226 @@ static void Main(string[] args)
        Console.WriteLine("11)   Hexadecimal to Binary");
    Console.WriteLine("12)   Octal to Binary");
    Console.WriteLine("13)   Text to Binary");
    Console.WriteLine("14)   Decimal to Text");
    Console.WriteLine("15)   Binary to Text");
    Console.WriteLine("16)   Hexadecimal to Text");
    Console.WriteLine("17)   Octal to Text");
    Console.WriteLine("18)   Decimal to Octal");
    Console.WriteLine("19)   Binary to Octal");
    Console.WriteLine("20)   Hexadecimal to Octal");
    Console.WriteLine("21)   Text to Octal");
    Console.WriteLine("22)   Hexadecimal to RGB");
    int Option = Convert.ToInt32(Console.ReadLine());
    string input;
    string outputString = "";
    switch (Option)
        if (Option == 1)
    {
        case 1:
            Console.Write("Enter Binary Number: ");
input = Console.ReadLine();
string input = Console.ReadLine();
Console.WriteLine($"Answer: {binaryToDecimal(input)}");
break;
        case 2:
        }
        else if (Option == 2)
{
    Console.Write("Enter Hexadecimal Number: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {hexToDecimal(input)}");
    break;
        case 3:
        }
else if (Option == 3)
{
    Console.Write("Enter Octal Number: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {octalToDecimal(input)}");
    break;
        case 4:
        }
else if (Option == 4)
{
    Console.Write("Enter Text: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    string outputString = "";
    foreach (int n in textToDecimal(input))
    {
        outputString += $"{n} ";
    }
    Console.WriteLine($"Answer: {outputString.Remove(outputString.Length - 1)}");
    break;
        case 5:
            Console.WriteLine($"Answer: {outputString.Remove(outputString.Length - 1)}");
}
else if (Option == 5)
{
    Console.Write("Enter Decimal Number: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {decimalToHex(Int32.Parse(input))}");
    break;
        case 6:
        }
else if (Option == 6)
{
    Console.Write("Enter Binary Number: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {binaryToHex(input)}");
    break;
        case 7:
        }
else if (Option == 7)
{
    Console.Write("Enter Octal Number: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {octalToHex(input)}");
    break;
        case 8:
        }
else if (Option == 8)
{
    Console.Write("Enter Text: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    string outputString = "";
    foreach (string n in textToHex(input))
    {
        outputString += $"{n} ";
    }
    Console.WriteLine($"Answer: {outputString.Remove(outputString.Length - 1)}");
    break;
        case 9:
            Console.WriteLine($"Answer: {outputString.Remove(outputString.Length - 1)}");
}
else if (Option == 9)
{
    Console.Write("Enter RGB Code (255, 255, 255): ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {rgbToHex(input)}");
    break;
        case 10:
        }
else if (Option == 10)
{
    Console.Write("Enter Decimal Number: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {decimalToBinary(Convert.ToInt32(input))}");
    break;
        case 11:
        }
else if (Option == 11)
{
    Console.Write("Enter Hexadecimal Number: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {hexToBinary(input)}");
    break;
        case 12:
        }
else if (Option == 12)
{
    Console.Write("Enter Octal Number: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {octalToBinary(input)}");
    break;
        case 13:
        }
else if (Option == 13)
{
    Console.Write("Enter Text: ");
    input = Console.ReadLine();
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {textToBinary(input)}");
    break;
}
else if (Option == 14)
{
    Console.Write("Enter Number: ");
    string input = Console.ReadLine();
    List<int> numbers = new List<int>();
    if (input.Contains(' ')) // Checks if there is a single number or multiple numbers to convert
    {
        string[] Numbers = input.Split(" "); // Splits string into separate numbers
        foreach (string num in Numbers)
        {
            numbers.Add(Int32.Parse(num)); // Converts each into an int
        }
    }
    else
    {
        numbers.Add(Int32.Parse(input)); // If no spaces detected, adds the whole input as 1 number
    }
    Console.WriteLine($"Answer: {decimalToText(numbers)}");
}
else if (Option == 15)
{
    Console.Write("Enter Binary Number: ");
    string input = Console.ReadLine();
    List<string> numbers = new List<string>();
    if (input.Contains(' '))
    {
        string[] Numbers = input.Split(" ");
        foreach (string num in Numbers)
        {
            numbers.Add(num);
        }
    }
    else if (input.Length > 8)
    {
        Console.WriteLine("This method of input not supported. Please space the numbers");
    }
    else
    {
        numbers.Add(input);
    }
    Console.WriteLine($"Answer: {binaryToText(numbers)}");
}
else if (Option == 16)
{
    Console.Write("Enter Hexadecimal Number: ");
    string input = Console.ReadLine();
    List<string> numbers = new List<string>();
    if (input.Contains(' '))
    {
        string[] Numbers = input.Split(" ");
        foreach (string num in Numbers)
        {
            numbers.Add(num);
        }
    }
    else if (input.Length > 8)
    {
        Console.WriteLine("This method of input not supported. Please space the numbers");
    }
    else
    {
        numbers.Add(input);
    }
    Console.WriteLine($"Answer: {hexToText(numbers)}");
}
else if (Option == 17)
{
    Console.Write("Enter Octal Number: ");
    string input = Console.ReadLine();
    List<string> numbers = new List<string>();
    if (input.Contains(' '))
    {
        string[] Numbers = input.Split(" ");
        foreach (string num in Numbers)
        {
            numbers.Add(num);
        }
    }
    else if (input.Length > 8)
    {
        Console.WriteLine("This method of input not supported. Please space the numbers");
    }
    else
    {
        numbers.Add(input);
    }
    Console.WriteLine($"Answer: {octalToText(numbers)}");
}
else if (Option == 18)
{
    Console.Write("Enter Number: ");
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {decimalToOctal(Int32.Parse(input))}");
}
else if (Option == 19)
{
    Console.Write("Enter Binary Number: ");
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {binaryToOctal(input)}");
}
else if (Option == 20)
{
    Console.Write("Enter Hexadecimal Number: ");
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {hexToOctal(input)}");
}
else if (Option == 21)
{
    Console.Write("Enter Text: ");
    string input = Console.ReadLine();
    string outputString = "";
    foreach (string n in textToOctal(input))
    {
        outputString += $"{n} ";
    }
    Console.WriteLine($"Answer: {outputString.Remove(outputString.Length - 1)}");
}
if (Option == 22)
{
    Console.Write("Enter Hexadecimal Number: #");
    string input = Console.ReadLine();
    Console.WriteLine($"Answer: {hexToRGB(input)}");
}
    }
}
}