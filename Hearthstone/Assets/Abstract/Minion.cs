using System;
using System.Collections;

abstract public class Minion : Entity {
	public string cardSet, tribe, rarity, classCard;

	public Minion(){
	}

	public override void play(ref Player p){
		canAttack = 0;
		this.alive = true;
		abilityList = new ArrayList ();
		p.useMana (manaCost);
		player = p;
	}

	public override void startTurn(){
		
	}

	public override void takeDamage(int damage){
		this.health = this.health - damage;
		if (this.health < 1) {
			this.alive = false;
		}
	}

	public override void hit(ref Entity other){
		ArrayList temp = new ArrayList ();
		foreach (Minion a in player.oppBoard) {
			foreach (string s in a.abilityList) {
				if (s == "taunt") {
					temp.Add (a);
				}
			}
		}
		if (temp.Contains (other)) {
			if (this.attack != 0) {
				bool frozen = false;
				foreach (string e in abilityList) {
					if (e == "frozen") {
						frozen = true;
					}
				}
				if (!frozen) {
					other.takeDamage (this.attack);
					this.takeDamage (other.attack);
				}
			}
			canAttack--;
		}
	}
}
