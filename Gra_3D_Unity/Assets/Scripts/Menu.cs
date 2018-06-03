/*using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
    public Texture GameLogo;
    public float buttonWidth = 300;
    public float buttonHeight = 60;
    public GUISkin skin;

    private float buttonMargin = 20;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        GUI.skin = skin;
        GUI.DrawTexture(new Rect(0, 0, 800, 300), GameLogo);

        if (GUI.Button(new Rect(300, 300, buttonWidth, buttonHeight), "Nowa Gra"))
        {
            Application.LoadLevel("Level 1");
        }
        if (GUI.Button(new Rect(300, 300 + buttonHeight + buttonMargin, buttonWidth, buttonHeight), "Opcje"))
        {

        }
        if (GUI.Button(new Rect(300, 300 + (buttonHeight + buttonMargin) * 2, buttonWidth, buttonHeight), "Wyjście"))
        {
            Application.Quit();
        }

    }
}