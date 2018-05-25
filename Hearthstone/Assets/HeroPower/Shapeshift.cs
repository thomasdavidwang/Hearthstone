public class Shapeshift : HeroPower {
	Hero hero;

	public Shapeshift(Hero h): base(){
		hero = h;
		name = "shapeshift";
	}

	public override void play(){
		hero.attack = hero.attack + 1;
		hero.armor = hero.armor + 1;
		base.play ();
	}

	public override void endTurn(){
		hero.attack = hero.attack - 1;
		base.endTurn ();
	}
}
