using UnityEngine;
using System.Collections;

public class DragObjectScript : MonoBehaviour {

	void OnMouseDrag(){
		if(gameObject.GetComponent<ObjectAttributesScript> ().IsAlive () == false){
			Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			pos.z = 0;
			gameObject.transform.position = pos;
		}
	}
	
}
