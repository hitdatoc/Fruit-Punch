using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerLivesScript : MonoBehaviour {

	public int playerLives;

	void Awake(){
		this.ResetLives ();
	}

	public void LoseLife(){
		this.playerLives = this.playerLives - 1;
		this.UpdateLivesDisplay ();
	}

	public void ResetLives(){
		this.playerLives = 10;
		this.UpdateLivesDisplay ();
	}

	public void UpdateLivesDisplay(){
		GameObject.FindGameObjectWithTag ("LivesDisplay").GetComponent<Text> ().text = this.playerLives.ToString();
	}
}
