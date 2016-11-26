using UnityEngine;

public class Perfomance : MonoBehaviour {

    // TOOD:    How about taking the Debug.Log lines out of the CalculatePrimeNumber() method and instead of having it 
    //          return void, have it return the int it has calculated if it is a prime number
    //          Could return PrimeNumber() method to DisplayPrimeNumbers() and maybe place the outputting calls in there, 
    //          including the initial DateTime() call
    //      
    //          Something like;
    //          private void DisplayPrimeNumbers()
    //          // Display initial DateTime()
    //          // Start iteration
    //          // populate local variable with return value from CalculatePrimeNumber()
    //          // Display local variable to console
    //          // Display final DateTime()
    //
    //          That would keep things fairly tidy.
    //          Then, potentially after that you could copy and paste the method, rename one to DisplayPrimeNumbersVariable()
    //          and one to DisplayPrimeNumbersDirectMethod()
    //          in the DisplayPrimeNumbersDirectMethod() method, remove the local variable code and simply Debug.Log(CalculatePrimeNumber(i));
    //
    //          That would give you both methods of the testing we were aiming for, all in fairly tidy methods.
    //          Suggestions only :)


    //Sets the Maximum prime number the test can reach.
    private int MaxPrime = 500000;
	
	// Use this for initialization
	void Start () {
		//Calls the date time of the system at start of test.
		//Debug.Log(DateTime());           
		DateTime();	
		PrimeNumber();
		
	}
	
	//This is the calculations for the prime number
	public void PrimeNumber() {
		for(int i = 1; i <= MaxPrime; i++){
			// Call method which calculates if our number is a prime, our number being is
			CalculatePrimeNumber(i);
		}
		DateTime();
	}
	
	private void CalculatePrimeNumber(int numberToTest)
	{
		if (numberToTest == 2) Debug.Log("Prime: " + numberToTest);
		
		if (numberToTest > 2)
		{
			bool isPrime = true;
			
			for (int j = 2; j <= (int)Mathf.Floor(Mathf.Sqrt(numberToTest)); ++j)
			{
				if (numberToTest % j == 0)
				{
					isPrime = false;
					break;
				}
			}
			
			if (isPrime == true)
			{
				Debug.Log("Prime: " + numberToTest);
			}
		}
	}
	
	public void DateTime(){
		Debug.Log (System.DateTime.Now);
	}
}