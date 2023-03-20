using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Paralax : MonoBehaviour
{
    [SerializeField] private Transform followingTarget;
    [SerializeField, Range(0f,1f)] float ParallaxScloling;
    [SerializeField] bool Disebel;
    private Vector3 TargetPosition; 
    // Start is called before the first frame update
    void Start()
    {
        if(!followingTarget) 
            followingTarget = Camera.main.transform;
        TargetPosition = followingTarget.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        var Delta = followingTarget.position - TargetPosition;

        if (Disebel)
            Delta.y = 0;

        TargetPosition = followingTarget.position;

        transform.position += Delta * ParallaxScloling;
    }
}
