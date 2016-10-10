using UnityEngine;
using System.Collections;

public class RotateSample : MonoBehaviour
{	
	void Start(){
		iTween.RotateBy(gameObject, iTween.Hash("y", .50, "easeType", "easeInOutBack", "loopType", "pingPong", "delay", .4));
	}
}

