using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField] float cloudSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(deathToTheClouds());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - Time.deltaTime * cloudSpeed, transform.position.y);
    }

    IEnumerator deathToTheClouds()
    {
        yield return new WaitForSeconds(6);
        Destroy(gameObject);
    }
}
