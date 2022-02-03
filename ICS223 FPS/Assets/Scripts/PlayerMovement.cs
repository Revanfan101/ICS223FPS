using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbody;

    private float speed = 10.0f;
    //private float force = 250f;
    float horizInput ;
    float vertInput;

    private void Start()
    {
        rbody = GetComponent < Rigidbody>();
    }
    private void Update()
    {
        horizInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {

        Vector3 movement = new Vector3(vertInput, 0, horizInput) * speed * 100 *  Time.deltaTime; // * 100 to convert to newtons
        //rbody.AddForce(movement);
        rbody.velocity = movement;
        //rbody.MovePosition(transform.position + movement);
    }
    //public float speed = 10f;
    //// Update is called once per frame
    //private void Update()
    //{
    //    float horizInput = Input.GetAxis("Horizontal");
    //    float vertInput = Input.GetAxis("Vertical");
    //    Vector3 movement = new Vector3(vertInput, 0, horizInput) * speed * Time.deltaTime;

    //    transform.Translate(movement);
    //}
}
