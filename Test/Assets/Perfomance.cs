using UnityEngine;
using System.Collections;

public class Perfomance : MonoBehaviour {
	
	private int MaxPrime = 50;
	
	private int CurrentPrime;
	
	
	// Use this for initialization
	void Start () {
		Debug.Log(System.DateTime.Now);           
		
		
	}
	
	// Update is called once per frame
	void Update () {
		PrimeNumber()  ;
	}
	
	public void PrimeNumber() {
		for(int i = 2; i < MaxPrime; i++){
			Debug.Log(i);
			if(CurrentPrime == MaxPrime) {
				Debug.Log(System.DateTime.Now);
			}
		}
	}
}
