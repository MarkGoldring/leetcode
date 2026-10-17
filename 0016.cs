public static class Solution0016 {
   public static int ThreeSumClosest(int[] nums, int target) {
      var results = new Dictionary<string, IList<int>>();

      if(nums.All(x => x == 0))
      {
        return 0;
      }
      
      // sort the array smalles to largest
      nums.Sort();

      int n = nums.Length;
      int result = nums[0] + nums[1] + nums[2]; // initial best guess

      // anchor first pointer
      for(int i = 0; i < n - 2; i++) 
      {
          // reste left and right pointers
          int left = i + 1, right = n - 1;
          while(left < right) 
          {
            // is current sum closer than current result?
             int sum = nums[i] + nums[left] + nums[right];
             if(Math.Abs(target - sum) < Math.Abs(target - result))
             {
                result = sum;
             }
             
             // check for exact match
             if(sum == target) 
             {
                return target;
             }

            // if the sum under target, move left point right 
             if(sum < target)
             {
                left++;
             }
             // if the sum is over target, move right point left
             else
             {
                right--;
             }
          }
   }
}
