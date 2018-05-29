abstract public class Minion : Entity {
	public int manaCost;
	public string cardSet, tribe, rarity, classCard;

	public Minion(){
		this.alive = true;
		play ();
	}

	public override void play(){

	}

	public override void endTurn(){

	}

	public override void startTurn(){

	}

	public override void takeDamage(int damage){
		this.health = this.health - damage;
		if (this.health < 1) {
			this.alive = false;
		}
	}

	public override void hit(Entity other){
		if (this.attack != 0) {
			bool frozen = false;
			foreach (Entity e in abilityList) {
				if (e.name = "freeze") {
					frozen = true;
				}
			}
			if (!frozen) {
				other.takeDamage (this.attack);
				this.takeDamage (other.attack);
			}
		}
	}
}
