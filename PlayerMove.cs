using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour{
    //this script is fine as well
    //Checks if WASD was pressed and moves in that direction
    public int sped;
    public Rigidbody rb;
    public float gravity;
    void FixedUpdate()
    {
        //rb.AddForce(Vector3.down * gravity * rb.mass);
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sped * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -(sped * Time.deltaTime));
        }

        if (Input.GetKey("s"))
        {

            rb.AddForce(-(sped * Time.deltaTime), 0, 0);
        }

        if (Input.GetKey("w"))
        {

            rb.AddForce(sped * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("space"))
        {

            rb.velocity = new Vector3(0, 0, 0);
            //rb.AddForce(950 * Time.deltaTime, 0, 0);
        }
    }
}
