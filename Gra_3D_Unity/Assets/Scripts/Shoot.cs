using UnityEngine;
using System.Collections;


public class Shoot : MonoBehaviour
{

    public Rigidbody bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            clone.AddForce(fwd * 1500f);
        }
    }
}
