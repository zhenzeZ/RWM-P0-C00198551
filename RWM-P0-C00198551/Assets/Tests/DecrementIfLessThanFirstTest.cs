using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class DecrementIfLessThanFirstTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Decrement()
        {
            // Use the Assert class to test conditions
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 };
            int[] output = DecrementIfLessThanFirst.answerList(input);
            int[] expexted = { 4, 1, 8, 2, 9, 4, 10, 5, 11, 6, 0 };

            CollectionAssert.AreEqual(expexted, output);
        }

        [Test]
        public void Modulo()
        {
            // Use the Assert class to test conditions
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = ModuloFirst.answerList(input);
            int[] expexted = { 0, 2, 0, 3, 1, 0, 2, 1, 3, 2 };

            CollectionAssert.AreEqual(expexted, output);
        }

    }
}
