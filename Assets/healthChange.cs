using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthChange : MonoBehaviour
{

    [SerializeField] private Text words;

    // Start is called before the first frame update
    void Start()
    {
    }

    void  Update()
    {
        GameObject player = GameObject.Find("Player");
        int currentHealth = player.GetComponent<PlayerCharacter>().getHealth();
        if (player != null)
        {
            words.text = "Health: " + currentHealth;
            for (int i = 0; i < currentHealth; i++)
            {
                words.text += "*";
            }
            //words.transform.position = new Vector3(325, 325, 300)
        }
    }

        // Update is called once per frame
 
}
