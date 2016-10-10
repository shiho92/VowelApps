using UnityEngine;
using System.Collections;

public class Start_Level : MonoBehaviour {
	
	public void Test()
	{
		Debug.LogError("Button was pressed");
		Application.LoadLevel ("page2");
	}
	
}
