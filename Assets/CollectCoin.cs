using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    public int collected = 0;
    public GameObject collectedText;

    private void OnTriggerEnter(Collider other)
    {
        CollectedCounter.collected++;
        Destroy(gameObject);
    }
}
