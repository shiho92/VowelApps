using UnityEngine;
using System.Collections;

public class loadlevel : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	public void changeToscene (string LoadLevel)
	{
		Application.LoadLevel (LoadLevel);

	
	}
}
