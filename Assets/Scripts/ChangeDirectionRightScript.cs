using UnityEngine;
using System.Collections;

public class ChangeDirectionRightScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		other.GetComponent<MovingObjectScript> ().ChangeDirection (new Vector3 (1, 0, 0));
	}
}
