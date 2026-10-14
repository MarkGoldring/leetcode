public static class Solution0016 {
   public static int ThreeSumClosest(int[] nums, int target) {
      var results = new Dictionary<string, IList<int>>();

      if(nums.All(x => x == 0))
      {
        return 0;
      }
      
      // sort the array smalles to largest
      //nums.Sort();

      // anchor first pointer
      int minDelta = int.MaxValue;
      int nearestSum = 0;
      for(int i = 0; i < nums.Length; i++) 
      {
         // anchor second pointer
         for(int j = 0; j < nums.Length; j++) 
         {
            if(j == i) continue;
            // so we now have i and j that sum to 
            //var sumij = nums[i] + nums[j];
            for(int k = 0; k < nums.Length; k++) 
            {
               if(k == i || k == j) continue;
               var sum = nums[i] + nums[j] + nums[k];
               var delta = Math.Abs(target - sum);
               if(delta < minDelta)
               {
                  minDelta = delta;
                  nearestSum = sum;
               }
            }
         }
      }

      return nearestSum;
   }
}
