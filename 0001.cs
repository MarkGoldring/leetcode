public static class Solution0001 {
    public static int[] TwoSum(int[] nums, int target) {
        for(var x = 0; x < nums.Length; x++) {
            for(var y = x + 1; y < nums.Length; y++) {
                if(nums[x] + nums[y] == target) {
                    return [
                        x, y
                    ];
                }
            }
        }       
        return [];
    }
}
