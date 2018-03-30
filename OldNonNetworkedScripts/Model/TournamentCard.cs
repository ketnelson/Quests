﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TournamentCard : StoryCard {

    public int BonusShields;

    public override void Apply()
    {
         GameObject.FindGameObjectWithTag("ActiveArea").GetComponent<Gameplay>().PromptTournament();
    }
	
}
