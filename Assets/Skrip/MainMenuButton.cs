using UnityEngine;
using System.Collections;

public class MainMenuButton : MonoBehaviour 
{
	
	public void Test()
	{
		Debug.LogError("Button was pressed");
		Application.LoadLevel ("page2");
	}
	
}