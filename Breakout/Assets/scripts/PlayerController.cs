using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5f;
    private float horizontalInput;
    public float bounderyRange = 15;
    public GameObject ball;

    public GameController gameController;
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
        transform.Translate(Vector3.down * Time.deltaTime * playerSpeed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 pos = transform.position;
            pos.y += .35f;
            Instantiate(ball, pos, ball.transform.rotation);

            gameController.gameStarted = true;
        }
}
}
