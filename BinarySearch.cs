using System;


namespace Cau01
{
    public class BinarySearch
    {
        public static int Binary_Search(int[] A, int n, int key)
        {
            int left = 0; // vị trí phần tử đầu tiên trong mảng
            int right = n - 1; // vị trí phần tử cuối cùng trong mảng

            while (left <= right)
            {
                int mid = (left + right) / 2; // vị trí giữa mảng

                if (A[mid] == key)
                    return mid;

                if (key < A[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1; // không tìm thấy key trong mảng nên trả về vị trí -1.
        }
    }
}
