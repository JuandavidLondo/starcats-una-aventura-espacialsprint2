using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidascont : MonoBehaviour
{
    public Image vidasimagen;
    public Image Panel;
    private GameObject player, obstaculo;
    public int Vidas;
    public playercontroler Vidava;
    public float vidasspeed;

    // Start is called before the first frame update
    void Start()
    {
        Panel = GameObject.Find("Panel").GetComponent<Image>();
        vidasimagen = GameObject.Find("Vida").GetComponent<Image>();
        Vidas = Vidava.life;

    }

    // Update is called once per frame
    void Update()
    {
        
        vidasimagen.transform.position += new Vector3(vidasspeed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown("q"))
        {
            Panel.sprite = Resources.Load<Sprite>("Sprites/tres_Vidas");
            vidasimagen.sprite = Resources.Load<Sprite>("Sprites/tres_Vidas");
        }
        if (Vidas == 2)
        {
            vidasimagen.sprite = Resources.Load<Sprite>("Sprites/dos vidas");
        }
        if (Vidas == 1)
        {
            vidasimagen.sprite = Resources.Load<Sprite>("Sprites/1 vida");
        }
    }

    
}
