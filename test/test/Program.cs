int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


SpiralMatrix(matrix);
static void SpiralMatrix(int[,] arr)
{
	int rows = arr.GetLength(0);
	int cols = arr.GetLength(1);

	int top = 0 ; int bottom = rows-1;int left = 0 ;int right = cols-1 ;
	int dir = 1;

	while(top <= bottom && left <= right)
	{
		if(dir == 1)
		{
			for(int i = left; i <= right; i++)
			{
				Console.Write(arr[top,i]+ " ");
            }
			top++;
			dir = 2;
		}
		else if(dir == 2)
		{
			for (int i = top; i <= bottom; i++)
			{
				Console.Write(arr[i, right] + " ");
			
			}
			right--;
			dir = 3;
		}
		else if (dir == 3)
		{
			for (int i = right; i >= left; i--)
			{
				Console.Write(arr[bottom, i] + " ");
			
			}
			bottom--;
			dir = 4;
		}
		else if (dir == 4)
		{
			for (int i = bottom; i >= top; i--)
			{
				Console.Write(arr[i, left] + " ");
			
			}
			left++;
			dir = 1;
		}
	}
}