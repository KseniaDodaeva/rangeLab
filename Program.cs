namespace rangeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]arr = { -11, 2, 3, -6, -4, 4, 7, 8, 5, 3, -8, -8, 3, 4, 5, 5, 6, 7, 7, 7 };
            Dictionary<int, int[]> sequences = new Dictionary<int, int[]>();
            for (int i = 0; i < arr.Length; i++)
            {
                int[] seq = arr.Skip(i).TakeWhile(x => x > 0).ToArray();
                int count = seq.Length;

                if (count != 0)
                {
                    sequences.Add(i,seq);
                    i += count;
                }
            }
            Console.WriteLine("sequences: ");
            foreach (var pair in sequences) Console.WriteLine("[{0}][{1}]: [{2}]",pair.Key, pair.Value.Length, string.Join(" ", pair.Value));
            int max = sequences.First(y => y.Value.Length == sequences.Select(x => x.Value.Length).Max()).Key;
            Console.WriteLine();


        }
    }
}

