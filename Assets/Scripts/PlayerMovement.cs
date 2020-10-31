using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 200f;
    public float sidewaysForce = 100f;

    void FixedUpdate()
    {
        rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey(KeyCode.RightArrow)) {
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0);
		}

		// if (rb.position.y < -1f) {
		// 	FindObjectOfType<GameManager> ().EndGame ();
		// }
    }
}
