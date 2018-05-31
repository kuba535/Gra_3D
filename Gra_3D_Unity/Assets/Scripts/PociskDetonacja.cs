/*using UnityEngine;
using System.Collections;

//Zadawanie obrażeń przez pocisk np. rakietę
//pocisk lecący
public class PociskDetonacja : MonoBehaviour {

    //Animacja przy uderzeniu
    public GameObject uderzeniePrefab;


    //Obrażenie jakie zadaje
    //(ile hp zabiera)
    public float obrazenia = 200f;

    //Zasięg eksplozji

    public float zasiegEksplozji = 3f;

    void OnTriggerEnter()
    {

        Debug.Log("OnTriggerEnter");
        Detonacja();


    }

    void Detonacja()
    {
        Vector3 punktDetonacji = transform.position;
        

        if(uderzeniePrefab != null)
        {
            Instantiate(uderzeniePrefab, punktDetonacji, Quaternion.identity);






        }


        Destroy(gameObject);

        //pobieram
        //obiekty w polu rażenia
        //cel- zadanie im obrażeń
        Collider[] colliders = Physics.OverlapSphere(punktDetonacji, zasiegEksplozji);

        //Iteracja w celu sprawdzenia, czy obiekt znajdujący się w polu rażeniazawiera punkty zdrowie

        foreach(Collider c in colliders)
        {
            Zdrowie h = c.GetComponent<Zdrowie>();

            if(h !=null)
            {
                float dist = Vector3.Distance(punktDetonacji, c.transform.position);
                //Obliczanie obrażeń zgodnie z odstępem od pocisku
                //Bliższe dostają więcej niż dalsze
                float noweObrażenia = 1f - (dist / zasiegElsplozji);
                h.otrzymaneObrażenia(obrażenia * noweObrażenia);

            }




        }

    }
}

public class Class1
{
	public Class1()
	{
	}
}
*/