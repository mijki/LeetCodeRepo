namespace LeetCodeRepo.Problems.Programming_skills_I;

public class _1232_CheckIfItIsAStraightLine {
    public static bool CheckStraightLine(int[][] coordinates)
    {
        // Slope can be defined by (y2-y1)/(x2-x1)
        int deltaX = coordinates[1][0] - coordinates[0][0];
        int deltaY = coordinates[1][1] - coordinates[0][1]; 
        double slope = (double)deltaY / deltaX;
        double interceptY = coordinates[0][1] - slope * coordinates[0][0];
        
        //When X or Y is permanent
        if (double.IsInfinity(slope))
        {
            for(int i = 0; i < coordinates.Length; i++)
            {
                if (coordinates[i][0] != coordinates[0][0]) return false;
            }
        }
        //If the slope is not equal 0
        else if(!double.IsInfinity(slope))
        {
            for (int i = 0; i < coordinates.Length; i++)
            {
                if (coordinates[i][1] != coordinates[i][0] * slope + interceptY) return false;
            }
        }
        return true;
    }
}