public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var car = position.Zip(speed, (p, s) => (Position: p, Speed: s))
                      .OrderByDescending(car => car.Position)
                      .ToArray();
        var stack = new Stack<double>();
        for (int i = 0; i < car.Length; i++) {
            double expectedTime = (double)(target - car[i].Position) / car[i].Speed;
            if (stack.Count == 0 || expectedTime > stack.Peek())
                stack.Push(expectedTime);
        }
        return stack.Count;
    }
}
