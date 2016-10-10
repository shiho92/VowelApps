using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Dropzone : MonoBehaviour,IDropHandler, IPointerEnterHandler, IPointerExitHandler{

	public Draggable.Slot typeOfItem = Draggable.Slot.APPLE;
	
	public void OnPointerEnter(PointerEventData eventData)
	{
		
		Debug.Log ("OnPointerEnter");
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		Debug.Log ("OnPointerExit");
		
	}
	public void OnDrop(PointerEventData eventData){
		Debug.Log (eventData.pointerDrag.name + "was dropped on" + gameObject.name);
		
		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d != null) 
		{
			if (typeOfItem == d.typeOfItem)
			{
				d.parentToReturnTo = this.transform;
			}
			
		}
		
	}
}
