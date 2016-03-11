using UnityEngine;
using CoreSystems;
using System.Collections;
using DialogueSystems;


public class MaritimeRuntimeInfrastructure : MonoBehaviour
{


    int MaritimeDialogueIterator = 0;
    GameObject BrendanInstanceObject;

    public Transform[] Locations = new Transform[10];


    // Use this for initialization
    void Start()
    {

        BrendanInstanceObject = BrendanPOVController.BrendanSingletonObjectInstance.gameObject;

        StartCoroutine(OpeningSequence_FrontDoorBell());

    }

    // Update is called once per frame
    void Update()
    {

        MaritimeDialogueIterator = Core.CoreDialogueSystems.MaritimeDialogueIterator;

        if (MaritimeDialogueIterator == 0)
        {

            LerpOperation(Locations[0], Locations[1]);

         

        }

    }


    /// <summary>
    /// When the scene first starts
    /// </summary>
    IEnumerator OpeningSequence_FrontDoorBell()
    {

        if (MaritimeDialogueIterator == 0)
        {

            FrontDoor.PlayDoorBell();

            yield return new WaitForSeconds(FrontDoor.FrontDoorSource.clip.length * 1.1f);

            Quaternion FrontDoorOpen = FrontDoor.FrontDoorGameObject.transform.rotation;

            FrontDoorOpen = Quaternion.FromToRotation(FrontDoor.FrontDoorGameObject.transform.parent.right, FrontDoor.FrontDoorGameObject.transform.up);

            Core.State = Core.CoreDialogueSystems.ConversationState.Active;

        }
    }



    IEnumerator Sequence_DogBarking()
    {

        if (MaritimeDialogueIterator == 5)
        {
            Vector3 ElliLookAt = ElliController.ElliInstance.transform.position;

            Quaternion.LookRotation(forward: (ElliLookAt));

            while (MaritimeDialogueIterator < 10)
            {
                MableController.MableSingletonObject.Play();

            }
      
        }

        yield return new WaitForSeconds(3.0f);
    }


    IEnumerator StepIntoLivingRoom()
    {
        yield return null;
    }




    void LerpOperation(Transform PointA, Transform PointB)
    {
        BrendanPOVController.BrendanSingletonObjectInstance.transform.localPosition = Vector3.LerpUnclamped(PointA.position, PointB.position, Time.time / 10);
    }

}

