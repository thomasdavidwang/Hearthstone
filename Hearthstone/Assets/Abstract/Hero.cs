using System;
using System.Collections;

abstract public class Hero : Entity{
	public int armor;
	public Weapon weapon;
	public string className;
	public HeroPower heroPower;
	public Player player;

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

	}

	public abstract void addPlayer (ref Player p);

	public override void hit(ref Entity other){
		if (weapon != null) {
			bool frozen = false;
			foreach (Entity e in abilityList) {
				if (e.name == "freeze") {
					frozen = true;
				}
			}
			if(!frozen){
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

	public override void takeDamage(int damage){
		if (damage > armor) {
			armor = 0;
			health = health - damage + armor;
		} else {
			armor = armor - damage;
		}
	}

}
