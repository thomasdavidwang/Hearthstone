public class Fireball : Spell {
	public Fireball(){
		manaCost = 4;
		name = "fireball";
		cardSet = "basic";
		classCard = "mage";
	}

	public void play(Entity other, Player p){
		other.takeDamage (6);
		base.play (ref p);
	}
}
