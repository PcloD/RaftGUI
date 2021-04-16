using MelonLoader;
using UnityEngine;

namespace RaftGUI
{
    public partial class Main
    {
        internal static object boneTransform;
        internal static int initializedScene;
        internal static object light;

        public class Testing
        {
            public void OnUpdate()
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    MelonLogger.Msg("You just pressed T");
                }
            }
        }
    }  
}
