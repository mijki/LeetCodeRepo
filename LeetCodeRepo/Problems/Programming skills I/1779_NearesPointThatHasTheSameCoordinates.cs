namespace LeetCodeRepo.Problems.Programming_skills_I;

public class _1779_NearesPointThatHasTheSameCoordinates {
    public static int NearestValidPoint(int x, int y, int[][] points)
    {
        int goodClosestPoint = -1;
        int manhattanDistance = 0, minDistance = 10001;
        for(int i = 0; i < points.Length; i++)
        {
            if (points[i][0] == x || points[i][1] == y)
            {
                manhattanDistance = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                if (manhattanDistance < minDistance)
                {
                    minDistance = manhattanDistance;
                    goodClosestPoint = i;
                }
            }
            
        }
        return goodClosestPoint;
    }
}