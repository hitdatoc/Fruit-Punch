using UnityEngine;
using System.Collections;

public class CylinderHPScript : MonoBehaviour {

	public int HP;
	
	void Awake(){
		//Set Initial HP
		this.HP = 5;
		
		//Set Object Attribute to 'Square'
		gameObject.GetComponent<ObjectAttributesScript> ().SetAttribute ("cylinder");
	}
	
	void OnMouseDown(){
		if (GameObject.FindGameObjectWithTag ("GameHandler").GetComponent<ShapeAmplifierTracker> ().GetCylinderAmplifier()) {
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
