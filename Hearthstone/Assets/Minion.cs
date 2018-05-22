abstract public class Minion : Entity {
	public int manaCost;
	public string cardSet, tribe, rarity, classCard;
	//public Ability ability;

	public Minion(){
		this.alive = true;
		play ();
	}

	/**
	public void spawn(){
		if (ability.abilityName = "Battlecry") {

		}
	}
	public void destroy(){
		if (ability.abilityName = "Deathrattle") {

		}
	}
	*/

	public override void play(){

	}

	public override void takeDamage(int damage){
		this.health = this.health - damage;
		if (this.health < 1) {
			this.alive = false;
		}
	}

	public override void hit(Entity other){
		other.takeDamage (this.attack);
		this.takeDamage (other.attack);
	}
}
