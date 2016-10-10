#pragma strict

public var speed : float = 10.0f;


function Update () 
{
    transform.position += Vector3.up * Time.deltaTime;
}

