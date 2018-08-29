using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButton : MonoBehaviour {

	public List<bool> actionBools;

	bool info;
	bool rooms;
	bool spells;
	bool placements;
	bool creatures;

	void Start () {
		actionBools.Add(info);
		actionBools.Add(rooms);
		actionBools.Add(spells);
		actionBools.Add(placements);
		actionBools.Add(creatures);
	}
}