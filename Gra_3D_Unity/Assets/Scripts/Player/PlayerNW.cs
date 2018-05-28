using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNW : MonoBehaviour
{

    public float speed = 6f;

    private Vector3 movement;
    private Rigidbody rb;
    private float camRayLenght = 100f;
    private int floorMask;
    private Animator anim;

    void Awake()
    {
        floorMask = LayerMask.GetMask("Floor");
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
    }

    void MovementManager(float h, float v);
    {
        if(h != 0 || v != 0)
    }
}
