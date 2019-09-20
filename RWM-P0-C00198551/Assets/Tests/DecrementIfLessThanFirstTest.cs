using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class DecrementIfLessThanFirstTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 };
            int[] output = DecrementIfLessThanFirst.answerList(input);
            int[] expexted = { 4, 1, 8, 2, 9, 4, 10, 5, 11, 6, 0 };

            CollectionAssert.AreEqual(expexted, output);
        }

    }
}
