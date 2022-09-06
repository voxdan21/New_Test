int[] nums = new int[10]{10,45,23,45,65,23,43,56,23,23};
int max = nums[0];
int count = 0;
for (int i = 0; i < 10; i++)
{
    if(nums[i]>max)
    {
     max = nums[i]; 
    
    }
}

Console.WriteLine(max);
