using UnityEngine;
using System.Collections;

public class MovingObjectScript : MonoBehaviour {

	public int speed;
	public Vector3 direction;

	void Awake(){
		speed = 2;
		direction = new Vector3 (1, 0, 0);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (direction * speed * Time.deltaTime);
	}

	public void StopMoving(){
		this.direction = new Vector3 (0, 0, 0);
	}

	public void ChangeDirection(Vector3 direction){
		if (gameObject.GetComponent<ObjectAttributesScript> ().IsAlive ()) {
			this.direction = direction;
		}
	}
}
