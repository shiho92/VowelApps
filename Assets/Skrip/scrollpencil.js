#pragma strict

public var speed : float = 10.0f;


function Update () 
{
	transform.Rotate(Vector3.forward, speed * Time.deltaTime);
}