using UnityEngine;
using System.Collections;

public class LaneSpawn : MonoBehaviour {

    //spawn every x seconds
    private float spawnSpeed = 2;
    GameObject laneObject;

	// Use this for initialization
	void Start ()
    {
        //InvokeRepeating("SpawnLane", 0, spawnSpeed);
        //get lane gameobject from resources folder
        //laneObject = Resources.Load("Lane") as GameObject;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
    void SpawnLane()
    {
        laneObject.transform.position = this.transform.position;
    }
}
