<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>

<h1>Báo cáo các bước của thuật toán nhân số lớn, Binary Search và Merge Sort</h1>

<p>Báo cáo này mô tả chi tiết các bước của ba thuật toán được thực hiện bằng ngôn ngữ lập trình C#.</p>

<h2>Mục lục</h2>

<ol>
    <li><a href="#giới-thiệu">Giới thiệu</a></li>
    <li><a href="#binary-search">Binary Search</a></li>
    <li><a href="#merge-sort">Merge Sort</a></li>
    <li><a href="#big-number-multiplication">Thuật toán nhân số lớn</a></li>
    <li><a href="#cài-đặt-và-sử-dụng">Cài đặt và sử dụng</a></li>
    <li><a href="#ví-dụ-và-kết-quả">Ví dụ và kết quả</a></li>
</ol>

<h2 id="giới-thiệu">Giới thiệu</h2>

<p>Thuật toán Binary Search là một thuật toán tìm kiếm hiệu quả trên mảng đã được sắp xếp.</p>
<p>Thuật toán Merge Sort là một thuật toán sắp xếp dựa trên phương pháp chia để trị.</p>

<h2 id="binary-search">Binary Search</h2>

<h3>Mã nguồn</h3>

<pre><code>
using System;

namespace Cau01
{
    public class BinarySearch
    {
        public static int Binary_Search(int[] A, int n, int key)
        {
            int left = 0; // vị trí phần tử đầu tiên trong mảng
            int right = n - 1; // vị trí phần tử cuối cùng trong mảng

            while (left &lt;= right)
            {
                int mid = (left + right) / 2; // vị trí giữa mảng

                if (A[mid] == key)
                    return mid;

                if (key &lt; A[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1; // không tìm thấy key trong mảng nên trả về vị trí -1.
        }
    }
}
</code></pre>
<img src="https://github.com/user-attachments/assets/cfc67aa6-67a4-4a04-bbff-c092e0f51b66" alt="Merge Sort Step 1">
<img src="https://github.com/user-attachments/assets/c37df722-06a1-493a-990b-c5ff05b41496" alt="Merge Sort Step 2">
<img src="https://github.com/user-attachments/assets/9a5842ae-ab5a-4f7a-83e9-e6ec31ddf51f" alt="Merge Sort Step 3">
<img src="https://github.com/user-attachments/assets/0ca8eaa7-de38-4019-9638-0da4b61aefe8" alt="Merge Sort Step 4">

<h3>Video DEBUG</h3>

<a href="https://github.com/user-attachments/assets/4cbda80c-0c6c-4a2c-99c5-3e9ded7a9496">Xem video DEBUG Binary Search</a>

<h2 id="merge-sort">Merge Sort</h2>

<h3>Mã nguồn</h3>

<pre><code>
using System;

namespace Cau02
{
    public class MergeSort
    {
        public static void Merge_Sort(int[] A, int left, int right)
        {
            if (left &lt; right)
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
            for (i = 0; i &lt; n1; i++) // chép nữa dãy đầu của A vào L 
            {
                L[i] = A[left + i];
            }
            for (j = 0; j &lt; n2; j++) // chép nữa dãy sau của A và R 
            {
                R[j] = A[mid + 1 + j];
            }

            int k = left;
            i = 0;
            j = 0;

            for (k = left; k &lt;= right; k++) //
            {
                if (i &lt; n1 &amp;&amp; (j &gt;= n2 || L[i] &lt;= R[j]))
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
</code></pre>
<img src="https://github.com/user-attachments/assets/4a5a95bb-88be-43b5-98e8-cb84f187f8de" alt="mangbandau">
<img src="https://github.com/user-attachments/assets/1bf8e604-fb2b-495d-8201-95ff94ceff84" alt="step1">
<img src="https://github.com/user-attachments/assets/eee33c00-51b5-431c-b7c9-b9830825a33d" alt="step2">
<img src="https://github.com/user-attachments/assets/f75b4017-af70-4055-9632-35c67654a083" alt="step3">
<img src="https://github.com/user-attachments/assets/74f6efbb-dc3f-46d1-93ee-45333d2ab65e" alt="step4">
<img src="https://github.com/user-attachments/assets/dd102fdb-b4bd-4bb0-ab17-e5968942d528" alt="step5">
<img src="https://github.com/user-attachments/assets/b311a8ce-479c-48cd-abf9-8b39852a3779" alt="step6">
<img src="https://github.com/user-attachments/assets/6d199ad2-6701-4dd4-9da3-5bd87ad977b0" alt="step7">
<img src="https://github.com/user-attachments/assets/4b847827-69a7-420f-99b4-4c6fc49e511a" alt="step8">
<img src="https://github.com/user-attachments/assets/40b3b559-0c3d-4aad-ac18-9bc51d683b26" alt="step9">
<img src="https://github.com/user-attachments/assets/47b408b3-8064-4574-bc16-7e01956c1010" alt="step10">
<img src="https://github.com/user-attachments/assets/a6260398-81f7-47bf-aa6d-893c88155fa3" alt="step11">
<img src="https://github.com/user-attachments/assets/9bb20e39-401e-476d-b8ad-d759c0e375c7" alt="step12">
<img src="https://github.com/user-attachments/assets/73dc7534-57e9-434e-b433-d3790eb259ef" alt="step13 1">
<img src="https://github.com/user-attachments/assets/2e85d35f-08d2-4bb8-a936-2b24318e777f" alt="step13 2">
<img src="https://github.com/user-attachments/assets/d9b5f502-6108-4f7a-8919-0ec618fc5a33" alt="step13 3">



<h3>Video DEBUG</h3>
<a href="https://github.com/user-attachments/assets/bd92fcc6-9089-4ada-b529-4f8bc81661dc">Xem video DEBUG Merge Sort</a>

<h2 id="big-number-multiplication">Thuật toán nhân số lớn</h2>

<h3>Mã nguồn</h3>

<pre><code>
using System;

public class BigNumberMultiplication
{
    public static long Big_Number_Multi(long X, long Y, int n)
    {
        long m1, m2, m3, A, B, C, D;
        long s; // Lưu dấu của tích XY

        // Tính dấu của X * Y
        s = Sign(X) * Sign(Y);

        // Lấy giá trị tuyệt đối của X và Y
        X = Math.Abs(X);
        Y = Math.Abs(Y);

        // Trường hợp cơ bản: X và Y có 1 chữ số
        if (n == 1)
            return X * Y * s;
        else
        {
            // Chia X và Y thành các phần A, B và C, D tương ứng
            A = Left(X, n / 2);  // Số có n/2 chữ số đầu của X
            B = Right(X, n / 2); // Số có n/2 chữ số cuối của X
            C = Left(Y, n / 2);  // Số có n/2 chữ số đầu của Y
            D = Right(Y, n / 2); // Số có n/2 chữ số cuối của Y

            // Đệ quy tính toán các giá trị m1, m2, m3
            m1 = Big_Number_Multi(A, C, n / 2);        // m1 = A * C
            m2 = Big_Number_Multi(A - B, D - C, n / 2); // m2 = (A - B) * (D - C)
            m3 = Big_Number_Multi(B, D, n / 2);        // m3 = B * D

            // Tính kết quả theo công thức đệ quy
            return s * (m1 * (long)Math.Pow(10, n) + (m1 + m2 + m3) * (long)Math.Pow(10, n / 2) + m3);
        }
    }

    // Hàm trả về dấu của số nguyên
    private static long Sign(long num)
    {
        if (num > 0) return 1;
        if (num < 0) return -1;
        return 0;
    }

    // Hàm trả về phần đầu của số nguyên với số chữ số được chỉ định
    private static long Left(long num, int digits)
    {
        return num / (long)Math.Pow(10, digits);
    }

    // Hàm trả về phần cuối của số nguyên với số chữ số được chỉ định
    private static long Right(long num, int digits)
    {
        return num % (long)Math.Pow(10, digits);
    }
}
</code></pre>
<img src="https://github.com/user-attachments/assets/4de23061-a655-4faf-bbb9-adc450487445" alt="dulieubandau">
<img src="https://github.com/user-attachments/assets/dd12c291-fb7a-4415-bf1e-74958601861e" alt="step1">
<img src="https://github.com/user-attachments/assets/56a59dfb-56a4-40e9-af8a-5e45e86373fa" alt="step3">
<img src="https://github.com/user-attachments/assets/02dcaf95-6537-42c3-913c-5431513fb754" alt="step4">

<h3>Video DEBUG </h3>
<a href="https://github.com/user-attachments/assets/fa69ca7c-ddc7-48a5-b9d4-0dd14e04e1cb">Xem video DEBUG Big Number Multip</a>


<h2 id="cài-đặt-và-sử-dụng">Cài đặt và sử dụng</h2>
<h3>Binary Search</h3>
<p>Để sử dụng thuật toán Binary Search này, bạn có thể tích hợp vào dự án của mình và sử dụng như một phần của hệ thống tìm kiếm trong mảng.</p>
<pre><code>
int[] array = { 2, 4, 6, 8, 10, 12, 14, 16 };
int key = 10;
int index = BinarySearch.Binary_Search(array, array.Length, key);
if (index != -1)
{
    Console.WriteLine($"Tìm thấy {key} tại vị trí {index}");
}
else
{
    Console.WriteLine($"{key} không tồn tại trong mảng.");
}
</code></pre>
<h3>Merge Sort</h3>
<p>Để sử dụng thuật toán Merge Sort, bạn có thể áp dụng cho việc sắp xếp mảng trong các ứng dụng của mình.</p>
<pre><code>
int[] arrayToSort = { 12, 11, 13, 5, 6, 7 };
MergeSort.Merge_Sort(arrayToSort, 0, arrayToSort.Length - 1);
Console.WriteLine("Mảng sau khi sắp xếp bằng Merge Sort:");
foreach (var item in arrayToSort)
{
    Console.Write(item + " ");
}
Console.WriteLine();
</code></pre>
<h3>Thuật toán nhân số lớn</h3>
<p>Để sử dụng thuật toán nhân số lớn, bạn có thể áp dụng cho các số lớn hơn giới hạn của kiểu dữ liệu nguyên thủy.</p>
<pre><code>
long X = 2112;
long Y = 1707;
int N = 4;

long result = BigNumberMultiplication.Big_Number_Multi(X, Y, N);
Console.WriteLine($"Kết quả của {X} * {Y} là {result}");
</code></pre>
<h3>Video debug</h3>
<p><a href="https://www.example.com/binary_search_video" target="_blank">Xem video hướng dẫn Binary Search</a></p>
<p><a href="https://www.example.com/merge_sort_video" target="_blank">Xem video hướng dẫn Merge Sort</a></p>
<p><a href="https://www.example.com/big_number_multiplication_video" target="_blank">Xem video hướng dẫn Big Number Multiplication</a></p>

</body>
</html>
