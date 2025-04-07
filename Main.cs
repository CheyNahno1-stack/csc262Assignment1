using System.Diagnostics;
using System.Drawing.Text;

namespace guiTesting
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int[] firstItems = null;
            double generationTime = 0;
            double sortTime = 0;
            try
            {//Exception Handling Try/Catch 

                if (!int.TryParse(txtInput.Text, out int size))
                {//try parse tries to convert the input into an interger. if it is true that this is not an interger the loop will go through 
                 //this also ensures we dont need Catch format exceptions as this handles that already 
                    MessageBox.Show("Please enter a number before continuing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    //stops this action of message box showing 
                }
                if (size <= 0 || size >= 10000)
                {//checks to see if the int is less than 0 and bigger than 10000 it will tell the user the message 
                    MessageBox.Show("Please enter a whole number less than 10,000", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this message box will pop up telling the use that the number is not valid 
                    return;
                    //this will stop the program from continuing checking 
                }
                int[] numbers = new int[size];
                //will also intialize the arrays of numbers 
                //this will create an array that will based on the number inputed from txt box 
                Random rand = new Random();
                //Rand is the name of random class which can be used to generate random numbers
                //this will also help generate the numbers for each new array list 

                Stopwatch stopwatch = new Stopwatch();
                //this class is going to measure time like a stopwatch. This will test what we are doing 
                //this also will prompt a new instance of the stopwatch 
                stopwatch.Start();
                //tells the stopwatch to start with the stopwatch method 
                for (int i = 0; i < size; i++)
                {//this loop starts the counter and will give index access to the elements in array
                    numbers[i] = rand.Next(1, 1001);
                    //uses the array and creates random numbers within an array I created eariler 
                }
                stopwatch.Stop();
                //this stops the stopwatch function 
                generationTime =(double) stopwatch.ElapsedMilliseconds;
                //long is data type and can hold a lot of numbers. Generationtime will show the length of the number, will count in milliseconds 

                stopwatch.Restart();
                //resets the stopwartch and places it at zero 
                Array.Sort(numbers);
                //sorts the number in an efficienct based in numerical order 
                stopwatch.Stop();
                //stops the stopwatch 
                sortTime = (double) stopwatch.ElapsedMilliseconds;
                //this tells the stopwatch to measure the time in between start and stop and retruns in milliseconds 
                firstItems = GetItems<int>(numbers.AsSpan(), 100);
                //int variable with firstItems as rhe name will store n  array of 100 integers
               
            }



            catch (Exception ex)
            {//this exception will catch a errors such as invalid operation, null index out of range,formats and arguments 
                MessageBox.Show($"A unexpected Error has occured, PLease try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Show first 100 numbers in a message box (or use a ListBox for better display)
            string output = string.Join(Environment.NewLine, firstItems);
            MessageBox.Show(output, "First 100 Numbers");

            // Show the timing too
            MessageBox.Show($"Generation Time: {generationTime:F3} ms\nSort Time: {sortTime:F3} ms",
                "Performance", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static T[] GetItems<T>(ReadOnlySpan<T> span, int count)
        {
            if (count > span.Length)
            {
                count = span.Length;
            }
            T[] result = new T[count];
            span.Slice(0, count).CopyTo(result);
            return result;
        }
    }
}
