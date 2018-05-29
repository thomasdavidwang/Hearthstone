public class Fireblast : HeroPower {

	public Fireblast() : base(){
		name = "fireblast";
	}

	public void play(Entity other, Player p){
		other.takeDamage (1);
		base.play (p);
	}
}
