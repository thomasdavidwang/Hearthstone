public class ArcaneIntellect : Spell {
	public ArcaneIntellect(){
		manaCost = 3;
		name = "arcane intellect";
		cardSet = "basic";
		classCard = "mage";
	}

	public override void play(ref Player p){
		p.drawCard ();
		p.drawCard ();
		base.play (ref p);
	}
}
