using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using FMODUnity;
using Console = System.Console;
using Object = UnityEngine.Object;
using String = System.String;

namespace RaftGUI
{
    public class Main1 : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log("Set console title to: Raft");
            Console.Title = string.Format("Raft");
        }

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                MelonLogger.Msg("You just pressed T");
            }
        }
    }
}

public class ESP
{
    
}