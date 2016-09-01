using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour 
{
	// Use Timer whenever an event needs triggered at the end of a certain amount of time.

	// All variables
	#region Variables

	// The amount of time the timer should be running to.
	private float totalTime;
	public float TotalTime
	{
		get { return totalTime; }
		set { TotalTime == totalTime; }
	}

	// The current time the timer is at.
	private float currTime;
	public float CurrTime
	{
		get { return currTime; }
		set { CurrTime == currTime; }
	}
		
	// If needed this is the amount of time to add or subtract from the currTime or totalTime as needed.
	//
	private float changeTime;
	public float ChangeTime
	{
		get { return changeTime; }
		set { ChangeTime == changeTime; }
	}

	#endregion

	#region Methods

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	#endregion
}
