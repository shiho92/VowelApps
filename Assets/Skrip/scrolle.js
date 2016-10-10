#pragma strict

public var speed : float = 100.0f;


function Update () 
{
    transform.position += Vector3.down * Time.deltaTime;
}
