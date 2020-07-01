using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusKiller : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Cactus(Clone)")
        {
            new WaitForSecondsRealtime(0.5f);
            Destroy(collision.gameObject);
        }
    }
}
