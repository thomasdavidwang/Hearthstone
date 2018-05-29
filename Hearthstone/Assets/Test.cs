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

		Board board = new Board (ref mageDeck, ref hunterDeck, ref mage, ref hunter);

		board.nextTurn ();

		foreach (Card c in board.curr.hand) {
			Debug.Log (c.name);
		}
		/**if()
		board.play (0);
		board.play (board.curr.opponent, 0);
		*/
	}

	public static ArrayList returnMageDeck(){
		ArrayList mageDeck = new ArrayList ();
		mageDeck.Add (new ArcaneIntellect ());
		mageDeck.Add (new ArcaneIntellect ());
		mageDeck.Add (new Frostbolt ());
		mageDeck.Add (new Frostbolt ());
		mageDeck.Add (new Fireball ());
		mageDeck.Add (new Fireball ());
		mageDeck.Add (new Flamestrike ());
		mageDeck.Add (new Flamestrike ());
		mageDeck.Add (new Polymorph ());
		mageDeck.Add (new Polymorph ());
		mageDeck.Add (new WaterElemental ());
		mageDeck.Add (new WaterElemental ());
		mageDeck.Add (new AcidicSwampOoze ());
		mageDeck.Add (new AcidicSwampOoze ());
		mageDeck.Add (new RiverCrocolisk ());
		mageDeck.Add (new RiverCrocolisk ());
		mageDeck.Add (new ShatteredSunCleric ());
		mageDeck.Add (new ShatteredSunCleric ());
		mageDeck.Add (new RazorfenHunter ());
		mageDeck.Add (new RazorfenHunter ());
		mageDeck.Add (new ChillwindYeti ());
		mageDeck.Add (new ChillwindYeti ());
		mageDeck.Add (new FrostwolfWarlord ());
		mageDeck.Add (new FrostwolfWarlord ());
		mageDeck.Add (new BoulderfistOgre ());
		mageDeck.Add (new BoulderfistOgre ());
		mageDeck.Add (new StormwindChampion ());
		mageDeck.Add (new StormwindChampion ());
		mageDeck.Add (new GnomishInventor ());
		mageDeck.Add (new GnomishInventor ());
		return mageDeck;
	}

	public static ArrayList returnHunterDeck(){
		ArrayList hunterDeck = new ArrayList ();
		hunterDeck.Add (new ArcaneShot ());
		hunterDeck.Add (new ArcaneShot ());
		hunterDeck.Add (new HuntersMark ());
		hunterDeck.Add (new HuntersMark ());
		hunterDeck.Add (new KillCommand ());
		hunterDeck.Add (new KillCommand ());
		hunterDeck.Add (new Multishot ());
		hunterDeck.Add (new Multishot ());
		hunterDeck.Add (new Tracking ());
		hunterDeck.Add (new Tracking ());
		hunterDeck.Add (new Houndmaster ());
		hunterDeck.Add (new Houndmaster ());
		hunterDeck.Add (new AcidicSwampOoze ());
		hunterDeck.Add (new AcidicSwampOoze ());
		hunterDeck.Add (new RiverCrocolisk ());
		hunterDeck.Add (new RiverCrocolisk ());
		hunterDeck.Add (new ShatteredSunCleric ());
		hunterDeck.Add (new ShatteredSunCleric ());
		hunterDeck.Add (new RazorfenHunter ());
		hunterDeck.Add (new RazorfenHunter ());
		hunterDeck.Add (new ChillwindYeti ());
		hunterDeck.Add (new ChillwindYeti ());
		hunterDeck.Add (new FrostwolfWarlord ());
		hunterDeck.Add (new FrostwolfWarlord ());
		hunterDeck.Add (new BoulderfistOgre ());
		hunterDeck.Add (new BoulderfistOgre ());
		hunterDeck.Add (new StormwindChampion ());
		hunterDeck.Add (new StormwindChampion ());
		hunterDeck.Add (new BloodfenRaptor ());
		hunterDeck.Add (new BloodfenRaptor ());
		return hunterDeck;
	}

	public static void yell(string s){
		Debug.Log (s);
	}

	public static void yell(int s){
		Debug.Log (s);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
