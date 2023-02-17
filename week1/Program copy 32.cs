Random rand = new Random(0);
var howManyTimes = 500;
var dieSides = 6;

List<List<int>> results = new List<List<int>>();
for (int i = 0; i < howManyTimes; i++)
{
    List<int> rollResults = new List<int>();
    for (int j = 0; j < 2; j++)
    {
        rollResults.Add(rand.Next(1, dieSides + 1));
    }
    results.Add(rollResults);
}

List<string> freqs = new List<string>
{
    " 2: ",
    " 3: ",
    " 4: ",
    " 5: ",
    " 6: ",
    " 7: ",
    " 8: ",
    " 9: ",
    "10: ",
    "11: ",
    "12: ",
};

foreach (List<int> rollResult in results)
{
    int sum = rollResult[0] + rollResult[1];
    freqs[sum - 2] += "|";
}

foreach (string freq in freqs)
{
    Console.WriteLine(freq);
}
