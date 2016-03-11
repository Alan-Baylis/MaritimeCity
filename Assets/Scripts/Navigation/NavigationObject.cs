using UnityEngine;
using System.Collections;

public class NavigationObject : NavigationInfrastructure, INavigation
{

    private GameObject NavigationGameObject;


   
    private NavigationObject()
    {
        
            
    }


    // Use this for initialization
    void Start()
    {

        NavigationGameObject = gameObject;
        NavigationGameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("This has been trespassed");
    }

    public void Stop()
    {
        throw new System.NotImplementedException();
    }

    public void Play(string StateName)
    {
        throw new System.NotImplementedException();
    }

    public string GetName()
    {
        return gameObject.name;
    }

    public Vector3 GetPosition()
    {
        return gameObject.transform.position;
    }
}
