using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    public Transform startposition;

    void spaw()
    {
        this.transform.position = new Vector3(startposition.position.x, startposition.position.y, startposition.position.z);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Death")
        {
            this.transform.position = new Vector3(startposition.position.x, startposition.position.y, startposition.position.z);

        }
    }


}
