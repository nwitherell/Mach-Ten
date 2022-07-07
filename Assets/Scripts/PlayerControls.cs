using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField]
    private int topSpeed;

    Rigidbody rb;
    Vector3 movement;
    private int currentSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     //  movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    }

    void FixedUpdate()
    {
      //  Driving(movement);
    }

    void Driving(Vector3 direction)
    {
       // direction = rb.rotation * direction;
        while (Input.GetKeyDown(KeyCode.W)){
            
            
            if (currentSpeed < topSpeed)
            {


              // rb.MovePosition(rb.position+direction*currentSpeed*Time.fixedDeltaTime);
                currentSpeed++;
                Debug.Log(getSpeed());
            }   
        }


    }


   public int getSpeed()
    {
        return currentSpeed;
    }

}
