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
		for(int i = 1; i < MaxPrime; i++){
			Debug.Log(i);                               // Call method which calculates if our number is a prime, our number being i
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

/*
    No worries, great start.  I will be careful how I check stuff in as I don't have a pre-Unity5 install anymore,
    I will just look at the code rather than via Unity for the time being.
 
    Ok, so the idea was to have a local variable which would indicate the number of prime numbers to return,
    so when I suggested 50, or 100, I meant returning the first 50 prime numbers, or 100 prime numbers, rather than
    the highest prime number being one being limited - if that makes sense.  But this is absolutely fine, we just change
    the plan a little, we can just type in a larger number later instead of 50 so that we get a significant number 
    of iterations.  Hope that makes sense.  

    You loop will work fine within PrimeNumber and we can use 50 for now which will get us 16 Prime numbers initially, but
    this will happen too quickly to be useful for testing performance I think, we can play with a larger number later when its
    working.  :)

    I see you have the code there to write the date/time when it completes also that great, we have a framework we can use.
    
    One thought, you mentioned about your familarity with OOP the other day etc... one thing you could build on is looking for duplication in the 
    code you write, if you spot some, that's a great place to do a little refactoring, so for example, in two separate methods you have a line
    of code which writes the date/time to the console, that could go in a method and you could then call the method instead.  That way
    if you want to change the output of the date/time when it hits the console, you only need to change it in one place.  There may
    be other reasons you may want to do this also, for example, changing it to write to a log file instead of to the console and so on.

    Example;

    private void OutputDateTime() {
        Debug.Log(System.DateTime.Now);
    }

    Now in both Start() and PrimeNumber() you could ditch the Debug.Log() lines in favour of the method call; OutputDateTime();


    So, the obvious bit that is missing is the bit which actually calculates whether a number is a prime or not - how's your math? ;)

    Where you have Debug.Log(i) within PrimeNumber(), that would be a good place to now place a call to another method which calculates the
    prime numbers and when it finds one, spits it out to the console.

    So, for reference, our 16 primes (based on MaxPrime = 50) would be;  
    2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 39, 41, 43, 47

    So, something to calculate primes then...

    ** NOTE: We will just spew "2" out as a Debug.Log() message rather than calculate it

    private void CalculatePrimeNumber(int numberToTest)
    {
        if (numberToTest == 2) Debug.Log("Prime: " + numberToTest);

        if (numberToTest > 2)
        {
            bool isPrime = true;

            for (int j = 2; j <= (int)Math.Floor(Math.Sqrt(numberToTest)); ++j)
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

    This isn't likely to be the best from a performance perspective of generating prime numbers, and the Debug.Log() stuff could do with improving too..
    ..but, it will suffice for now - feel free to make something better or give this a go :)
      
*/
