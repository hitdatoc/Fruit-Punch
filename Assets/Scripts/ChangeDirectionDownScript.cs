using UnityEngine;
using System.Collections;

public class ChangeDirectionDownScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		other.GetComponent<MovingObjectScript> ().ChangeDirection (new Vector3 (0, -1, 0));
	}
}
