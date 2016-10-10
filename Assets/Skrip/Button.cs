using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public GameObject ButtonA;
	public GameObject ButtonB;
	public GameObject ButtonC;
	// Use this for initialization
	void Start () {
	
	}

	void OnMouseDown()
	{
		ButtonA.SetActive (true);
		ButtonB.SetActive (true);
		ButtonC.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
