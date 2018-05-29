public class Fireblast : HeroPower {

	public Fireblast() : base(){
		name = "fireblast";
	}

	public override void play(ref Entity other,ref Player p){
		other.takeDamage (1);
		base.play (ref p);
	}
}
