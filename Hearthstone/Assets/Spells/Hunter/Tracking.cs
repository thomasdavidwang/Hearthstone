using System.Collections;
using System;

public class Tracking : Spell {
	//Randomly picks two of three
	public Tracking(){
		manaCost = 1;
		name = "tracking";
		cardSet = "basic";
		classCard = "hunter";
	}

	public void play(Player p){
		Random rd = new Random();
		int r = rd.Next(p.deck.Count);
		ArrayList temp = new ArrayList ();
		temp.Add (p.deck[r]);
		p.deck.RemoveAt (r);
		r = rd.Next(p.deck.Count);
		temp.Add (p.deck[r]);
		p.deck.RemoveAt(r);
		r = rd.Next(p.deck.Count);
		temp.Add (p.deck[r]);
		p.deck.RemoveAt(r);

		r = rd.Next(3);
		for (int i = 0; i < 3; i++) {
			if (i != r) {
				p.hand.Add (temp [i]);
			}
		}
		base.play (ref p);
	}
}
