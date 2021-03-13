using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMsg : MonoBehaviour
{
    private Text message;
    private float horizantalSpeed = 100;
    private float verticalSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        message = gameObject.GetComponent<Text>();
        message.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        int currentHealth = player.GetComponent<PlayerCharacter>().getHealth();

        if(currentHealth <= 0)
        {
            message.text = "You died :(";
        }

        this.transform.Translate(horizantalSpeed * Time.deltaTime, verticalSpeed * Time.deltaTime, 0);

        //Vector3 screenPosition = Camera.main.WorldToScreenPoint(this.transform.position);
        if (this.transform.position.x > Screen.width || this.transform.position.x < 0f)
        {
            horizantalSpeed *= -1f;
        }
        if (this.transform.position.y > Screen.height || this.transform.position.y < 0f)
        {
            verticalSpeed *= -1f;
        }

        }
    }
