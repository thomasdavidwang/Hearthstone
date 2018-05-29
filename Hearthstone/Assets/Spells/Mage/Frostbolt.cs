public class Frostbolt : Spell {
	public Frostbolt(){
		manaCost = 2;
		name = "frostbolt";
		cardSet = "basic";
		classCard = "mage";
		ability = new Freeze ();
	}

	public override void play(Entity other){
		other.takeDamage (3);
		other.abilityList.Add (new Freeze());
	}
}
