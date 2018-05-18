using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Weapon : Card {
	public int manaCost, durability, maxDurability, attack;
	public string classCard, cardName, cardSet, rarity;
	public Ability ability;
}
