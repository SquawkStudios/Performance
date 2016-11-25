using UnityEngine;
using System.Collections;						// TODO: Not in use, added automatically by the template MonoDevelop uses when you create a Script within Unity, could be removed

public class Perfomance : MonoBehaviour {
	
	//Sets the Maximum prime number the test can reach.
	private int MaxPrime = 50;
	//initiates the current prime number the test is at. 
	private int CurrentPrime;					// TODO: This is now redundant (see below)
	
	
	
	
	// Use this for initialization
	void Start () {
		//Calls the date time of the system at start of test.
		//Debug.Log(DateTime());           
		Debug.Log (System.DateTime.Now);		// TODO: Your DateTime() method looks good, call that here instead, e.g. comment this line out completely and add DateTime(); below it
		
		
	}
	
	// Update is called once per frame			// TODO: Rendundant method as we aren't really using it for this mini project
	void Update () {
		
	}
	
	//This is the calculations for the prime number
	public void PrimeNumber() {
		for(int i = 1; i < MaxPrime; i++){
			CalculatePrimeNumber(i);   // Call method which calculates if our number is a prime, our number being i
			if(CurrentPrime == MaxPrime) {		// TODO: This is currently redundant as we are restricting the iterations via MaxPrime
				
				Debug.Log (System.DateTime.Now);
			}
		}
		
		// TODO: This would be a good spot to call your DateTime() method again as it will display the date/time once the iterations have completed
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