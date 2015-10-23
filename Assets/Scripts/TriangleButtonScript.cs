using UnityEngine;
using System.Collections;

public class TriangleButtonScript : MonoBehaviour {

	void OnMouseDown(){
		GameObject.FindGameObjectWithTag ("GameHandler").GetComponent<ShapeAmplifierTracker> ().SetAmplifier ("triangle");
	}
}
