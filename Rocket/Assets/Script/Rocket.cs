using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    public Rigidbody rocketRigidBody;
    [SerializeField] public float Jump = 150;
    [SerializeField] public float Horizontal = 3;
    // Use this for initialization
    void Start () {
        rocketRigidBody = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Jump") > 0)
        {
            rocketRigidBody.AddForce(new Vector3(0, Jump, 0));
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            rocketRigidBody.AddForceAtPosition(new Vector3(Horizontal, 0, 0), new Vector3(2, 0, 0));
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            rocketRigidBody.AddForceAtPosition(new Vector3(-Horizontal, 0, 0), new Vector3(2, 0, 0));
        }
    }
}
