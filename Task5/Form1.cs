namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] BubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }

        public class Sorter
        {
            public int[] SortDescending(int[] numbers)
            {
                int n = numbers.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (numbers[j] < numbers[j + 1])
                        {
                            int temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                        }
                    }
                }
                return numbers;
            }
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = BubbleSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }

        private void btnDescendingSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            Sorter sorter = new Sorter();
            int[] sortedNumbers = sorter.SortDescending(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
