using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jian : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 7);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0,5*Time.deltaTime,0);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag!= "Main Camera")
        {
            if (other.tag!="jian")
            {
                Destroy(this.gameObject);
            }
           
        }
        
    }
}
