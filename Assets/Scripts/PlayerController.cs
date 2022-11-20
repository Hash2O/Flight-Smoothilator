using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float rotationSpeed = 35.0f;
    private float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
            print("Engine starts, let's take a flight !");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //L'avion pivote autour de l'axe z
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * horizontalInput);

        //transform.Rotate(0, 0, rotationSpeed * Time.deltaTime * horizontalInput);

        // tilt the plane up/down based on up/down arrow keys 
        // (ici aussi, l'avion pivote-t-il autour de l'axe x, horizontal et perpendiculaire à z qui gère l'avant (forward))
        //transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        takeOff();
    }

    void takeOff() {
        if(verticalInput != 0){
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
            GetComponent<Rigidbody>().useGravity = false;
        }
        
    }
}
