public static class Solution11 {
    public static int MaxArea(int[] height) {
        
        // left and right pointers
        int left = 0, right = height.Length - 1, max = 0;

        while(left < right) {
            // calculate volume
            var width = right - left;
            var volume = width * Math.Min(height[left], height[right]);
            // store if beats the current max
            if(volume > max) {
                max = volume;
            }
            // move smaller of left and right
            if(height[right] < height[left]) {
                right -= 1;
            } else {
                left += 1;
            }
        }

        return max;
    }
}
