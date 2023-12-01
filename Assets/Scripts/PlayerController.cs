using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [Range(1f, 10.0f)]
    public float playerSpeed = 5f;

    [Range(1f, 3f)]
    public int playerLife = 2;

    public Image playerImage;
    public Image swordImage;

    private float clamp = 0f;
    private Color newColor = new Color(0f, 0f, 0f, 0f);

    void Update()
    {
        if (playerLife <= 0)
        {
            clamp = Time.deltaTime * 1.2f;
            playerImage.color = Color.Lerp(playerImage.color, newColor, clamp);
            swordImage.color = Color.Lerp(swordImage.color, newColor, clamp);
            return;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * playerSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * playerSpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Enemy(Clone)")
        {
            playerLife = 0;
            // gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

    public IEnumerator ImortalityAfterHit()
    {
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(10);
        GetComponent<Collider2D>().enabled = true;
    }

    public void damagePlayer()
    {
        playerLife--;
    }

    public int getLife()
    {
        return playerLife;
    }

    public void healPlayer()
    {
        if (playerLife < 3)
        {
            playerLife++;
        }
    }

}
