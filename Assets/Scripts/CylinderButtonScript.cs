using UnityEngine;
using System.Collections;

public class CylinderButtonScript : MonoBehaviour {

	void OnMouseDown(){
		GameObject.FindGameObjectWithTag ("GameHandler").GetComponent<ShapeAmplifierTracker> ().SetAmplifier ("cylinder");
	}
}
