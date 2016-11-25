using UnityEngine;

public class Perfomance : MonoBehaviour {
	
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