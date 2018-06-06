//using UnityEngine;
//using System.Collections;

///*
//public class Shoot : MonoBehaviour
//{

//    public Rigidbody bullet;

    
//    void Update() //update - strzelanie w każdej chwili
//    {
//        if (Input.GetButtonDown("Fire1")) //pocisk wyleci kiedy naciśniemy lewy "ctrl"
//        {
//            Rigidbody clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody; //pozycja i rotacja obiektu
//            Vector3 fwd = transform.TransformDirection(Vector3.forward);                                //wektor przesunięcia skierowany do przodu
//            clone.AddForce(fwd * 1500f); //przekazanie energii obiektowi
//        }
//    }
//}
//*/
//public class Shoot : MonoBehaviour
//{
//    //Zasięg naszego strzału
//    public float zasieg = 100.0f;
//    //co  ile można strzelac
//    public float czekaj = 2f;
//    //Odliczanie do kolejnego strzału
//    public float odliczanieDoStrzalu = 0f;

//    //Objekt pocisku
//    public GameObject pociskPrefab;
//    //Obrazenia zadawane przez strzał, to jest ilość odebranego zdrowia
//    public float obrazenia = 50.0f;
//    void Start()
//    {

//    }

//    //Update wołany raz na frame'a
//    void Update()
//    {
//        //Zmniejszanie licznika do kolejnego strzału(odliczanie do strzału)
//        if(odliczanieDoStrzalu < czekaj)
//        {
//            odlicznieDoStrzalu += Time.deltaTime;
//        }

//        //Strzał następuje, jeżeli nacisniemy przycisk myszy i odliczanie jest mniejsze od zera
//        if(Input.GetMouseButton(0) && odliczanieDoStrzalu >= czekaj)
//        {
//            //Strzał oddano, ustawiamy nowe odliczanie
//            odliczanieDoStrzalu = 0;
            
//            //Ray pozwala na pobranie kierunku w którym skierowana jest kamera

//             Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward)
//             //Pobranie infora=macji gdzie strzeliliśmy
//             RaycastHit hitInfo;

//            //sprawdzenie, czy promień w coś trafił
//            if(Physics.Raycast(ray, out hitInfo, zasieg))
//            {
//                //pobranie informacji o trafionym obiekcie
//                Vector3 hitPoint = hitInfo.point;
//                //Pobranie trafionego obiektu
//                GameObject go = hitInfo.collider.gameObject;
                

//                hitInfo(go);

//                if(pociskPrefab != null)//Czy mamy przypisany obiekt pocisku
//                {

//                    Instantiate(pociskPrefab, hitPoint, Quaternion.identity);


//                }



//            }

//        }


//    }
//    //Funkcja odpowiedzialna za zmniejszanie zdrowia przeciwnika
//    void hit(GameObject go)
//    {
//        //Zadawanie obrazen obiektowi
//        //Pobranie atrybutow zdrowia obiektu atakowanego
//        EnemyHealth health = go.GetComponent<EnemyHealth>();
//        //sprawdzanie, czy nasz element ma zdrowie
//        if(zdrowie != null)
//        {
//            //zadaj obrażenia
//            health.getDamage(damage);
//        }



//    }


//}
//// Jest to na razie najbardziej podstawowa metoda wystrzału,
//// pociskiem może być cokolwiek. W dalszej wersji kule będą leciały w stronę która zostanie wskazana.
//// Dalej trzeba ogarnąć kolizje i inne ważne rzeczy typu zadawanie obrażeń przez kulę.

