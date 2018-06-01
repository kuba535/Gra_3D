/*using UnityEngine;
using System.Collections;

public class Pauza : MonoBehaviour
{
    private bool pauza = false;



    // Use this for initialization
    void Start()
    {
        Screen.lockCursor = true;
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown("escape"))
        {
            //ustawia czas na 0, blokuje ekran gry (screen)
            pauza = true;
            Time.timeScale = 0;
            Screen.lockCursor = false;
        }
    }

    //Włącza skórkę GUI
    void OnGUI()
    {
        if (pauza)
        {
            //pokazuje ramkę o nazwie Menu gry
            GUI.Box(new Rect(Screen.width / 2 - 50, 60, 100, 270), "PAUSE");

            //wyświetla przycisk Kontynuuj, który przywraca czas i ekran gry
            if (GUI.Button(new Rect(Screen.width / 2 - 40, 100, 80, 30), "Kontynuuj"))
            {
                pauza = false;
                Time.timeScale = 1;
                Screen.lockCursor = true;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 40, 140, 80, 30), "Save"))
            {
                PlayerPrefs.SetFloat("zycia", Hellion.zycia); //zapis życia
                PlayerPrefs.SetFloat("punkty", Hellion.punkty); //zapis punktow
                PlayerPrefs.SetFloat("proba", Hellion.proba);
                PlayerPrefs.SetFloat("waluta", Hellion.waluta);
                PlayerPrefs.SetInt("aktualnyLewel", Menu.aktualnyLewel);
                pauza = false;
                Time.timeScale = 1;
                Screen.lockCursor = true;
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 40, 180, 80, 30), "Load"))
            {
                Hellion.zycia = PlayerPrefs.GetFloat("zycia"); //wczytanie życia
                Hellion.punkty = PlayerPrefs.GetFloat("punkty"); //wczytanie punktow
                Hellion.proba = PlayerPrefs.GetFloat("proba");
                Hellion.waluta = PlayerPrefs.GetFloat("waluta");
                Menu.aktualnyLewel = PlayerPrefs.GetInt("aktualnyLewel");
                Application.LoadLevel(Menu.aktualnyLewel);
                pauza = false;
                Time.timeScale = 1;
                Screen.lockCursor = true;
            }

            //wyświetla przycisk Menu, który przechodzi do sceny o indeksie 1
            if (GUI.Button(new Rect(Screen.width / 2 - 40, 220, 80, 30), "Menu"))
            {
                Time.timeScale = 1; Hellion.proba = 3; Hellion.zycia = 100; Hellion.punkty = 0; pauza = false;
                //Screen.lockCursor = true;
                Application.LoadLevel(0);


            }

            //pokazuje przycisk Koniec, który wyłącza grę.
            if (GUI.Button(new Rect(Screen.width / 2 - 40, 260, 80, 30), "Koniec"))
            {
                Application.Quit();
            }

        }
    }

}

