
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public GameObject target;

    



    private float offset = 50f;

    public float SmoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position - target.transform.forward * offset;
        transform.LookAt(target.transform.position);
        transform.position = new Vector3(transform.position.x, transform.position.y + 15, transform.position.z );
    }
}
