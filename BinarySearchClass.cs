using System.Collections.Generic;

namespace CSharpTechnic
{
    class BinarySearchClass
    {
        public static int BinarySearch(List<int> sortedArr, int target, int start, int end)
        {
            int mid = (end + start) / 2;

            if (sortedArr[mid] == target) return mid;
            else if (sortedArr[mid] > target) return BinarySearch(sortedArr, target, start, mid - 1);
            else if (sortedArr[mid] < target) return BinarySearch(sortedArr, target, mid + 1, end);

            return -1;
        }
        public static int BinarySearch(List<string> sortedArr, string target, int start, int end)
        {
            int mid = (end + start) / 2;
            int compare = QuickSortClass.CompareTo(sortedArr[mid], target);

            //if (compare == 0) return mid;
            //else if (compare == 1) return BinarySearch(sortedArr, target, mid + 1, end);
            //else if (compare == -1) return BinarySearch(sortedArr, target, start, mid - 1);
            //return -1;

            if (start > end) return -1;
            return compare == 0 ? mid : compare == 1 ? BinarySearch(sortedArr, target, mid + 1, end) : BinarySearch(sortedArr, target, start, mid - 1);
        }

    }
}