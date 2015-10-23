using UnityEngine;
using System.Collections;

public class SquareHPScript : MonoBehaviour {

	public int HP;

	void Awake(){
		//Set Initial HP
		this.HP = 3;

		//Set Object Attribute to 'Square'
		gameObject.GetComponent<ObjectAttributesScript> ().SetAttribute ("square");
	}

	void OnMouseDown(){
		if (GameObject.FindGameObjectWithTag ("GameHandler").GetComponent<ShapeAmplifierTracker> ().GetSquareAmplifier ()) {
			this.HP = this.HP - 1;
		}
	}

	public bool IsShapeAlive(){
		if (this.HP <= 0) {
			return false;
		} 
		return true;
	}
}
