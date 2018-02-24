﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestOTRT
{

    public class Foe : AdventureCard
    {
        private int specialBP;
        private List<string> specialCards;

        //basic contstructor
        public Foe(string name, int bp, int bids, int specialBP, string[] specialCards)
            : base(name, bp, bids)
        {
            this.specialBP = specialBP;
            this.specialCards = new List<string>
            {
                "Defend the Queen's Honor"
            };
            if (specialCards != null)
            {
                foreach (string special in specialCards)
                {
                    this.specialCards.Add(special);
                }
            }
        }

        //Overridde function for creating a new foe without special powers, IE just a blank string
        public Foe(string name, int bp, int bids, int specialBP, string specialCard)
            : base(name, bp, bids)
        {
            this.specialBP = specialBP;
            this.specialCards = new List<string>
            {
                "Defend the Queen's Honor"
            };
            if (specialCards != null)
            {
             this.specialCards.Add(specialCard);   
            }
        }

        public override int getBP(string[] currState)
        {
            foreach (string card in this.specialCards)
            {
                if (currState.Contains(card)) return this.specialBP;
            }
            return this.bp;
        }

        public List<string> getSpecialCard()
        {
            List<string> possibleCards = null;

            if (specialCards != null)
            {
                foreach (string special in specialCards)
                {
                    possibleCards.Add(special);
                }
            }

            return possibleCards;
        }

    }
}