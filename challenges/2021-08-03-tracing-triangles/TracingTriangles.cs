using Xunit;

public class TracingTriangles
{
    /*
    public int LongestPath(int[][] triangle)
    {
        // Insert your solution code here
        var sum = 0;
        foreach(var row in triangle)
        {
            sum += row.Max();
        }

        if (triangle.Length <= 2) return n;

        var paths = new List<int>();
        paths.Add (triangle[0][0] + triangle[1][0] + triangle[2][0]);
        paths.Add (triangle[0][0] + triangle[1][0] + triangle[2][1]);
        paths.Add (triangle[0][0] + triangle[1][1] + triangle[2][1]);
        paths.Add (triangle[0][0] + triangle[1][1] + triangle[2][2]);
        
        return paths.Max();
        //return 0;
    }
    */

    public int LongestPath(int[][] triangle, int? row = 0, int? column = 0)
    {
        if(row + 1 > triangle.Length) 
        {
            return triangle[row][column];

        }
        // First value, second finds the longest path in the second row, the third finds the longest path in the third row
        return triangle[row!.Value][column!.Value] + Math.Max(LongestPath(triangle, row+1,column),+LongestPath(triangle,row+1,column+1));
    }




    [Fact]
    public void Test_case_one_()
    {
        int[][] input = new int[][] {new[] {1}, new[] {2, 3}, new[] {1, 5, 1}};
        Assert.Equal(9, LongestPath(input));
    }

    [Fact]
    public void Test_case_two_()
    {
        int[][] input = new int[][] {new[] {6}, new[] {4, 4}, new[] {1, 2, 1}, new[] {5, 4, 3, 2}};
        Assert.Equal(16, LongestPath(input));
    }

    [Fact]
    public void Test_case_three_()
    {
        int[][] input = new int[][] {new[] {5}};
        Assert.Equal(5, LongestPath(input));
    }

    [Fact]
    public void Test_case_four_()
    {
        int[][] input = new int[][] {new[] {1}, new[] {1, 1}, new[] {1, 1, 1}, new[] {2, 1, 1, 1}};
        Assert.Equal(5, LongestPath(input));
    }

    [Fact]
    public void Test_case_five_()
    {
        int[][] input = new int[][] {new[] {0}, new[] {0, 0}, new[] {0, 0, 0}};
        Assert.Equal(0, LongestPath(input));
    }
}
