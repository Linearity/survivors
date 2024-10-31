using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApproachAvatar : MonoBehaviour
{
    public GameObject avatar;
    public float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = avatar.transform.position - transform.position;
        diff.Normalize();
        transform.position += diff * moveSpeed * Time.deltaTime;
    }
}