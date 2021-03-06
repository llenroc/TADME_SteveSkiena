﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ch04
{
    using AHM = AAL_HelperMethods;
    using A1 = AAL_01_MergeSort;
    using A2 = AAL_02_QuickSort;

    [TestClass]
    public class UT_Algorithms
    {
        [TestMethod]
        public void Ch04_AL_01_MergeSort_ReturnValidAnswer()
        {
            int[] arr_01 = AHM.CreateRandomIntArray();
            int[] arr_01_copy = new int[arr_01.Length];
            arr_01.CopyTo(arr_01_copy, 0);

            Array.Sort(arr_01);
            A1.MergeSort(arr_01_copy);

            Assert.AreEqual(arr_01.Length, arr_01_copy.Length);
            for(int i=0; i<arr_01.Length; i++)
            {
                Assert.AreEqual(arr_01[i], arr_01_copy[i]);
            }            
        }

        [TestMethod]
        public void Ch04_AL_02_QuickSort_ReturnValidAnswer()
        {
            int[] arr_01 = AHM.CreateRandomIntArray();
            int[] arr_01_copy = new int[arr_01.Length];
            arr_01.CopyTo(arr_01_copy, 0);

            Array.Sort(arr_01);
            A2.QuickSort(arr_01_copy);

            Assert.AreEqual(arr_01.Length, arr_01_copy.Length);
            for (int i = 0; i < arr_01.Length; i++)
            {
                Assert.AreEqual(arr_01[i], arr_01_copy[i]);
            }
        }
    }
}
