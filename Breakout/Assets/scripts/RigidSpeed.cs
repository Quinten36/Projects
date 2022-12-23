using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidSpeed : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        m_Rigidbody.AddForce(new Vector3(-0.5f, 0.5f, 0));
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(new Vector3(-5,5,0));
        }
    }
}
