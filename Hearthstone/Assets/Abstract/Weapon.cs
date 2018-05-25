abstract public class Weapon : Card {
	public int manaCost, durability, maxDurability, attack;
	public string classCard, cardSet, rarity;
	public bool alive;
	//public Ability ability;

	public abstract void weaponBreak();
}
