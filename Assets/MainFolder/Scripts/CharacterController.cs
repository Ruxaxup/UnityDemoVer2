using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
    public float _ySpeed;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, _ySpeed, 0, ForceMode.Impulse);
        }
	}
}
