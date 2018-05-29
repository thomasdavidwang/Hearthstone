using System;
using System.Collections;

abstract public class Entity : Card {
	public int health, attack, maxHealth;
	public bool alive;
	public ArrayList abilityList;

	public Entity(){

	}

	abstract public void endTurn ();
	abstract public void startTurn ();
	abstract public void takeDamage (int damage);
	abstract public void hit (Entity other);
	abstract public void die ();
}
