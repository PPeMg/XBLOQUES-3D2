using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {
    public Points p;

    void OnTriggerEnter()
    {
        //Debug.Log("Choca. Vidas:" + Points.getLives());
        p.reduceLives();
    }
}
