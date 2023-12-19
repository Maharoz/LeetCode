//https://leetcode.com/problems/distant-barcodes/description/

int[] barcodes2 = { 1, 1, 1, 1, 2, 2, 3, 3 };
int[] rearranged2 = RearrangeBarcodes(barcodes2);
Console.WriteLine("Example 2 Output:");
foreach (var barcode in rearranged2)
{
    Console.Write(barcode + " ");
}
Console.WriteLine();
static int[] RearrangeBarcodes(int[] barcodes)
{
    Dictionary<int, int> counts = new Dictionary<int, int>();
    foreach (int barcode in barcodes)
    {
        if (!counts.ContainsKey(barcode))
            counts[barcode] = 0;
        counts[barcode]++;
    }

    var sortedBarcodes = counts.OrderByDescending(kv => kv.Value)
                               .SelectMany(kv => Enumerable.Repeat(kv.Key, kv.Value))
                               .ToArray();

    int[] result = new int[barcodes.Length];
    int index = 0;
    for (int i = 0; i < barcodes.Length; i += 2)
    {
        result[i] = sortedBarcodes[index++];
    }

    for (int i = 1; i < barcodes.Length; i += 2)
    {
        result[i] = sortedBarcodes[index++];
    }

    return result;
}
