using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    { 
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");
            CollectedCounter.collected = 0;
        }
        
    }
}
