using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 35.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Ecouter les fleches du clavier pour modifier la trajectoire
        horizontalInput = Input.GetAxis("Horizontal"); 
        forwardInput = Input.GetAxis("Vertical");

        //To better control speed, write something like this
        //Time.deltaTime permet de gerer la vitesse en seconde (1m/sec), et non sur le cpu, qui varie
        //on multiplie par * 20 pour donner une vitesse de 20 m/sec ici
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //To turn left and right, with horizontalInput variable to gain control of the vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
