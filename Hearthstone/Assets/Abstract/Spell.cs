abstract public class Spell : Card {
	public int manaCost;
	public string name, cardSet, classCard;

	public override void play(ref Player p){
		p.useMana (manaCost);
	}
}
