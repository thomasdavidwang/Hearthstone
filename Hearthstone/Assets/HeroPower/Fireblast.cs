public class Fireblast : HeroPower {

	public Fireblast() : base(){
		name = "fireblast";
	}
	
	public void play(Entity other){
		other.takeDamage (1);
		base.play ();
	}
}
