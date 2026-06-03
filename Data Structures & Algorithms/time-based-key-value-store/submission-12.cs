public class TimeMap {
    private Dictionary<string, List<(string value, int timestamp)>> dict;

    public TimeMap() {
        dict = new Dictionary<string, List<(string value, int timestamp)>>();
    }

    public void Set(string key, string value, int timestamp) {
        if (!dict.ContainsKey(key)) {
            dict[key] = new List<(string value, int timestamp)>();
            dict[key].Add((value, timestamp));
        } else {
            var index = FindingTargetOrPrevious(dict[key], timestamp);
            if (index == -1)
                dict[key].Add((value, timestamp));
            else {
                if (dict[key][index].timestamp < timestamp)
                    dict[key].Insert(index + 1, (value, timestamp));

                else
                    dict[key].Insert(index, (value, timestamp));
            }
        }
    }

    public string Get(string key, int timestamp) {
        if (!dict.ContainsKey(key))
            return "";

        var index = FindingTargetOrPrevious(dict[key], timestamp);
        if (index == -1)
            return "";

        return dict[key][index].value;
    }

    private int FindingTargetOrPrevious(List<(string value, int timestamp)> list, int target) {
        if (list.Count == 0)
            return -1;
        int l = 0, r = list.Count - 1;

        while (l <= r) {
            int pivot = l + (r - l) / 2;
            if (target == list[pivot].timestamp)
                return pivot;
            if (target > list[pivot].timestamp) {
                l = pivot + 1;
            } else {
                r = pivot - 1;
            }
        }
        return r;
    }
}
