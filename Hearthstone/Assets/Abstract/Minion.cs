abstract public class Minion : Entity {
	public int manaCost;
	public string cardSet, tribe, rarity, classCard;

	public Minion(){
		canAttack = 0;
		this.alive = true;
	}

	public override void play(Player p){

	}

	public override void endTurn(){
		canAttack = 1;
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
		if (this.attack != 0) {
			bool frozen = false;
			foreach (Entity e in abilityList) {
				if (e.name == "freeze") {
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
