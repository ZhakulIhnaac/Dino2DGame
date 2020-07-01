using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactus : MonoBehaviour
{
    [SerializeField] float cactusSpeed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - Time.deltaTime * cactusSpeed, transform.position.y);
    }
}
