using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Vector3 direction = Vector3.right;
    Vector3 velocity;
    RaycastHit2D hit;
    float speed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = direction * speed * Time.deltaTime;
        transform.position += velocity;

        if (hit.collider != null)
        {
            Destroy(hit.collider.gameObject);
            Destroy(gameObject);
        }
    }
    public Vector3 Direction
    {
        get { return direction; }
        set { direction = value; }
    }
}
