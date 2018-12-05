using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundResult : MonoBehaviour {
    private Text txt;

    void Awake()
    {
        txt = GetComponent<Text>();
        txt.text = "";
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Bartok.S.phase != TurnPhase.gameover){
            txt.text = "";
            return;
        }
        Player cP = Bartok.CURRENT_PLAYER;
        if(cP == null || cP.type == PlayerType.human)
        {
            txt.text = "";
        }
        else
        {
            txt.text = "Player " + (cP.playerNum) + " won";
        }
	}
}
