using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Board board = new Board (null, null, "Rexxar", "Malfurion Stormrage");
		board.player1.hero.heroPower.play ();
		Debug.Log (board.player2.hero.health);
	}

	public static void yell(){
		Debug.Log ("Yell");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
