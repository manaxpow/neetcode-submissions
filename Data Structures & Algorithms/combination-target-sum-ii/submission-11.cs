public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<List<int>>();
        Array.Sort(candidates);
        BackTracking(candidates, target, 0, 0, new List<int>(), result);
        return result;
    }

    private void BackTracking(int [] candidates, int target,int cur, int total, List<int> path, List<List<int>> result)
    {
        if(total == target)
        {
            result.Add(new List<int>(path));
            return;
        }
        if(total > target)
            return;

        for(int i =cur; i< candidates.Length; i++)
        {
            if(total + candidates[i] > target) break;
            if(i > cur && candidates[i] == candidates[i-1]) continue;
            path.Add(candidates[i]);

            BackTracking(candidates, target, i+1, total + candidates[i], path, result);

            path.RemoveAt(path.Count -1);
        }
    }
}
