using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using DialogueSystems;
using System.Collections.Generic;
using System.Collections;
using CoreSystems;
using System;

namespace DialogueSystems
{

    public class ElliController : Core, ICommunciation
    {

        private int ElliScriptLogger = 0;
        private int ElliInternalDialogueIterator = 0;
        private List<string> ElliScript = new List<string>(capacity: 60);
        private string ElliStringFileName;

        //Serialized Fields

        [SerializeField]
        private AudioSource ElliSource = new AudioSource();
        [SerializeField]
        private AudioClip[] ElliAudio = new AudioClip[10];


        void Awake()
        {
            ElliSource = GetComponent<AudioSource>();

        }

        //Object types
        ElliController ElliObject;
        LukeController LukeObject;
        BrendanPOVController BrendanObject;

        public ElliController()
        {

        }

        public ElliController(LukeController LukeObject)
        {
            this.LukeObject = LukeObject;
        }

        public ElliController(BrendanPOVController BrendanObject)
        {

            this.BrendanObject = BrendanObject;
        }


        // Use this for initialization
        void Start()
        {
            PopulateScript();

            ElliObject = new ElliController();

        }

        public IEnumerator DialogueIterator()
        {

            if (CoreDialogueObject.ConversationStateID == CoreDialogueSystems.ConversationState.Active)
            {

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E1_S1")
                {
                    yield return new WaitUntil(() => CoreDialogueObject.bWaitUntilPreviousDialogueFinished == true);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E1_S2")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E1_S2")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E1_S3")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E1_S4")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }



                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E1_S5")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E2_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E2_S2")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }





                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E3_S1")
                {
                    yield return new WaitForSeconds(1);

                   

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E3_S2")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E3_S3")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E4_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }



                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E5_S1")
                {
                  
                    CoreDialogueObject.CoreEventSystemNestedType.SceneObject.ComeDownstairs.Invoke();
                    yield return new WaitUntil(() => CoreDialogueObject.CoreEventSystemNestedType.ColliderObject.ElliComesBackDownStairs());

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E6_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;

                }




                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E7_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Nods head

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }




                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E8_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Nods head

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }





                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E9_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    //Nods head

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }




                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E10_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);



                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E10_S2")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);



                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E10_S3")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }



                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E11_S1")
                {
                    CoreEventSystemObject.SceneObject.ElliLukeCheckCot.Invoke();

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E11_S2")
                {
                    CoreEventSystemObject.SceneObject.ElliLukeCheckCot.Invoke();

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }



                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E12_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E13_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E14_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }



                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E14_S2")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E15_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }



                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E15_S2")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E15_S3")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }




                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E16_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E17_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }





                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E18_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E18_S2")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }



                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E19_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E19_S2")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }

                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E19_S3")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }


                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E20_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }



                if (CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator] == "E21_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);
                    DisplayScript(ScriptID: CoreDialogueObject.DialogueIDSequencer[ElliInternalDialogueIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    ElliInternalDialogueIterator++;
                }

            }
        }

        public void PlayAudio(string AudioID)
        {
            if (AudioID == "E1_S1")
            {
                ElliSource.clip = ElliAudio[1];
                ElliSource.Play();
            }

            if (AudioID == "E1_S2")
            {
                ElliSource.clip = ElliAudio[2];
                ElliSource.Play();
            }

            if (AudioID == "E1_S3")
            {
                ElliSource.clip = ElliAudio[3];
                ElliSource.Play();
            }

            if (AudioID == "E1_S4")
            {
                ElliSource.clip = ElliAudio[4];
                ElliSource.Play();
            }

            if (AudioID == "E1_S5")
            {
                ElliSource.clip = ElliAudio[5];
                ElliSource.Play();
            }

            if (AudioID == "E2_S1")
            {
                ElliSource.clip = ElliAudio[6];
                ElliSource.Play();
            }

            if (AudioID == "E2_S2")
            {
                ElliSource.clip = ElliAudio[7];
                ElliSource.Play();
            }

            if (AudioID == "E3_S1")
            {
                ElliSource.clip = ElliAudio[8];
                ElliSource.Play();
            }

            if (AudioID == "E3_S2")
            {
                ElliSource.clip = ElliAudio[9];
                ElliSource.Play();
            }

            if (AudioID == "E3_S3")
            {
                ElliSource.clip = ElliAudio[10];
                ElliSource.Play();
            }

            if (AudioID == "E4_S1")
            {
                ElliSource.clip = ElliAudio[11];
                ElliSource.Play();
            }

            if (AudioID == "E5_S1")
            {
                ElliSource.clip = ElliAudio[12];
                ElliSource.Play();
            }

            if (AudioID == "E6_S1")
            {
                ElliSource.clip = ElliAudio[13];
                ElliSource.Play();
            }

            if (AudioID == "E7_S1")
            {
                ElliSource.clip = ElliAudio[14];
                ElliSource.Play();
            }

            if (AudioID == "E8_S1")
            {
                ElliSource.clip = ElliAudio[15];
                ElliSource.Play();
            }

            if (AudioID == "E9_S1")
            {
                ElliSource.clip = ElliAudio[16];
                ElliSource.Play();
            }

            if (AudioID == "E10_S1")
            {
                ElliSource.clip = ElliAudio[17];
                ElliSource.Play();
            }

            if (AudioID == "E10_S2")
            {
                ElliSource.clip = ElliAudio[18];
                ElliSource.Play();
            }

            if (AudioID == "E10_S3")
            {
                ElliSource.clip = ElliAudio[19];
                ElliSource.Play();
            }

            if (AudioID == "E11_S1")
            {
                ElliSource.clip = ElliAudio[20];
                ElliSource.Play();
            }

            if (AudioID == "E11_S2")
            {
                ElliSource.clip = ElliAudio[21];
                ElliSource.Play();
            }

            if (AudioID == "E12_S1")
            {
                ElliSource.clip = ElliAudio[22];
                ElliSource.Play();
            }

            if (AudioID == "E12_S2")
            {
                ElliSource.clip = ElliAudio[23];
                ElliSource.Play();
            }

            if (AudioID == "E13_S1")
            {
                ElliSource.clip = ElliAudio[26];
                ElliSource.Play();
            }

            if (AudioID == "E14_S1")
            {
                ElliSource.clip = ElliAudio[27];
                ElliSource.Play();
            }

            if (AudioID == "E15_S1")
            {
                ElliSource.clip = ElliAudio[28];
                ElliSource.Play();
            }

            if (AudioID == "E15_S2")
            {
                ElliSource.clip = ElliAudio[29];
                ElliSource.Play();
            }

            if (AudioID == "E15_S3")
            {
                ElliSource.clip = ElliAudio[30];
                ElliSource.Play();
            }

            if (AudioID == "E16_S1")
            {
                ElliSource.clip = ElliAudio[31];
                ElliSource.Play();
            }

            if (AudioID == "E17_S1")
            {
                ElliSource.clip = ElliAudio[32];
                ElliSource.Play();
            }

            if (AudioID == "E18_S1")
            {
                ElliSource.clip = ElliAudio[33];
                ElliSource.Play();
            }

            if (AudioID == "E18_S2")
            {
                ElliSource.clip = ElliAudio[34];
                ElliSource.Play();
            }

            if (AudioID == "E19_S1")
            {
                ElliSource.clip = ElliAudio[35];
                ElliSource.Play();
            }

            if (AudioID == "E19_S2")
            {
                ElliSource.clip = ElliAudio[36];
                ElliSource.Play();
            }

            if (AudioID == "E19_S3")
            {
                ElliSource.clip = ElliAudio[37];
                ElliSource.Play();
            }

            if (AudioID == "E20_S1")
            {
                ElliSource.clip = ElliAudio[38];
                ElliSource.Play();
            }

            if (AudioID == "E21_S1")
            {
                ElliSource.clip = ElliAudio[39];
                ElliSource.Play();
            }

        }

        public void DisplayScript(string ScriptID)
        {

        }



        public IEnumerator ScriptIDDefinition(CoreDialogueSystems.ScriptID ScriptIdentification, string DefineScript)
        {



            //Use logger to check conditions, use iterators for dynamic functions

            ElliScriptLogger++;

            //print("Result for Elli Script Logger is " + ScriptLogger);

            int ElliInternalIterator = 0;

            if (ScriptIdentification == CoreDialogueSystems.ScriptID.Elli)
            {
                ElliScript.Add(DefineScript);

                yield return null;

                ElliInternalIterator++;
            }

        }


        public void PopulateScript()
        {

            ElliStringFileName = ElliAudio[0].ToString();

            if (ElliStringFileName.Contains("E1_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Yeah, I'm Elli Grove"));
            }

            ElliStringFileName = ElliAudio[1].ToString();

            if (ElliStringFileName.Contains("E1_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Um, err, um, err, well you can hear that Liam is crying"));

            }

            ElliStringFileName = ElliAudio[2].ToString();

            if (ElliStringFileName.Contains("E1_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "He cries, all the time with his Belly Ache. And his teething"));

            }

            ElliStringFileName = ElliAudio[3].ToString();

            if (ElliStringFileName.Contains("E1_S4"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Erm... it's not really convenient at the moment, could you come back tomorrow"));

            }

            ElliStringFileName = ElliAudio[4].ToString();

            if (ElliStringFileName.Contains("E1_S5"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Could you come back tomorrow"));
            }

            ElliStringFileName = ElliAudio[5].ToString();

            if (ElliStringFileName.Contains("E2_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Well, OK, only for a little while"));
            }

            ElliStringFileName = ElliAudio[6].ToString();

            if (ElliStringFileName.Contains("E2_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "You'll have to get past Mable though, she don't like strangers"));
            }

            ElliStringFileName = ElliAudio[7].ToString();

            if (ElliStringFileName.Contains("E3_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "I told you, she don't like strangers"));
            }

            ElliStringFileName = ElliAudio[8].ToString();

            if (ElliStringFileName.Contains("E3_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Anyway she ain't my dog"));
            }

            ElliStringFileName = ElliAudio[9].ToString();

            if (ElliStringFileName.Contains("E3_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "'ere, I'll hold her while you get by"));
            }

            ElliStringFileName = ElliAudio[10].ToString();

            if (ElliStringFileName.Contains("E4_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Oh, err, just a friend"));
            }

            ElliStringFileName = ElliAudio[11].ToString();

            if (ElliStringFileName.Contains("E5_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Well, you better go into the front room now your in"));

            }

            ElliStringFileName = ElliAudio[12].ToString();

            if (ElliStringFileName.Contains("E6_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Oh...yeah, he's...Liam's dad"));
            }


            ElliStringFileName = ElliAudio[13].ToString();

            if (ElliStringFileName.Contains("E7_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Yeah"));
            }

            ElliStringFileName = ElliAudio[14].ToString();

            if (ElliStringFileName.Contains("E8_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Yeah, that's right"));
            }

            ElliStringFileName = ElliAudio[15].ToString();

            if (ElliStringFileName.Contains("E9_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Oh, err, well, she usually goes to nursery, erm... but she's staying with...err.. Luke's mum at the moment"));
            }

            ElliStringFileName = ElliAudio[16].ToString();

            if (ElliStringFileName.Contains("E10_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Cos of Liam's crying"));
            }

            ElliStringFileName = ElliAudio[17].ToString();

            if (ElliStringFileName.Contains("E10_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "He goes on and on, all night, I'm knackered."));
            }

            ElliStringFileName = ElliAudio[18].ToString();

            if (ElliStringFileName.Contains("E10_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "I can't cope with him and her, it's too much"));
            }

            ElliStringFileName = ElliAudio[19].ToString();

            if (ElliStringFileName.Contains("E11_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Is he, I only just changed him, little monkey"));
            }

            ElliStringFileName = ElliAudio[20].ToString();

            if (ElliStringFileName.Contains("E11_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "It's all that milk"));

            }

            ElliStringFileName = ElliAudio[21].ToString();

            if (ElliStringFileName.Contains("E12_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Most have dropped it"));
            }

            ElliStringFileName = ElliAudio[22].ToString();

            if (ElliStringFileName.Contains("E12_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "See how tired I am"));
            }

            ElliStringFileName = ElliAudio[23].ToString();

            if (ElliStringFileName.Contains("E13_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Thanks"));
            }

            ElliStringFileName = ElliAudio[24].ToString();

            if (ElliStringFileName.Contains("E14_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Oh don't worry, I will clear it up"));
            }

            ElliStringFileName = ElliAudio[25].ToString();

            if (ElliStringFileName.Contains("E14_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "I was about to pick it up when you rang the bell"));
            }

            ElliStringFileName = ElliAudio[26].ToString();

            if (ElliStringFileName.Contains("E15_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "I'll do his nappy in a minute"));
            }

            ElliStringFileName = ElliAudio[27].ToString();

            if (ElliStringFileName.Contains("E15_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "I did ask the health visitor about the rash, said I was worried, but I ran out of cream, didn't I?"));
            }

            ElliStringFileName = ElliAudio[28].ToString();

            if (ElliStringFileName.Contains("E15_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Nothing to worry about really"));
            }

            ElliStringFileName = ElliAudio[29].ToString();

            if (ElliStringFileName.Contains("E16_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "I was just gonna get some"));
            }

            ElliStringFileName = ElliAudio[30].ToString();

            if (ElliStringFileName.Contains("E17_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "I told you, she's with Luke's mum"));
            }

            ElliStringFileName = ElliAudio[31].ToString();

            if (ElliStringFileName.Contains("E18_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Over near Seagulls Hospital, Luke took her yesterday"));
            }

            ElliStringFileName = ElliAudio[32].ToString();

            if (ElliStringFileName.Contains("E19_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Luke, please"));
            }

            ElliStringFileName = ElliAudio[33].ToString();

            if (ElliStringFileName.Contains("E19_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "He don't mean it, he's had a bad head all day; and you've just rubbed him up the wrong way"));
            }

            ElliStringFileName = ElliAudio[34].ToString();

            if (ElliStringFileName.Contains("E19_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Best if you go now, I'll ring you later and take the baby to the clinic tomorrow, just like you said."));
            }

            ElliStringFileName = ElliAudio[35].ToString();

            if (ElliStringFileName.Contains("E20_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "I'll show you out"));
            }

            ElliStringFileName = ElliAudio[36].ToString();

            if (ElliStringFileName.Contains("E21_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Yeah, OK"));
            }


        }


        // Update is called once per frame
        void Update()
        {

            ElliInternalDialogueIterator = CoreDialogueObject.MaritimeDialogueIterator;

        }


        ICommunciation ICommunciation.ReturnType()
        {
            throw new NotImplementedException();
        }

        public void ReceiveResponse(ICommunciation CharacterType)
        {
            throw new NotImplementedException();
        }
    }


    }


