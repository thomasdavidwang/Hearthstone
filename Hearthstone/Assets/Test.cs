using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Hero mage, hunter;
		mage = new Mage ();
		hunter = new Hunter ();

		ArrayList mageDeck, hunterDeck;
		mageDeck = returnMageDeck();
		hunterDeck = returnHunterDeck();

		Board board = new Board (mageDeck, hunterDeck, mage, hunter);
	}

	public static ArrayList returnMageDeck(){
		ArrayList mageDeck = new ArrayList ();
		mageDeck.Add (new ArcaneIntellect ());
		mageDeck.Add (new ArcaneIntellect ());
		mageDeck.Add (new Frostbolt ());
		mageDeck.Add (new Frostbolt ());
		return mageDeck;
	}

	public static ArrayList returnHunterDeck(){
		ArrayList hunterDeck = new ArrayList ();

		return hunterDeck;
	}

	public static void yell(){
		Debug.Log ("Yell");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
