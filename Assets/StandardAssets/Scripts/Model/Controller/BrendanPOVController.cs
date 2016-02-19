using UnityEngine;
using System.Collections;

public class BrendanPOVController : MonoBehaviour {

    public Camera BrendanPOV = new Camera();
    public GameObject ElliDoor;



    Vector3 from;
    Vector3 there;
    float speed;


	// Use this for initialization
	void Start ()
    {
        from = BrendanPOV.transform.position;
        there = ElliDoor.transform.position;
        speed = 50;


        BrendanPOV.GetComponent<Camera>();
        BrendanPOV.ViewportToScreenPoint (position: from);
        BrendanPOV.ScreenPointToRay (position: from);

    }

    void InputController()
    {
        Space CoordinateSpace = new Space();
        CoordinateSpace = Space.Self;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Iterate through text
        }

            
    }
	
	// Update is called once per frame
	void Update ()
    {

        if(from == there)
        {
            Debug.Log("Success");
        }

        Vector3.Lerp(a: from, b: there, t: speed);
    }
}
