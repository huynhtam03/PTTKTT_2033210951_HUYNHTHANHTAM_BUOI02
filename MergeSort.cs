using System;

namespace Cau02
{
    public class MergeSort
    {
        public static void Merge_Sort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2; // vị trí phần tử ở giữa dãy

                Merge_Sort(A, left, mid); // gọi hàm Merge_Sort cho nửa dãy con đầu

                Merge_Sort(A, mid + 1, right); // gọi hàm Merge_Sort cho nửa dãy con cuối

                Merge(A, left, mid, right); // Hàm trộn 2 dãy con có thứ tự thành dãy ban đầu có thứ tự
            }
        }
        public static void Merge(int[] A, int left, int mid, int right)
        {
            int n1 = mid - left + 1; // độ dài nửa dãy đầu của A 
            int n2 = right - mid; // độ dài nữa dãy sau của A 

            int[] L = new int[n1]; // mảng tạm chứa nữa dãy đầu A Và nữa dãy sau A
            int[] R = new int[n2];
            int i, j;
            for (i = 0; i < n1; i++) // chép nữa dãy đầu của A vào L 
            {
                L[i] = A[left + i];
            }
            for (j = 0; j < n2; j++) // chép nữa dãy sau của A và R 
            {
                R[j] = A[mid + 1 + j];
            }

            int k = left;
            i = 0;
            j = 0;

            for (k = left; k <= right; k++) //
            {
                if (i < n1 && (j >= n2 || L[i] <= R[j]))
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
            }
        }
    }

}
