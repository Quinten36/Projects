using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float playerMoveSpeed = 11;
    private float bounderyRange = 15;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.x < -bounderyRange)
        {
            transform.position = new Vector3(-bounderyRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > bounderyRange)
        {
            transform.position = new Vector3(bounderyRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        transform.Translate(Vector3.right * Time.deltaTime * playerMoveSpeed * horizontalInput);
    }
}
