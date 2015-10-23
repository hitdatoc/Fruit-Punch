using UnityEngine;
using System.Collections;

public class SquareButtonScript : MonoBehaviour {

	void OnMouseDown(){
		GameObject.FindGameObjectWithTag ("GameHandler").GetComponent<ShapeAmplifierTracker> ().SetAmplifier ("square");
	}
}
