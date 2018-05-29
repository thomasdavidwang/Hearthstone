public class Frostbolt : Spell {
	public Frostbolt(){
		manaCost = 2;
		name = "frostbolt";
		cardSet = "basic";
		classCard = "mage";
	}

	public void play(Entity other, Player p){
		other.takeDamage (3);
		other.abilityList.Add (new Freeze());
		base.play (p);
	}
}
