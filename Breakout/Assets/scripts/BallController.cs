using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float angle;
    public float speed = .7f;
    public bool busyColliding = false;
    public bool traveling = false;
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

    private float res;

    // Start is called before the first frame update
    void Start()
    {
        //float r = Random.Range(-40, 40);
        //angle = Mathf.Clamp(r, -40, 40);
        angle = transform.rotation.z;
        //Debug.Log(r);
        //Debug.Log(angle);
        //transform.Rotate(new Vector3(0, 0, angle), Space.World);
        transform.Rotate(new Vector3(0, 0, angle), Space.World);
        traveling = true;
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.AddForce(transform.up * m_Thrust * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (!busyColliding && other.tag != "BackGround") {
            busyColliding = true;

            Debug.Log("Bounce");
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;

            if (other.tag == "WallTop") {
                
                if (angle > 0)
                {
                    res += 90;
                }
                
            }
        }



        leaveTrigger();
    }

    private void leaveTrigger()
    {
        Debug.Log("Reach");
        //m_Rigidbody.AddForce(transform.up * -m_Thrust * Time.deltaTime);
        m_Rigidbody.constraints = RigidbodyConstraints.None;
        //busyColliding = false;
        //transform.Rotate(, Space.World);
        m_Rigidbody.AddTorque(transform.forward * 15 * 1);
        //m_Rigidbody.AddForce(transform.up * m_Thrust * Time.deltaTime);
        //angle = res;
    }
}

/*chaos mode*/
/*
Debug.Log("Bounce");
Vector3 targetDir = other.transform.position - transform.position;
float angleBetween = Vector3.Angle(transform.forward, targetDir);
Debug.Log(angleBetween);
transform.Rotate(new Vector3(0, 0, angle + angleBetween + 45), Space.World);
*/
/*
if (angle < 0)
{
    posAngle = angle * 1;
    resBeforeReflect = 90 - posAngle;
    resBeforeReflect *= 1;
}
else
{
    posAngle = angle * -1;
    resBeforeReflect = 90 - posAngle;
    resBeforeReflect *= -1;
}
*/



/*
        if (!busyColliding) 
        {
            transform.Translate(transform.up * Time.deltaTime * speed);
        }
        */


/*
        Vector3 targetDir = other.transform.position - transform.position;
        float angleBetween = Vector3.Angle(transform.forward, targetDir);
        Debug.Log(angleBetween);
        transform.Rotate(new Vector3(0, 0, angle+ angleBetween+45), Space.World);
        */


/*
 float resBeforeReflect = angle;
            float temp = 0;

            if (other.tag == "WallLeft")
            {
                //if (angle > 90) {
                Debug.Log("Left");
                resBeforeReflect *= 2;
                resBeforeReflect *= -1;
                Debug.Log(resBeforeReflect);
                //}
            } else if (other.tag == "WallRight")
            {
                //if (angle > 90) {
                Debug.Log("Right");
                //resBeforeReflect /= 2;
                resBeforeReflect *= -1;
                Debug.Log(resBeforeReflect);
                //}
            }
            else 
            {
                /*
                if (angle < 0)
                {
                    temp = 90 - (angle * -1);
                    resBeforeReflect += temp;
                }
                else
                {
                    temp = 90 - angle;
                    resBeforeReflect -= temp;
                }
                */
                //angle = current angle of approice
                //temp = to make the 90 hoek complete

                //float reflectAngle = posAngle + posAngle + resBeforeReflect;
                /*
            }





            Debug.Log(resBeforeReflect);

transform.Rotate(new Vector3(0, 0, resBeforeReflect), Space.World);
angle = resBeforeReflect;
busyColliding = false;
*/