using UnityEngine;
using System.Collections;

public class CircleButtonScript : MonoBehaviour {

	void OnMouseDown(){
		GameObject.FindGameObjectWithTag ("GameHandler").GetComponent<ShapeAmplifierTracker> ().SetAmplifier ("circle");
	}
}
