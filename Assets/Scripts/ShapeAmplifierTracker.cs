using UnityEngine;
using System.Collections;

public class ShapeAmplifierTracker : MonoBehaviour {

	public bool circleAmplifier;
	public bool squareAmplifier;
	public bool cylinderAmplifier;
	public bool triangleAmplifier;

	void Awake(){
		this.ResetAmplifiers ();
	}

	public bool GetCircleAmplifier(){
		return this.circleAmplifier;
	}

	public bool GetSquareAmplifier(){
		return this.squareAmplifier;
	}

	public bool GetCylinderAmplifier(){
		return this.cylinderAmplifier;
	}

	public bool GetTriangleAmplifier(){
		return this.triangleAmplifier;
	}

	public void SetAmplifier(string amplifierType){
		this.ResetAmplifiers ();

		if (amplifierType.Equals ("circle")) {
			this.circleAmplifier = true;
		}

		if(amplifierType.Equals ("square")){
			this.squareAmplifier = true;
		}

		if (amplifierType.Equals ("cylinder")) {
			this.cylinderAmplifier = true;
		}

		if (amplifierType.Equals ("triangle")) {
			this.triangleAmplifier = true;
		}
	}

	void ResetAmplifiers(){
		this.circleAmplifier = false;
		this.squareAmplifier = false;
		this.cylinderAmplifier = false;
		this.triangleAmplifier = false;
	}
}
