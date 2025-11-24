using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uimanager : MonoBehaviour
 
{
    public Gamemanager gm;
    public Text scoretext ;
    public Image gameoverimage;
    public Button replaybutton;
    public Text highscoretext;
    public AudioClip gameoversound;
  
    private bool gameoverstarted;
    
    void Start()
    {
        gameoverimage.enabled = false;
        replaybutton.gameObject.SetActive(false);
        gameoverstarted = false;
    }

  
    void Update()
    {
        scoretext.text = "score:" + gm.score;
        if ((gm.gs==Gamemanager.gamestate.gameover)&&(!gameoverstarted))
        {
            StartCoroutine(actiergameoverui());
            gameoverstarted = true;



        }
       
            
                
      }
    public void Reloadscene()
    {
        SceneManager.LoadScene("SampleScene");
      
    }
    private IEnumerator actiergameoverui()
    {
        yield return new WaitForSeconds(2);
        gameoverimage.enabled = true;
        replaybutton.gameObject.SetActive(true);
        highscoretext.text = "highscore:" + PlayerPrefs.GetFloat("SampleScene");
        gm.GetComponent<AudioSource>().clip = gameoversound;
        gm.GetComponent<AudioSource>().loop = false;
        gm.GetComponent<AudioSource>().Play();

    }
}
