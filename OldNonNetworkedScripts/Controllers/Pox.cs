﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//All other players lose one shield(if possible), drawer of this card is exempt
public class Pox : GameElement
{
    void Start()
    {
        
        play();
    }

    public void play()
    {
        //Creates a new list of players to be filled 
        List<PlayerModel> players = new List<PlayerModel>();

        PlayerModel p = game.players[game.currPlayer].GetComponent<PlayerModel>();

        //Loops through each game object and adds them to the list of players
        foreach (GameObject player in this.game.players)
        {
            players.Add(player.GetComponent<PlayerModel>());
        }

        //Get a reference to the current player, remove two shields from them
        for (int i = 0; i < players.Count; ++i)
        {
            //if the player is the one who drew the card then he doesnt lose a sheild
            if (players[i] == p)
            {
                continue;
            }
            //all other players lose one shield
            else
            {
                players[i].removeShields(1);
            }
        }

        Debug.Log("[Pox.cs:play] Pox complete -> All players except player " + (game.currPlayer + 1) + "lost 1 shield");
    }
}
