using UnityEngine;
using System.Collections;

public class Perfomance : MonoBehaviour {
	
	//Sets the Maximum prime number the test can reach.
	private int MaxPrime = 50;
	//initiates the current prime number the test is at. 
	private int CurrentPrime;
	
	
	// Use this for initialization
	void Start () {
		//Calls the date time of the system at start of test.
		Debug.Log(System.DateTime.Now);           
		
		
	}
	
	// Update is called once per frame
	void Update () {
		PrimeNumber()  ;
	}
	
	//This is the calculations for the prime number
	public void PrimeNumber() {
		for(int i = 2; i < MaxPrime; i++){
			Debug.Log(i);
			if(CurrentPrime == MaxPrime) {
				Debug.Log(System.DateTime.Now);
			}
		}
	}
}
/*
	Hi Rob. Im lost here. 
	If you can point me in the right
	direction would be appreciated
*/