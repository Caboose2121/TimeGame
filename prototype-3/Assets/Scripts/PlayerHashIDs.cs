using UnityEngine;
using System.Collections;

public class PlayerHashIDs : MonoBehaviour {

	public int speedFloat;
	public int jumpBool;
	
	void Awake ()
	{
		speedFloat = Animator.StringToHash ("Speed");
		jumpBool = Animator.StringToHash ("JumpBool");
	}
}
