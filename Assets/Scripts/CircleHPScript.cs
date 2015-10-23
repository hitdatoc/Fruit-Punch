using UnityEngine;
using System.Collections;

public class CircleHPScript : MonoBehaviour {

	public int HP;
	
	void Awake(){
		//Set Initial HP
		this.HP = 3;
		
		//Set Object Attribute to 'Square'
		gameObject.GetComponent<ObjectAttributesScript> ().SetAttribute ("circle");
	}
	
	void OnMouseDown(){
		if (GameObject.FindGameObjectWithTag ("GameHandler").GetComponent<ShapeAmplifierTracker> ().GetCircleAmplifier()) {
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
