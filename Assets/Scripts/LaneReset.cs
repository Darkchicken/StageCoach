using UnityEngine;
using System.Collections;

public class LaneReset : MonoBehaviour {

    GameObject laneSpawn;
	// Use this for initialization
	void Start ()
    {
        //get parent object
        laneSpawn = transform.parent.gameObject;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("ow");
        if(col.name == "Lane")
        {
            col.transform.position = laneSpawn.transform.position;
        }
    }
}
