namespace Leetcode.Easy;
public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Using a Dictionary to store the numbers and their indices
        // Alternatively, you can use ConcurrentDictionary if you want to ensure thread safety
        Dictionary<int, int> seen = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int compliment = target - nums[i];
            // Check if the compliment exists in the dictionary
            // If it does, return the indices of the two numbers
            if (seen.ContainsKey(compliment)) return new int[] { i, seen[compliment] };

            // If the compliment does not exist, add the current number and its index to the dictionary
            if (!seen.ContainsKey(nums[i]))
            {
                // seen[nums[i]] = i;
                seen.TryAdd(nums[i], i);
            }
        }
        return Array.Empty<int>(); // In case no match found
    }
}
