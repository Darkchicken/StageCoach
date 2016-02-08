using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public int health;
    //how far to move up and down to switch lanes
    private float laneWidth = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Touch myTouch = Input.GetTouch(0);

        Touch[] myTouches = Input.touches;
        for (int i = 0; i < Input.touchCount; i++)
        {
            //Do something with the touches
        }
    }
}
