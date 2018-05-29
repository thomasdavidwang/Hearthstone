using System;
using System.Collections;

abstract public class Entity : Card {
	public int health, attack, maxHealth, canAttack;
	public bool alive;
	public ArrayList abilityList;
	public Player player;

	public Entity(){

	}

	public virtual void endTurn (){
		foreach(String a in abilityList){
			if (a == "frozen") {
				abilityList.Remove (a);
			}
		}
		canAttack = 1;
	}

	abstract public void startTurn ();
	abstract public void takeDamage (int damage);
	abstract public void hit (ref Entity other);
	abstract public void die ();
}
