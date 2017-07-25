using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float velocity = 0.4F;
    Vector3 positionI;

	// Use this for initialization
	void Start () {
        positionI = this.transform.position;
	}

    public void Reset() {
        this.transform.position = positionI;
    }

	// Update is called once per frame
	void Update () {
        float inputH = Input.GetAxisRaw("Horizontal");
        float posX = Mathf.Clamp(this.transform.position.x + (inputH * velocity * Time.deltaTime), -7.5F, 7.5F);

        this.transform.position = new Vector3(posX, this.transform.position.y, this.transform.position.z);
	}
}
