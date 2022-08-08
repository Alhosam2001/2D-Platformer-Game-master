using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Image4 : MonoBehaviour
{
    public GameObject Image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Tomato4.isCollected4)
        {
            Image.GetComponent<Image>().color = Color.white;
        }
    }
}
