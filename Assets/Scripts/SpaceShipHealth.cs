using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpaceShipHealth : MonoBehaviour
{
    public float MAX_HEALTH = 100;
    public float currHealth;
    GameObject gameManager;
    public GameObject healthBar;
    Image healthBarImg;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("Game Manager");
        currHealth = MAX_HEALTH;
        healthBarImg = healthBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.transform.localScale =
            new Vector3((currHealth) / MAX_HEALTH, 1.0f, 1.0f);
        healthBarImg.color = Color.Lerp(Color.red, Color.green, currHealth / MAX_HEALTH);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            currHealth -= 10;
            if (currHealth <= 0.0f)
                gameManager.SendMessage("GotoGameOver");
        }
    }
}
