using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using DialogueSystems;
using System.Collections.Generic;
using System.Collections;
using CoreSystems;

namespace DialogueSystems
{

    public class ElliController : Core.CoreDialogueSystems
    {


        string FileName;
		public AudioSource ElliSource = new AudioSource();
        public AudioClip[] ElliAudio = new AudioClip[10];
		private List<string> ElliScript = new List<string> (capacity: 60);

        void Awake()
        {
            ElliSource = CoreNestedType.GetComponent <AudioSource>();
            
         }

        


        // Use this for initialization
        void Start()
		{ 
			PopulateScript ();

            if(ConversationStateID == ConversationState.Active)
            {
               
            }
		}

		public IEnumerator ElliDialogueIterator()
		{



			if (DialogueIDSequencer[Core.MaritimeDialogueIterator] == "E1_S1")
			{
				yield return new WaitUntil(() => bWaitUntilPreviousDialogueFinished == true);

				PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
				DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

				//Invoke relevant Event here!

				yield return new WaitUntil(() => ElliSource.isPlaying == false);

				MaritimeDialogueIterator++;

			}


			if (DialogueIDSequencer[MaritimeDialogueIterator] == "E1_S2")
			{
				yield return new WaitForSeconds(1);

				PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
				DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

				//Invoke relevant Event here!

				yield return new WaitUntil(() => ElliSource.isPlaying == false);

				MaritimeDialogueIterator++;

			}

            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E1_S2")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }

            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E1_S3")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }

            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E1_S4")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }



            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E1_S5")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }


            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E2_S1")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }


            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E2_S2")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }





            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E3_S1")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }


            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E3_S2")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }


            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E3_S3")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }





            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E4_S1")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }



            if (DialogueIDSequencer[MaritimeDialogueIterator] == "B5_S1")
            {
                //CoreEvents.SceneObject.WalkDogUpstairs.Invoke();
                yield return new WaitUntil(() => CoreEventSystemNestedType.ColliderObject.ElliFinishedTakingDogUpstairs());

                BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }



            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E5_S1")
            {

                CoreEventSystemNestedType.SceneObject.ComeDownstairs.Invoke();
                yield return new WaitUntil(() => CoreEventSystemNestedType.ColliderObject.ElliComesBackDownStairs());

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }







            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E6_S1")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;

            }




            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E7_S1")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Nods head

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }




            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E8_S1")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Nods head

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }





            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E9_S1")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                //Nods head

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }




            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E10_S1")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);



                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }

            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E10_S2")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);



                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }

            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E10_S3")
            {
                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }



            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E11_S1")
            {
                CoreEvents.SceneObject.ElliLukeCheckCot.Invoke();

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }

            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E11_S2")
            {
                CoreEvents.SceneObject.ElliLukeCheckCot.Invoke();

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }



            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E12_S1")
            {


                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }



            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E13_S1")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }





            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E14_S1")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }



            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E14_S2")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }







            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E15_S1")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }



            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E15_S2")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }


            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E15_S3")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }




            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E16_S1")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }


            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E17_S1")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }





            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E18_S1")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }

            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E18_S2")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }



            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E19_S1")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }

            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E19_S2")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }

            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E19_S3")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }


            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E20_S1")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
            }



            if (DialogueIDSequencer[MaritimeDialogueIterator] == "E21_S1")
            {

                yield return new WaitForSeconds(1);

                Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                MaritimeDialogueIterator++;
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

        int ScriptLogger = 0;


        public IEnumerator ScriptIDDefinition(ScriptID ScriptIdentification, string DefineScript)
        {
            //Use logger to check conditions, use iterators for dynamic functions

            ScriptLogger++;

            print("Result for Elli Script Logger is " + ScriptLogger);

            int ElliInternalIterator = 0;

            if (ScriptIdentification == ScriptID.Elli)
            {
                ElliScript.Add(DefineScript);

                yield return null;

                ElliInternalIterator++;
            }

        }


        public void PopulateScript()
        {

            FileName = ElliAudio[0].ToString();

            if (FileName.Contains("E1_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Yeah, I'm Elli Grove"));
            }

            FileName = ElliAudio[1].ToString();

            if (FileName.Contains("E1_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Um, err, um, err, well you can hear that Liam is crying"));

            }

            FileName = ElliAudio[2].ToString();

            if (FileName.Contains("E1_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "He cries, all the time with his Belly Ache. And his teething"));

            }

            FileName = ElliAudio[3].ToString();

            if (FileName.Contains("E1_S4"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Erm... it's not really convenient at the moment, could you come back tomorrow"));

            }

            FileName = ElliAudio[4].ToString();

            if (FileName.Contains("E1_S5"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Could you come back tomorrow"));
            }

            FileName = ElliAudio[5].ToString();

            if (FileName.Contains("E2_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Well, OK, only for a little while"));
            }

            FileName = ElliAudio[6].ToString();

            if (FileName.Contains("E2_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "You'll have to get past Mable though, she don't like strangers"));
            }

            FileName = ElliAudio[7].ToString();

            if (FileName.Contains("E3_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "I told you, she don't like strangers"));
            }

            FileName = ElliAudio[8].ToString();

            if (FileName.Contains("E3_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Anyway she ain't my dog"));
            }

            FileName = ElliAudio[9].ToString();

            if (FileName.Contains("E3_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "'ere, I'll hold her while you get by"));
            }

            FileName = ElliAudio[10].ToString();

            if (FileName.Contains("E4_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Oh, err, just a friend"));
            }

            FileName = ElliAudio[11].ToString();

            if (FileName.Contains("E5_S1"))
            {
               StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Well, you better go into the front room now your in"));

            }

            FileName = ElliAudio[12].ToString();

            if (FileName.Contains("E6_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Oh...yeah, he's...Liam's dad"));
            }


            FileName = ElliAudio[13].ToString();

            if (FileName.Contains("E7_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Yeah"));
            }

            FileName = ElliAudio[14].ToString();

            if (FileName.Contains("E8_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Yeah, that's right"));
            }

            FileName = ElliAudio[15].ToString();

            if (FileName.Contains("E9_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Oh, err, well, she usually goes to nursery, erm... but she's staying with...err.. Luke's mum at the moment"));
            }

            FileName = ElliAudio[16].ToString();

            if (FileName.Contains("E10_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Cos of Liam's crying"));
            }

            FileName = ElliAudio[17].ToString();

            if (FileName.Contains("E10_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "He goes on and on, all night, I'm knackered."));
            }

            FileName = ElliAudio[18].ToString();

            if (FileName.Contains("E10_S3"))
            {
               StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "I can't cope with him and her, it's too much"));
            }

            FileName = ElliAudio[19].ToString();

            if (FileName.Contains("E11_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Is he, I only just changed him, little monkey"));
            }

            FileName = ElliAudio[20].ToString();

            if (FileName.Contains("E11_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "It's all that milk"));

            }

            FileName = ElliAudio[21].ToString();

            if (FileName.Contains("E12_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Most have dropped it"));
            }

            FileName = ElliAudio[22].ToString();

            if (FileName.Contains("E12_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "See how tired I am"));
            }

            FileName = ElliAudio[23].ToString();

            if (FileName.Contains("E13_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Thanks"));
            }

            FileName = ElliAudio[24].ToString();

            if (FileName.Contains("E14_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Oh don't worry, I will clear it up"));
            }

            FileName = ElliAudio[25].ToString();

            if (FileName.Contains("E14_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "I was about to pick it up when you rang the bell"));
            }

            FileName = ElliAudio[26].ToString();

            if (FileName.Contains("E15_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "I'll do his nappy in a minute"));
            }

            FileName = ElliAudio[27].ToString();

            if (FileName.Contains("E15_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "I did ask the health visitor about the rash, said I was worried, but I ran out of cream, didn't I?"));
            }

            FileName = ElliAudio[28].ToString();

            if (FileName.Contains("E15_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Nothing to worry about really"));
            }

            FileName = ElliAudio[29].ToString();

            if (FileName.Contains("E16_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "I was just gonna get some"));
            }

            FileName = ElliAudio[30].ToString();

            if (FileName.Contains("E17_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "I told you, she's with Luke's mum"));
            }

            FileName = ElliAudio[31].ToString();

            if (FileName.Contains("E18_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Over near Seagulls Hospital, Luke took her yesterday"));
            }

            FileName = ElliAudio[32].ToString();

            if (FileName.Contains("E19_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Luke, please"));
            }

            FileName = ElliAudio[33].ToString();

            if (FileName.Contains("E19_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "He don't mean it, he's had a bad head all day; and you've just rubbed him up the wrong way"));
            }

            FileName = ElliAudio[34].ToString();

            if (FileName.Contains("E19_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Best if you go now, I'll ring you later and take the baby to the clinic tomorrow, just like you said."));
            }

            FileName = ElliAudio[35].ToString();

            if (FileName.Contains("E20_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "I'll show you out"));
            }

            FileName = ElliAudio[36].ToString();

            if (FileName.Contains("E21_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Elli, "Yeah, OK"));
            }


        }


        // Update is called once per frame
        void Update()
        {

        }
    }

}
