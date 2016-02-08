using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public int health;
    //how far to move up and down to switch lanes
    private float laneWidth = 8;
    private float shootForce = 5;

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
        if (Input.touchCount > 0)
        {
            //if so, cycle through the touches
            for (int i = 0; i < Input.touchCount; ++i)
            {
                Touch touch;
                touch = Input.GetTouch(i);
                if (touch.phase == TouchPhase.Began)
                {
                    GameObject bullet;
                    bullet = (GameObject)Instantiate(playerBullet, transform.position, transform.rotation);

                    // Add force to the cloned object in the object's forward direction
                    bullet.GetComponent<Rigidbody>().AddForce(touch.position * shootForce);
                }
                if (touch.phase == TouchPhase.Moved)
                {

                }
                else if (touch.phase == TouchPhase.Ended)
                {

                }
            }
        }
    }

    public void OnCollisionEnter(Collision col)
    {
        
    }
}
