using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	Vector3 startPosition;
	Transform startParent, targetObject;
	Vector3 mouseposition, targetposition;
	//float distance = 380.0f;
	float distance = 100.0f;

	#region IBeginDragHandler implementation

	void Start()
	{
		targetObject = gameObject.transform;
	}

	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
//		transform.position = Input.mousePosition;
		mouseposition = Input.mousePosition;
		targetposition = Camera.main.ScreenToWorldPoint (new Vector3 (mouseposition.x, mouseposition.y, distance));
		targetObject.position = targetposition;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		itemBeingDragged = null;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
		if(transform.parent == startParent){
			transform.position = startPosition;
		}
	}

	#endregion

	void Update()
	{

	}


}