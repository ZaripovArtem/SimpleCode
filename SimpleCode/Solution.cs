namespace SimpleCode
{
    public class Solution
    {
        public static int[] solution(string[] A, string[] B)
        {
            List<int> res = new();
            int check = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i].EndsWith(B[j]))
                    {
                        check++;
                    }
                }
                if (check == 0)
                {
                    res.Add(i);
                }
                else { check = 0; }
            }

            return res.ToArray();
        }
    }
}