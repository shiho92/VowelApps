using UnityEngine;
using System.Collections;

public class Buttonnew : MonoBehaviour {
	
	public GameObject ButtonE;
	public GameObject ButtonF;
	public GameObject ButtonG;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnMouseDown()
	{
		ButtonE.SetActive (true);
		ButtonF.SetActive (true);
		ButtonG.SetActive (true);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}