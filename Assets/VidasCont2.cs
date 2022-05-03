using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidasCont2 : MonoBehaviour
{
    
    public GameObject tresvidaspanel, dosvidaspanel, unavidapanel,tresvidas,dosvidas,unavida;
    public playercontroler player;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        tresvidaspanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        tresvidaspanel.transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
        unavidapanel.transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
        dosvidaspanel.transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
        
        if (player.life == 2)
        {
            tresvidaspanel.SetActive(false);
            dosvidaspanel.SetActive(true);
        }
        else if (player.life == 1)
        {
            dosvidaspanel.SetActive(false);
            unavidapanel.SetActive(true);
        }
        else if(player.life == 0)
        {
            unavidapanel.SetActive(false);
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
