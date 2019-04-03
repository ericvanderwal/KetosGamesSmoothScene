// dumb game dev 2019

using UnityEngine;
using KetosGames.SceneTransition;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("Ketos Games")]
    [Tooltip("Load a new scene using Ketos Games Scene Transition.")]
    public class KetosGamesSceneLoad : FsmStateAction
    {
        [Tooltip("Scene name as string")]
        public FsmString sceneName;

        public override void Reset()
        {
            sceneName = "";
        }

        public override void OnEnter()
        {
            SceneLoader.LoadScene(sceneName.Value);
        }
    }
}