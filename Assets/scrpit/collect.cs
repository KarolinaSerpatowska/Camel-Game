using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collect : MonoBehaviour {

    public static int number = 0;
    void Start()
    {
        number = 0;
    }
void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        number = number + 1;
        if (number == 8)
        {
            Debug.Log("Zebrales wszystkie wiadra :)");
            SceneManager.LoadScene(2);
            
        }

    }
}
