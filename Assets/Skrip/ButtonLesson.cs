using UnityEngine;
using System.Collections;

public class ButtonLesson : MonoBehaviour {
	
	public void Test()
	{
		Debug.LogError("Button was pressed");
		Application.LoadLevel ("page3");
	}
	
}