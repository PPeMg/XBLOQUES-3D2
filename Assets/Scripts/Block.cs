using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
    public Points p;
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision) {
        Instantiate(explosion, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        p.addPoints();
    }
}
