﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum PlayerType
{
    human,
    ai,
}
[System.Serializable]
public class Player
{
    public PlayerType type = PlayerType.ai;
    public int playerName;
    public SlotDef handSlotDef;
    public List<CardBartok> hand;
    public CardBartok AddCard(CardBartok eCB)
    {
        if (hand == null) hand = new List<CardBartok>();
        hand.Add(eCB);
        return (eCB);
    }
    public CardBartok RemoveCard(CardBartok cb)
    {
        if (hand == null || !hand.Contains(cb)) return null;
        hand.Remove(cb);
        return (cb);
    }
}

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
