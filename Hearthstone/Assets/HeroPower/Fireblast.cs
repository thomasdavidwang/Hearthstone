public class Fireblast : HeroPower {

	public Fireblast(Board b) : base(){
		board = b;
		name = "fireblast"
	}
	
	public void play(Entity other){
		other.takeDamage (1);
		base.play ();
	}
}
