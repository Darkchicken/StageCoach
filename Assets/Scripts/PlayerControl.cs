using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public int health;
    //how far to move up and down to switch lanes
    private float laneWidth = 8;
    private float shootForce = 5;
    //distance a touch must move to be considered a swipe
    private float distanceForSwipe = 30;
    //should store lane player is currently in, assign to starting lane value
    //lanes are 1-5 going up
    private float currentLane = 3;

    GameObject playerBullet;

	// Use this for initialization
	void Start ()
    {
        playerBullet = Resources.Load("PlayerBullet") as GameObject;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //check if there are touches
        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            //if player swipes up
            if (touchDeltaPosition.y> distanceForSwipe)
            {
                if(currentLane < 5)
                {
                    //boolean is true for up, false for down
                    SwitchLanes(true);
                    currentLane++;
                }
            }
            //if player swipes down
            if (touchDeltaPosition.y < distanceForSwipe)
            {
                if (currentLane > 1)
                {
                    //boolean is true for up, false for down
                    SwitchLanes(false);
                    currentLane--;
                }
            }


        }
    }

    public void SwitchLanes(bool up)
    {
        //move player up
        if(up == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + laneWidth, transform.position.z);
        }
        else//move player down
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - laneWidth, transform.position.z);
        }
    }
    public void OnCollisionEnter(Collision col)
    {
        
    }
}
