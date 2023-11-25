using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Top : MonoBehaviour
{
    private static Rigidbody2D fzk;
    public TextMeshProUGUI skorYazi,highskorYazi;
    private int skor,highskor;
    
    private SpriteRenderer renk;

    public Color renk1,renk2,renk3,renk4,renk5,renk6;

    void Start()
    {
        fzk = gameObject.GetComponent<Rigidbody2D>();
        renk = gameObject.GetComponent<SpriteRenderer>();

        if(PlayerPrefs.HasKey("HighScore"))
        {
           highskor = PlayerPrefs.GetInt("HighScore");
           highskorYazi.text = "HighScore = "+highskor;
        }
        else
        {
            highskor = 0;
        }
        
        
    }
    private void OnCollisionEnter2D(Collision2D temas) {
        if(temas.gameObject.tag == "Kenar")
        {
            fzk.velocity = new Vector2 (fzk.velocity.x,7.5f);
            GetComponent<AudioSource>().Play();
            
            if(renk.color != temas.gameObject.GetComponent<SpriteRenderer>().color)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                skor++;
        if(skor > highskor)
        {
                highskor = skor;
                highskorYazi.text = "Highscore = "+highskor.ToString();
                PlayerPrefs.SetInt("HighScore",highskor);
        }
            }
        }
        if(temas.gameObject.tag == "Anakenar")
        {
            fzk.velocity = new Vector2 (fzk.velocity.x,4f);
        }
    }
    private void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag == "RenkDegistirici")
        {
            int Rastgelesayi = Random.Range(1,7);
            switch(Rastgelesayi)
            {
            case 1:
            renk.color = renk1;
            break;
            case 2:
            renk.color = renk2;
            break;
            case 3:
            renk.color = renk3;
            break;
            case 4:
            renk.color = renk4;
            break;
            case 5:
            renk.color = renk5;
            break;
            case 6:
            renk.color = renk6;
            break;
            }
        }
    }
    void Update()
    {
        skorYazi.text = "Score = "+skor;
    }

}
