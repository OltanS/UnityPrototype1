using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new(20f, 0f , 0f);
    private Vector3 beginningRotation = new(0, -90, 0);

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(beginningRotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
