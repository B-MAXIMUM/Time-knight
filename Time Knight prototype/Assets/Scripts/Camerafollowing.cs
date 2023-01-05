using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollowing : MonoBehaviour
{
    public Transform ObjectToFollow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3( ObjectToFollow.position.x, ObjectToFollow.position.y, transform.position.z);
    }
}
