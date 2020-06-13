using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{


    void OnCollisionEnter(Collision other)
    {
        
     //   print("enter");
        if (other.gameObject.tag == "Player")
        {
            other.transform.SetParent(transform);

        }
    }

    void OnCollisionExit(Collision other)
    {
        
      //  print("exit");
        if (other.gameObject.tag == "Player")
        {
            other.transform.SetParent(null, true);    

        }
    }
}