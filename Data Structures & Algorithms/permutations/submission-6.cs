public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var result = new List<List<int>>();
        bool[] visited = new bool[nums.Length];
        for(int i=0; i < nums.Length; i++)
        {
            visited[i]=false;
        }

        BackTracking(nums, visited, new List<int>(), result);
        return result;
    }
    private void BackTracking(int[]nums,bool[] visited,List<int> path, List<List<int>> result)
    {
        // add result when it satisfies a permutation
        if(path.Count == nums.Length)
        {
            result.Add(new List<int>(path));
            return;
        }

        for(int i=0; i< nums.Length; i++)
        {
            if(visited[i]) continue;

            // add and turn on flag
            visited[i] = true;
            path.Add(nums[i]);
            BackTracking(nums,visited,path,result);

            // backtracking
            visited[i] = false;
            path.RemoveAt(path.Count -1);
        }
    }
}
