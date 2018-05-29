public class ArcaneShot : Spell {
	public ArcaneShot(){
		manaCost = 1;
		name = "arcane shot";
		cardSet = "basic";
		classCard = "hunter";
	}

	public void play(Entity other, Player p){
		other.takeDamage (2);
		base.play (ref p);
	}
}
