CSC295 Linear Search and Binary Search (Big O)

Code to test the methods:


using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LinearSearch_TargetIsInArray_ShouldReturnValidIndex()
        {
            // AAA - Arrange, Act, Assert
            // Arrange - setting the test up - creating mocks
            int[] arr1 = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act - This is where you call the code you are wanting to test
            int arr1Result = Program.LinearSearch(arr1, 4);

            // Assert - is the outcome what you expected
            Assert.AreEqual(arr1Result, 5);
        }

        [TestMethod()]
        public void LinearSearch_TargetIsNotInArray_ShouldReturnNegativeOne()
        {
            // AAA - Arrange, Act, Assert
            // Arrange - setting the test up - creating mocks
            int[] arr1 = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Act - This is where you call the code you are wanting to test
            int arr1Result = Program.LinearSearch(arr1, 16);
            // Assert - is the outcome what you expected
            Assert.AreEqual(arr1Result, -1);

        }

        [TestMethod()]
        public void BinarySearch_TargetIsLowerInArray_ShouldReturnValidIndex()
        {   // Arrange - setting the test up - creating mocks
            int[] arr2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Act - This is where you call the code you are wanting to test
            int arr2Result = Program.BinarySearch(arr2, 3);
            // Assert - is the outcome what you expected
            Assert.AreEqual(arr2Result, 3);
        }

        [TestMethod()]
        public void BinarySearch_TargetIsUpperInArray_ShouldReturnValidIndex()
        {   // Arrange - setting the test up - creating mocks
            int[] arr2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Act - This is where you call the code you are wanting to test
            int arr2Result = Program.BinarySearch(arr2, 6);
            // Assert - is the outcome what you expected
            Assert.AreEqual(arr2Result, 6);
        }

        [TestMethod()]
        public void BinarySearch_TargetIsNotInArray_ShouldReturnNegativeOne()
        {   // Arrange - setting the test up - creating mocks
            int[] arr2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Act - This is where you call the code you are wanting to test
            int arr2Result = Program.BinarySearch(arr2, 21);
            // Assert - is the outcome what you expected
            Assert.AreEqual(arr2Result, -1);
        }

        [TestMethod()]
        public void BinarySearch_ArrayEmpty_ShouldReturnNegativeOne()
        {   // Arrange - setting the test up - creating mocks
            int[] arr2 = Array.Empty<int>();
            // Act - This is where you call the code you are wanting to test
            int arr2Result = Program.BinarySearch(arr2, 16);
            // Assert - is the outcome what you expected
            Assert.AreEqual(arr2Result, -1);
        }
    }
}
