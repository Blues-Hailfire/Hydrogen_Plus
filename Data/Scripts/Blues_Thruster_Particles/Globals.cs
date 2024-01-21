﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRage.Game;

namespace Blues_Thruster_Particles
{
    public static class Globals
    {



		public static Dictionary<string, string> ParticleEffectsList = new Dictionary<string, string>{
			{"Vanilla",     ""},
			{"Maneuvering", "ManuveringThurster"},
			{"AmberBurst",  "HydrogenFlames"},
			{"Blueshift",   "BlueShiftFlame"},
			{"Rainbow",		"RainbowFlames"},
			{"Eridanus",	"EridanusFlame"},
			{"Thunder Dome","ThunderDomeFlame"},
			//{"Blood Moon",    	"BloodMoonFlame"},
			{"Lift Off",	"LiftOffFlame"},
			{"OPC_1",    	"OPC_1_Flame"},
			{"OPC_2",     	"OPC_2_Flame"},
			{"OPC_3",     	"OPC_3_Flame"},
		};

		public static readonly MyDefinitionId HydrogenId = MyDefinitionId.Parse("MyObjectBuilder_GasProperties/Hydrogen");





	}
}
