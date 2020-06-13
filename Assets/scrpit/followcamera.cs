using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera : MonoBehaviour
{
    public Transform Gracz;


	void FixedUpdate()
    {
        var targetPos = Gracz.transform.position + new Vector3(0, 1, -3);
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.1f);
       // transform.LookAt(Gracz.position + new Vector3(0, 1, 0));
    }

}

