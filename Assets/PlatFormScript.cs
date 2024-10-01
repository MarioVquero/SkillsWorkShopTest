using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormScript : MonoBehaviour
{
    public Vector3 MoveSpeed;
    public Vector3 OtherSpeed;
    public Vector3 resetSpeed;
    public Rigidbody rb;

    public bool Direction;
    // Start is called before the first frame update
    void Start()
    {
        Direction = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Direction = !Direction;

        if (Direction == true)
        {
            rb.AddForce(MoveSpeed);
        }
        else if (Direction == false)
        {
            
            rb.AddForce(OtherSpeed);

        }
    }
}
