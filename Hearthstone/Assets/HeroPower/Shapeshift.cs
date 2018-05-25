public class Shapeshift : HeroPower {

	public Shapeshift(Player p): base(){
		player = p;
		name = "shapeshift";
	}

	public override void play(){
		player.hero.attack = player.hero.attack + 1;
		player.hero.armor = player.hero.armor + 1;
		base.play ();
	}

	public override void endTurn(){
		player.hero.attack = player.hero.attack - 1;
		base.endTurn ();
	}
}
