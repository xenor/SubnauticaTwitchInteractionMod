﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchInteraction.Player_Events
{
    //Add functions to the EventLookup.cs class
    class DangerZone //This contains events that I do not wish to happen frequently so will be behind paywalls or high channel point walls
    {
        public static void KillPlayer()
        {
            Player.main.liveMixin.TakeDamage(666);
        }

        public static void EnableGun()
        {
            StoryGoalCustomEventHandler.main.gunDisabled = false;

        }
    }
}
