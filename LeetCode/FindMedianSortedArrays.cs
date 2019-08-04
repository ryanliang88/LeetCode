using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    /**
     * https://leetcode.com/problems/median-of-two-sorted-arrays/
     * Generally understood
     *
     * Credit: https://medium.com/@hazemu/finding-the-median-of-2-sorted-arrays-in-logarithmic-time-1d3f2ecbeb46
     */

    public class FindMedianSortedArrays
    {
        public double Solution(int[] A, int[] B)
        {
            if (Object.ReferenceEquals(A, null) || Object.ReferenceEquals(B, null))
            {
                throw new ArgumentNullException();
            }

            int aLen = A.Length;
            int bLen = B.Length;

            // Make sure we always search the shorter array.
            if (aLen > bLen)
            {
                Swap(ref A, ref B);
                Swap(ref aLen, ref bLen);
            }

            int leftHalfLen = (aLen + bLen + 1) / 2;

            // Since A is guaranteed to be the shorter array,
            // we know it can contribute 0 or all of its values.
            int aMinCount = 0;
            int aMaxCount = aLen;

            while (aMinCount <= aMaxCount)
            {
                int aCount = aMinCount + ((aMaxCount - aMinCount) / 2);
                int bCount = leftHalfLen - aCount;

                //
                // Make sure aCount is greater than 0 (because A can contribute 0 values;
                // remember that A is either shorter or of the same length as B). This also
                // implies bCount will be less than B.Length since it won't be possible
                // for B to contribute all of its values if A has contributed at least 1
                // value.
                //
                if (aCount > 0 && A[aCount - 1] > B[bCount])
                {
                    // Decrease A's contribution size; x lies in the right half.
                    aMaxCount = aCount - 1;
                }

                //
                // Make sure aCount is less than A.Length since A can actually contribute
                // all of its values (remember that A is either shorter or of the same
                // length as B). This also implies bCount > 0 because B has to contribute
                // at least 1 value if aCount < A.Length.
                //
                else if (aCount < aLen && B[bCount - 1] > A[aCount])
                {
                    // Decrease B's contribution size, i.e. increase A's contribution size;
                    // y lies in the right half.
                    aMinCount = aCount + 1;
                }
                else
                {
                    //
                    // Neither x nor y lie beyond the left half. We found the right aCount.
                    // We don't know how x and y compare to each other yet though.
                    //

                    //
                    // If aLen + bLen is odd, the median is the greater of x and y.
                    //
                    int leftHalfEnd =
                        (aCount == 0)             // A not contributing?
                            ? B[bCount - 1]       // aCount = 0 implies bCount > 0
                            : (bCount == 0)       // B is not contributing?
                                ? A[aCount - 1]   // bCount = 0 implies aCount > 0
                                : Math.Max(A[aCount - 1], B[bCount - 1]);

                    if (IsOdd(aLen + bLen))
                    {
                        return leftHalfEnd;
                    }

                    //
                    // aLen + bLen is even. To compute the median, we need to find
                    // the first element in the right half, which will be the smaller
                    // of A[aCount] and B[bCount]. Remember that aCount could be equal
                    // to A.Length, bCount could be equal to B.Length (if all the values
                    // of A or B are in the left half).
                    //
                    int rightHalfStart =
                        (aCount == aLen)          // A is all in the left half?
                            ? B[bCount]           // aCount = aLen implies bCount < B.Length
                            : (bCount == bLen)    // B is all in the left half?
                                ? A[aCount]       // bCount = B.Length implies aCount < A.Length
                                : Math.Min(A[aCount], B[bCount]);
                    return (leftHalfEnd + rightHalfStart) / 2.0;
                }
            }

            throw new InvalidOperationException("Unexpected code path reached");
        }

        private void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        // The least significant bit of any odd number is 1.
        private bool IsOdd(int x) => (x & 1) == 1;
    }
}
