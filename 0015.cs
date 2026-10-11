public static class Solution0015 {
   public static IList<IList<int>> ThreeSum(int[] nums) {
      var results = new Dictionary<string, IList<int>>();

      if(nums.All(x => x == 0))
      {
        return [[0,0,0]];
      }
      
      // sort the array smalles to largest
      nums.Sort();

      // scan the whole array and create a dictionary of value to index/es
      var valueLookup = new Dictionary<int, List<int>>();
      for(var i = 0; i < nums.Length; i++) {
         var val = nums[i];
         if(valueLookup.ContainsKey(val))
         {
            valueLookup[val].Add(i);
         }
         else
         {
            valueLookup.Add(val, [ i ]);
         }
      }

      // anchor first pointer
      for(int i = 0; i < nums.Length; i++) 
      {
         // anchor second pointer
         for(int j = 0; j < nums.Length; j++) 
         {
            if(j == i) continue;
            // so we now have i and j that sum to 
            var sumij = nums[i] + nums[j];
            // do we have a unique index that will bring the sum to zero
            var targetVal = 0 - (nums[i] + nums[j]);
            if(valueLookup.TryGetValue(targetVal, out var indexes))
            {
                var index = indexes.FindIndex(k => k != i && k != j);
                if(index != -1) 
                {
                    var k = indexes[index];
                    ProcessTriple(results, nums, i, j, k);   
                }
            }
         }
      }

      List<IList<int>> list = [.. results.Values];
      return list;
    }

    private static void ProcessTriple(Dictionary<string, IList<int>> dict, int[] nums, int i, int j, int k) 
    {
        // p1, p2, p3 that sums to zero
        // sort the values and add to dict if not already there
        var valI = nums[i];
        var valJ = nums[j];
        var valK = nums[k];
        if(valI + valJ + valK == 0)
        {
            int[] arr = [valI, valJ, valK];
            arr.Sort();
            var key = $"{arr[0]}:{arr[1]}:{arr[2]}";
            if(!dict.ContainsKey(key))
            {
                dict.Add(key, arr); 
            }
        }
   }
}
