using System.Linq;

namespace CyclicRotation
{
	public class Solution
	{
		private int[] rotate(int[] B)
		{
			int[] rotatedB = B.ToArray();

			for (int i = 0; i < B.Count(); i++) {
				if (i == 0) {
					rotatedB[i] = B[B.Count() - 1];
				} else {
					rotatedB[i] = B[i - 1];
				}
			}

			return rotatedB;
		}

		public int[] solution(int[] A, int K)
		{
			int[] rotatedA = A;

			for (int i = 1; i <= K; i++)
				rotatedA = rotate(rotatedA);

			return rotatedA;
		}
	}
}
