using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30f;
    private float turnSpeed = 30f;
    private float horizontalInput, verticalInput;
    private void Update()
    {
        // Detectar el input Horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        //Detectar el input Vertical
        verticalInput = Input.GetAxis("Vertical");

        // movimiento hacia adelante brusco
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);  //velocidad y tiempo

        // Movimiento lateral manual:
        /*
         transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        */

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);


    }
}
