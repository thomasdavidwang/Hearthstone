using System;
using System.Collections;

abstract public class Hero : Entity{
	public int armor;
	public Weapon weapon;
	public string className;
	public HeroPower heroPower;

	public Hero(){
		canAttack = 1;
		this.alive = true;
		abilityList = new ArrayList ();
	}

	public override void play(ref Player p){

	}

	public override void startTurn(){
		
	}

	public void breakWeapon(){
		weapon = null;
	}

	public override void die(){
		Test.yell (className);
	}

	public abstract void addPlayer (ref Player p);

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
			if (weapon != null) {
				bool frozen = false;
				foreach (string e in abilityList) {
					if (e == "frozen") {
						frozen = true;
					}
				}
				if (!frozen) {
					other.takeDamage (weapon.attack);
					weapon.durability = weapon.durability - 1;
					takeDamage (other.attack);
				}
			}
			if (this.health < 0) {
				this.alive = false;
			}
			canAttack--;
		}
	}

	public override void takeDamage(int damage){
		if (damage > armor) {
			armor = 0;
			health = health - damage + armor;
		} else {
			armor = armor - damage;
		}
		if (health < 1) {
			die ();
		}
	}

}
