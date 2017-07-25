using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public float initialForce = 600F;
    Rigidbody rb;
    bool gameStarted = false;
    Vector3 positionI;
    public Transform playerT;

    // Use this for initialization
    void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        positionI = this.transform.position;
    }

    public void Reset()
    {
        this.transform.position = positionI;
        this.transform.SetParent(playerT);
        gameStarted = false;
        stopBall();
    }

    //This works
    public void stopBall()
    {
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted && Input.GetButtonDown("Fire1"))
        {
            gameStarted = true;
            this.transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector3(initialForce, initialForce, 0));
        }
    }
}
//END