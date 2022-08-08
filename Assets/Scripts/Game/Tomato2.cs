using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato2 : MonoBehaviour
{
    public static bool isCollected2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isCollected2 = true;
        Destroy(gameObject);
    }
}
