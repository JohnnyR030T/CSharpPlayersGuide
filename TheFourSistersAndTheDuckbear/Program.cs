
int gatheredEggs = 0;
int.TryParse(Console.ReadLine(), out gatheredEggs);

if (gatheredEggs / 2 == 0)
{
    Console.WriteLine($"Each sister should get {gatheredEggs / 2} eggs.");
}
else
{
    Console.WriteLine($"Each sister should get {gatheredEggs / 2} eggs and the duckbear should get {gatheredEggs % 2} egg.");
}