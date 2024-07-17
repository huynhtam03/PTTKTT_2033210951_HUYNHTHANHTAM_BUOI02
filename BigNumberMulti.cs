using System;

namespace Cau03
{
    public class BigNumberMulti
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
                return s * (m1 * (int)Math.Pow(10, n) + (m1 + m2 + m3) * (int)Math.Pow(10, n / 2) + m3);
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
}
