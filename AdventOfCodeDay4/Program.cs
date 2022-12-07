string[] lines = System.IO.File.ReadAllLines(@"C:\Users\chris\source\repos\AdventOfCodeDay4\AdventOfCodeDay4\TextFile1.txt");
int total = 0;
int overlapTotal = 0;
//part 1
//foreach (string line in lines)
//{
//    var pair = line.Split(',');
//    var elf1 = pair[0].Split('-');
//    var elf2 = pair[1].Split('-');
//    if (Int32.Parse(elf1[0]) >= Int32.Parse(elf2[0]) && Int32.Parse(elf1[1]) <= Int32.Parse(elf2[1]))
//    {
//        total++;
//    }
//    else if (Int32.Parse(elf2[0]) >= Int32.Parse(elf1[0]) && Int32.Parse(elf2[1]) <= Int32.Parse(elf1[1]))
//    {
//        total++;
//    }
//}
//Console.WriteLine(total);
//part 2
foreach (string line in lines)
{
    var pair = line.Split(',');
    var elf1 = pair[0].Split('-');
    var elf2 = pair[1].Split('-');
    var elf1Range = new List<int>();
    var elf2Range = new List<int>();
    for (int i = Int32.Parse(elf1[0]); i <= Int32.Parse(elf1[1]); i++)
    {
        elf1Range.Add(i);
    }
    for (int i = Int32.Parse(elf2[0]); i <= Int32.Parse(elf2[1]); i++)
    {
        elf2Range.Add(i);
    }
    foreach (var item in elf1Range)
    {
        if (elf2Range.Contains(item))
        {
            overlapTotal++;
            break;
        }
    }
}
Console.WriteLine(overlapTotal);