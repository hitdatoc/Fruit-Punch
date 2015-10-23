using UnityEngine;
using System.Collections;

public class TouchInputScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Touch[] myTouches = Input.touches;
		for (int i = 0; i < Input.touchCount; i++) {
			Debug.Log(myTouches[i].position);
		}
	}
}
