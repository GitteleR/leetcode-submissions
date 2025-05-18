int left = 0;
int right = height.Length - 1;
int maxArea = 0;

while (left < right)
{
    int heightOfContainer = Math.Min(height[left], height[right]);
    int width = right - left;
    int area = heightOfContainer * width;
    maxArea = Math.Max(maxArea, area);

    // move shorter line inwards --> if left shorter go next and vise versa
    if (height[left] < height[right])
        left++;
    else
        right--;
}
