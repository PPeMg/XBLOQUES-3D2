using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
    public Points p;

    private void OnCollisionEnter(Collision collision) {
        Destroy(this.gameObject);
        p.addPoints();
    }
}
