using UnityEngine;
using System.Collections;


public class Shoot : MonoBehaviour
{

    public Rigidbody bullet;

    
    void Update() //update - strzelanie w każdej chwili
    {
        if (Input.GetButtonDown("Fire1")) //pocisk wyleci kiedy naciśniemy lewy "ctrl"
        {
            Rigidbody clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody; //pozycja i rotacja obiektu
            Vector3 fwd = transform.TransformDirection(Vector3.forward);                                //wektor przesunięcia skierowany do przodu
            clone.AddForce(fwd * 1500f); //przekazanie energii obiektowi
        }
    }
}
