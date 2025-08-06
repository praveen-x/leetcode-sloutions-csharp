public class FruitsIntoBaskets2Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
       
        int result = fruits.Length;
        bool[] used = new bool[baskets.Length];

        for (int i = 0; i < fruits.Length; i++)
        {
            for (int j = 0; j < baskets.Length; j++)
            {
                if (!used[j] && baskets[j] >= fruits[i])
                {
                    used[j] = true;
                    result--;
                    break;
                }            
            }
        }
        return result;
    }
}