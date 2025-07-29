
namespace Leetcode.Easy;
public class ContainsDuplicateSolution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new();
        foreach (int num in nums)
        {
            if (seen.Contains(num)) return true;
            seen.Add(num);
        }
        return false;
    }
}
