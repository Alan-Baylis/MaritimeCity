using UnityEngine;
using DialogueSystems;
using System.Collections;

public class NavigationObject : NavigationInfrastructure, INavigation, INavigationCommunicationBridge
{



    public GameObject NavigationGameObject;
    public Collider NavigationUniversalCollider = null;
    public static NavigationObject NavigationObjectInstance;
    public Vector3 tBrendanPosition = BrendanPOVController.GetPosition();

    bool Destination2 = false;

    public NavigationObject()
    {


    }

    MaritimeRuntimeInfrastructure.NavigationSequences SequenceID;

    // Use this for initialization
    void Start()
    {

        NavigationGameObject = gameObject;

        SequenceID = MaritimeRuntimeInfrastructure.NavigationSequences.Sequence1;

        
        tBrendanPosition.y = 0.0f;
        tBrendanPosition.x = -62.8f;

        Debug.Log("Name of the current Object is " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
     
        if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator == 3)
        {
            SequenceID = MaritimeRuntimeInfrastructure.NavigationSequences.Sequence2;
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        NavigationUniversalCollider = other;

        if (gameObject.name == "Back Door" && other.name == "Dalmatian")
        {
            //"Doesn't work don't know why, will try using strings"
            //MaritimeRuntimeInfrastructure.MaritimeCoreObject.StopDialogueIterator(BrendanPOVController.BrendanInstance);
            //MaritimeRuntimeInfrastructure.MaritimeCoreObject.StopDialogueIterator(ElliController.ElliInstance);
            //MaritimeRuntimeInfrastructure.MaritimeCoreObject.StopDialogueIterator(LukeController.LukeInstance);

            other.gameObject.SetActive(false);
        }

        if (gameObject.name == "Back Door" && other.name == "Elli_Grove")
        {

            UtilitiesClass.SetBoolActive(Destination2);
            other.transform.LookAt(tBrendanPosition);

        }

        if (gameObject.name == "Front Door" && other.name == "Elli_Grove" && Time.time > 10.0f && SequenceID == MaritimeRuntimeInfrastructure.NavigationSequences.Sequence1)
        {
            //SequenceID = MaritimeRuntimeInfrastructure.NavigationSequences.Sequence2;

            other.GetComponent<Animator>().Play("idle");
            other.transform.LookAt(tBrendanPosition);

            BrendanPOVController.bStopCoroutine(false);
            MaritimeRuntimeInfrastructure.MaritimeCoreObject.LaunchDialogueIterator(BrendanPOVController.BrendanInstance);
           

            //BrendanPOVController.bStopCoroutine(false);
            //ElliController.bStopCoroutine(false);
            //MaritimeRuntimeInfrastructure.MaritimeCoreObject.LaunchDialogueIterator(ElliController.ElliInstance, BrendanPOVController.BrendanInstance, LukeController.LukeInstance);

        }


        if (gameObject.name == "Elli Hallway" && other.name == "Elli_Grove" && SequenceID == MaritimeRuntimeInfrastructure.NavigationSequences.Sequence2)
        {
            //Elli walk through door
            ElliController.ElliInstance.transform.LookAt(MaritimeRuntimeInfrastructure.MaritimeCoreObject.LocationsWithinHouse[5].transform.position);

        }

        if (gameObject.name == "Elli Walk Through Door" && other.name == "Elli_Grove" && SequenceID == MaritimeRuntimeInfrastructure.NavigationSequences.Sequence2)
        {
            //Elli walk through door
            //ElliController.ElliInstance.transform.LookAt(MaritimeRuntimeInfrastructure.MaritimeCoreObject.LocationsWithinHouse[3].transform.position);

        }

        if (gameObject.name == "Entrance into Living Room" && other.name == "Elli_Grove" && SequenceID == MaritimeRuntimeInfrastructure.NavigationSequences.Sequence2)
        {
            //Elli walk through door
            //ElliController.ElliInstance.transform.LookAt(MaritimeRuntimeInfrastructure.MaritimeCoreObject.LocationsWithinHouse[5].transform.position);

        }

    }

    public void OnTriggerExit(Collider other)
    {

    }

    public void OnTriggerStay(Collider other)
    {

        if (gameObject.name == "Front Door" && other.name == "Elli_Grove" && Time.time > 20.0f && SequenceID == MaritimeRuntimeInfrastructure.NavigationSequences.Sequence2)
        {

            //Back Door
            ElliController.ElliInstance.transform.LookAt(MaritimeRuntimeInfrastructure.BackDoor);
            ElliController.ElliInstance.GetComponent<Animator>().Play("walking");

            //BrendanPOVController.bStopCoroutine(false);
            //ElliController.bStopCoroutine(false);
            //MaritimeRuntimeInfrastructure.MaritimeCoreObject.LaunchDialogueIterator(ElliController.ElliInstance, BrendanPOVController.BrendanInstance, LukeController.LukeInstance);

        }




    }




    #region INavigation Interface Implementation

    public NavigationObject GetObject(string ObjectName)
    {
        for (int a = 0; a < NavigationObjects.Length; a++)
        {
            if (NavigationObjects[a].name == ObjectName)
            {

                return NavigationObjects[a];

            }

        }

        return null;
    }

    public void PlayAnimation(ICharacterSystem Character, Collider Target, string AnimationState)
    {

    }

    public string GetName()
    {
        return gameObject.name;
    }

    public Vector3 GetPosition()
    {
        return gameObject.transform.position;
    }

    #endregion
}
