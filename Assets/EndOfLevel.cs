using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Material canWin;
    [SerializeField] private Renderer rend;
    // Update is called once per frame
    //void Update()
    //{}

    void Update()
    {
        if (CollectedCounter.collected == 3)
        {
            rend.material = canWin;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if(CollectedCounter.collected == 3)
        {
            player.transform.position = respawnPoint.transform.position;
            rend.material = canWin;
        }
        else
        {
            SceneManager.LoadScene("SampleScene");
            CollectedCounter.collected = 0;
        }
    }
}
