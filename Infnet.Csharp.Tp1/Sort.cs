namespace Infnet.Csharp.Tp1
{
    public class Sort
    {
        public void BubbleSort(int[] arrayToSort)
        {
            var changed = true;
            do
            {
                changed = false;
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i+1])
                    {
                        var itemToSwap = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = itemToSwap;
                        changed = true;
                    }
                }
            } while (changed);
        }
    }
}
