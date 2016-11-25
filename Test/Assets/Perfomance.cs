using UnityEngine;
					// TODO: Not in use, added automatically by the template MonoDevelop uses when you create a Script within Unity, could be removed

public class Perfomance : MonoBehaviour {
	
	//Sets the Maximum prime number the test can reach.
	private int MaxPrime = 50;
	//initiates the current prime number the test is at. 
	//private int CurrentPrime;					// TODO: This is now redundant (see below)
	
	
	
	
	// Use this for initialization
	void Start () {
		//Calls the date time of the system at start of test.
		//Debug.Log(DateTime());           
		DateTime();		// TODO: Your DateTime() method looks good, call that here instead, e.g. comment this line out completely and add DateTime(); below it
		PrimeNumber();
		
	}
	
	//This is the calculations for the prime number
	public void PrimeNumber() {
		for(int i = 1; i <= MaxPrime; i++){
			CalculatePrimeNumber(i);   // Call method which calculates if our number is a prime, our number being is
		}
		DateTime();
		// TODO: This would be a good spot to call your DateTime() method again as it will display the date/time once the iterations have completed
	}
	
	public void CalculatePrimeNumber(int numberToTest)
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