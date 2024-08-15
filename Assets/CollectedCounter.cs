using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedCounter : MonoBehaviour
{
    public static int collected;
    public GameObject collectedText;

    // Update is called once per frame
    void Update()
    {
        collectedText.GetComponent<Text>().text = collected + "/3 Collected";
    }
}
