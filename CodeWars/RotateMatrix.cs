namespace CodeWars
{
    public static class RotateMatrix
    {
        public static int[,] RotateMatrixLeft(int[,] matrix)
        {
            var n = matrix.GetLength(0);
            var m = matrix.GetLength(1);

            var res = new int[m--, n--];

            for (var c = m; c >= 0 ; c--)
            {
                for (var r = 0; r <= n; r++)
                {
                    res[m-c, r] = matrix[r, c];
                }
            }

            return res;
        }
    }
}
