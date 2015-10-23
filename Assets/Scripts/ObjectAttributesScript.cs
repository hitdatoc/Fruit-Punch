using UnityEngine;
using System.Collections;

public class ObjectAttributesScript : MonoBehaviour {

	public bool circleAttribute;
	public bool squareAttribute;
	public bool cylinderAttribute;
	public bool triangleAttribute;
	public bool isAlive;

	void Awake(){
		this.isAlive = true;
	}

	public bool IsAlive(){
		return this.isAlive;
	}

	public bool IsACircle(){
		return this.circleAttribute;
	}

	public bool IsASquare(){
		return this.squareAttribute;
	}

	public bool IsACylinder(){
		return this.cylinderAttribute;
	}

	public bool IsATriangle(){
		return this.triangleAttribute;
	}

	public void SetAttribute(string attributeType){
		if(attributeType.Equals("circle")){
			this.circleAttribute = true;
		}

		if(attributeType.Equals("square")){
			this.squareAttribute = true;
		}

		if (attributeType.Equals ("cylinder")) {
			this.cylinderAttribute = true;
		}

		if(attributeType.Equals("triangle")){
			this.triangleAttribute = true;
		}
	}

	void Update(){
		if (this.isAlive) {
			this.CheckDamage ();
		}
	}

	void CheckDamage(){
		this.isAlive = false;

		if(this.squareAttribute && gameObject.GetComponent<SquareHPScript>().IsShapeAlive()){
			this.isAlive = true;
		}

		if (this.circleAttribute && gameObject.GetComponent<CircleHPScript> ().IsShapeAlive ()) {
			this.isAlive = true;
		}

		if (this.cylinderAttribute && gameObject.GetComponent<CylinderHPScript> ().IsShapeAlive ()) {
			this.isAlive = true;
		}

		if (this.triangleAttribute && gameObject.GetComponent<TriangleHPScipt> ().IsShapeAlive ()) {
			this.isAlive = true;
		}

		if (this.isAlive == false) {
			gameObject.GetComponent<MovingObjectScript>().StopMoving();
			//Destroy (gameObject);
		}
	}
}
