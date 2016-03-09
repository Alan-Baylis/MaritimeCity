using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using DialogueSystems;
using System.Collections.Generic;
using System.Collections;
using CoreSystems;
using System;

namespace DialogueSystems
{

    public class ElliController : Core
    {

        private int ElliScriptLogger = 0;
        [SerializeField] private List<string> ElliScript = new List<string>(capacity: 60);
        private string ElliStringFileName;
        private int InternalDisplayIterator = 0;
        [SerializeField] private Text ElliDialogueText;
        [SerializeField] private string[] DialogueIDSequencer = new string[108];
        private int ElliIterator;
		public AnimationClip[] AdHocAnimationClips = new AnimationClip[10];
		public Animator ElliAnimator;

        //Serialized Fields

        [SerializeField]
        private AudioSource ElliSource = new AudioSource();
        [SerializeField]
        private AudioClip[] ElliAudio = new AudioClip[38];

        public static ElliController ElliInstance;

        void Awake()
        {
            ElliSource = GetComponent<AudioSource>();
			ElliAnimator = GetComponent<Animator> ();
            DialogueIDSequencer = CoreDialogueSystems.DialogueIDSequencer;


        }
			

        //Object types


        public int GetInternalIterator()
        {
            return ElliIterator;
        }


        // Use this for initialization
        void Start()
        {
            PopulateScript();
			CoreDialogueSystems.InitializeDialogueIterator (DialogueIDSequencer: DialogueIDSequencer);
            StartCoroutine(DialogueIterator());


			ElliAnimator.applyRootMotion = true;
			//ElliAnimator.bodyPosition = null;
			//ElliAnimator.bodyRotation = null;

			//ElliAnimator.PlayInFixedTime ("look_around");
			//ElliAnimator.SetLookAtPosition (BrendanPOVController.PlayerPosition);

        }


		void SetBodyPosition(Vector3 Position)
		{
			ElliAnimator.bodyPosition = Position;

			Debug.Log ("Function fires correctly");
		}

		void SetBodyRotation(Quaternion Rotation)
		{

			ElliAnimator.bodyRotation = Rotation;

		}

        public IEnumerator DialogueIterator()
        {
            State = CoreDialogueSystems.ConversationState.Active;

            Debug.Log("State is fully functional");

            if (State == CoreDialogueSystems.ConversationState.Active)
            {

				if (DialogueIDSequencer[MaritimeInternalIterator] == "E1_S1")
                {
                    //yield return new WaitUntil(() => ScriptStateID == ScriptState.Elli);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    MaritimeInternalIterator++;

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E1_S2")
                {
                   
                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                    

                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E1_S3")
                {
               

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E1_S4")
                {
    

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E1_S4")
                {
                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }



                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E1_S5")
                {
                  

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

					ScriptStateID = ScriptState.Brendan;

                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E2_S1")
                {
					yield return new WaitUntil(() => BrendanPOVController.BrendanSource.isPlaying == false);
					//replace with static class 
					//

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E2_S2")
                {

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E3_S1")
                {
                    //yield return new WaitUntil(() => BrendanObject.BrendanFinishedTalking() == true);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E3_S2")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E3_S3")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E4_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }



                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E5_S1")
                {

					CoreEventSystem.SceneObject.ComeDownstairs.Invoke();
					yield return new WaitUntil(() => CoreEventSystem.ColliderObject.ElliComesBackDownStairs());

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E6_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;

                }




                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E7_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Nods head

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }




                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E8_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Nods head

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }





                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E9_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    //Nods head

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }




                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E10_S1")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);



                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E10_S2")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);



                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E10_S3")
                {
                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }



                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E11_S1")
                {
					CoreEventSystem.SceneObject.ElliLukeCheckCot.Invoke();

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E11_S2")
                {
					CoreEventSystem.SceneObject.ElliLukeCheckCot.Invoke();

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }



                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E12_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E13_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E14_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }



                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E14_S2")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E15_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }



                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E15_S2")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E15_S3")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E16_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E17_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E18_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E18_S2")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }



                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E19_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E19_S2")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }

                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E19_S3")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }


                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E20_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }



                else if (DialogueIDSequencer[MaritimeInternalIterator] == "E21_S1")
                {

                    yield return new WaitForSeconds(1);

                    PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                    DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                    yield return new WaitUntil(() => ElliSource.isPlaying == false);

                    MaritimeInternalIterator++;
                }

                yield return new WaitForSeconds(0.5f);

                StartCoroutine(DialogueIterator());


            }

        }

        public void PlayAudio(string AudioID)
        {
            if (AudioID == "E1_S1")
            {
                ElliSource.clip = ElliAudio[0];
                ElliSource.Play();
            }

            if (AudioID == "E1_S2")
            {
                ElliSource.clip = ElliAudio[1];
                ElliSource.Play();
            }

            if (AudioID == "E1_S3")
            {
                ElliSource.clip = ElliAudio[2];
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
            if (ScriptID == "E1_S1")
            {
                //I don't think it will work as intended..

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;

            }

            else if (ScriptID == "E1_S2")
            {
                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E1_S3")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E1_S4")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E1_S5")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E2_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E2_S2")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E3_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E3_S2")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E3_S3")
            {
                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E4_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;

            }

            else if (ScriptID == "E5_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E6_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E7_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E8_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E9_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E10_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E10_S2")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E10_S3")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E11_S1")
            {
                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;

            }

            else if (ScriptID == "E11_S2")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E12_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E12_S2")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E13_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E14_S1")
            {
                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;

            }

            else if (ScriptID == "E14_S2")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E15_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E15_S2")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E15_S3")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;

            }

            else if (ScriptID == "E16_S1")
            {
                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;

            }

            else if (ScriptID == "E17_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E18_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E19_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E19_S2")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E19_S3")
            {
                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;

            }

            else if (ScriptID == "E20_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }

            else if (ScriptID == "E21_S1")
            {

                ElliDialogueText.text = ElliScript[InternalDisplayIterator];
                InternalDisplayIterator++;
            }



            //Likely to be wrong need a dictionary or a two dimensional array to ensure that we are only using ElliScript
            /*
            string[] ElliDialogueIDSequencer = new string[GetCoreDialogueSystemObject().DialogueIDSequencer.Length];

            GetCoreDialogueSystemObject().DialogueIDSequencer.CopyTo(ElliDialogueIDSequencer, 0);

            for (int a = 0; a < ElliDialogueIDSequencer.Length; a++)
            {
                if (ScriptID == ElliDialogueIDSequencer[a] && ElliDialogueIDSequencer[a].Contains("E"))
                {
                    GetCoreDialogueSystemObject().DialogueText.text = ElliScript[a];
                  
                }

            }

             */

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
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Elli, "Erm... it's not really convenient at the moment"));

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

            Debug.Log("This is the current state of Maritime Internal Iterator for Elli " + MaritimeInternalIterator);
            Debug.Log("Query dialog state for Elli is " + ScriptStateID);
            Debug.Log("Query conversation state for Elli is " + State);

			float ElliTime = 10.0f;

			if (ElliTime < Time.deltaTime) {

				ElliAnimator.PlayInFixedTime ("bashful");

			}


			if (MaritimeInternalIterator == 1) 
			{

				SetBodyPosition (BrendanPOVController.PlayerPosition);

			}


        }


        public void ReceiveResponse(ICommunciation CharacterType)
        {
            throw new NotImplementedException();
        }
    }


    }


