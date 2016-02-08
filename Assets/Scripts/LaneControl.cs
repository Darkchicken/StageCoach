using UnityEngine;
using System.Collections;

public class LaneControl : MonoBehaviour {
    
    private float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //move left constantly
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);
    }
}
