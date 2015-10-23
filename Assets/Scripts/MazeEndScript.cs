using UnityEngine;
using System.Collections;

public class MazeEndScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Destroy (other.gameObject);
		GameObject.FindGameObjectWithTag ("GameHandler").GetComponent<PlayerLivesScript> ().LoseLife ();
	}
}
