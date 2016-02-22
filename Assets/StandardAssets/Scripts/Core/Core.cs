using UnityEngine;
using UnityEngine.Events;
using UnityEditor.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Threading;


namespace CoreSystems
{

    public class Core : MonoBehaviour
    {

        public int newone;

        public enum SceneState { Cutscene, Dicussion_Box, Conversation, MainMenu };

        //UnityAction StartButton = new UnityAction(GUIEvent_StartButtonEvent());



        RuntimePlatform MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;

        public Core()
        {
           

        }

        // Use this for initialization
        void Start()
        {
            Debug.Log("Core Active");


            if (MaritimeRuntimePlatform == RuntimePlatform.WindowsEditor)
            {

                Debug.Log("Optimised for Windows");

            }
            else if (MaritimeRuntimePlatform == RuntimePlatform.WindowsPlayer)
            {

                Debug.Log("Optimised for Windows");

            } else if (MaritimeRuntimePlatform == RuntimePlatform.OSXEditor)
            {

                Debug.Log("Not optimized for this platform");

            }

        }

        // Update is called once per frame
        void Update()
        {


        }

    }

}