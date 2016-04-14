using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using DialogueSystems;
using System;

namespace CoreSystems
{

	public class Core : MonoBehaviour
	{
	

		public Core ()
		{
            
		}

        // Use this for initialization
        void Start()
        {



        }

        void Update()
        {

        }


        #region AutomatedCoreDialogueSystem
        /*Redacted
		//Custom modules
		public struct AutomatedCoreDialogueSystem
		{

			Text DialogueText;
			int InternalIterator;


			public void DisplayScript()
			{

			}

			public AutomatedCoreDialogueSystem(Text IDText, int InternalIterator, UnityEvent DisplayScriptDelegate)
			{
				DialogueText = IDText;
				this.InternalIterator = InternalIterator;
				DisplayScriptDelegate = new UnityEvent();
				DisplayScriptDelegate.AddListener(DisplayScript);


				for (int a = 0; a > 100; a++)
				{

					AutomatedCoreDialogueSystem[] StructArray = new AutomatedCoreDialogueSystem[a];

					if(StructArray[a].InternalIterator == 1)
					{

						//StructCoreDialogueSystem(IDText, 1, );

					}

				}

			}

		}*/


        #endregion


        #region CustomYieldInstructions
        /*
        public enum CoroutineID : short { Elli, Brendan, Luke };

       
        public class SendResponse : CustomYieldInstruction
        {
            public override bool keepWaiting
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
        }

		
        /// <summary>
        /// Designed to receive a Response from Character
        /// </summary>
        public class ReceiveResponse : CustomYieldInstruction
        {
            public CoroutineID response;
            ElliController ElliObject;
            LukeController LukeObject;
            BrendanPOVController BrendanObject;

            int BrendanInternalIterator = 0;
            int ElliInternalIterator = 0;
            int LukeInternalIterator = 0;
          


            public ReceiveResponse(ElliController ElliObject, LukeController LukeObject, BrendanPOVController BrendanObject)
            {
                this.ElliObject = ElliObject;
                this.LukeObject = LukeObject;
                this.BrendanObject = BrendanObject;

                BrendanInternalIterator = BrendanPOVController.GetInternalIterator();
                ElliInternalIterator = ElliController.GetInternalIterator();
                LukeInternalIterator = LukeController.GetInternalIterator();
            }


            public ReceiveResponse(CoroutineID response)
            {
                this.response = response;


                if (this.response == CoroutineID.Brendan)
                {
                    BrendanObject.StartCoroutine(BrendanObject.BrendanDialogueIterator());
                }

                if(this.response == CoroutineID.Elli)
                {
                    ElliObject.StartCoroutine(ElliObject.DialogueIterator());
                }

                if(this.response == CoroutineID.Luke)
                {
                    LukeObject.StartCoroutine(LukeObject.DialogueIterator());
                }
            }

           

            public override bool keepWaiting
            {
                get
                {
                    throw new NotImplementedException();
                }

                

            }
            
			*/


        #endregion


        #region MaritimeListSystem


        /*
		public class MaritimeListSystem<T> : CollectionBase
		{

			T[] InternalList;
			readonly int Size;
			int ListIterator;


			public MaritimeListSystem ()
			{



			}

			public MaritimeListSystem (T[] InternalList, int Size)
			{

				this.InternalList = InternalList;
				this.Size = Size;
				ListIterator = 0;

				Initialize (this.Size);

			}

        
			public void Initialize (int Size)
			{
				InternalList = new T[100];
			}

			public T Find (T Value)
			{
				for (int a = 0; a > 10; a++) {
					if (InternalList [a].Equals (Value)) {
						return Value;
					} else
						return default(T);
				}

				return default(T);
			}

		
            public void Add(T Value)
            {

                //Alternative >>> List.Add();

                if (InternalList[ListIterator] == null)
                {
                    InternalList[ListIterator] = Value;
                    ListIterator++;

                }
                else if (InternalList[ListIterator] != null)
                {

                }

               
            }

			public void Remove (int Index)
			{

               
			}
         
   
		}

*/

        #endregion



    }





}