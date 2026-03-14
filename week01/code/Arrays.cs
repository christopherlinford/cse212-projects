using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Payloads;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // My plan of action to solve problem 1
        // step one is to make a place to hold the multiple numbers. We will create an array that should hold the number of mulitple required
        // from the input number or count.

        // Step 2: Use a loop that runs from 0 up to the count - 1 or length.
        // each loop will go through or iterate through one calculation of the multiple.

        // step 3: The first number multiple will be starting. The second multiple is start * 2, the 3rd is start * 3, and will 
        // keep going until all numbers in  length count part  are done.

        // step 4: store each calculated multiple in the array at the current index

        // step 5: after the loop finishes filling the array, return the completed array.


        // create array to store multiples
        double[] multiples = new double[length];

        //loop through array and calculate the multiple
        for (int i = 0; i < length; i++)
        { // multiply the starting number by (i +1 ) to get the correct multiple
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // Process to solve the problem #2

        // step 1: I need to figure out how many numbers from the end of the list need to move to the front of the list.
        // This number of things or elements is equal to the amount in the function.

        // step 2: I need to get the last amount number from the list. this is done using the GetRange() process.
        // how this looks
        // If the the list has 9 numbers in it and the amount number is 3, start the index at
        // start index = data.amount - amount = 6

        // step 3: This is where I will store the elments in a temporary list

        // step 4: I will take the last amount elements from the frist original list and remove it by using the RemoveRange() function

        // step 5: I will insert the save elements at the start of the list using the InsertRange(0, tempList)

        // step 6: The list is good, it is now rotated the right amount to the right

        // (Step 2 ) to function get the last amount element numbers
        List<int> lastPart = data.GetRange(data.Count - amount, amount);

        //  (step 4) take elements from end
        data.RemoveRange(data.Count - amount, amount);

        // (step 5) insert them at the start
        data.InsertRange(0, lastPart);


    }
}
