using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5aDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

     // Find the gameHandler:
     // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       next();
                }
        }
   }

//Story Units! This is the main story function. Players hit [NEXT] to progress to the next primeInt:
public void next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I don't know about this.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "There is a battery located inside the Air Lock.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "OK, I see it. Let's get it and get out of here.";
                Char2name.text = "";
                Char2speech.text = "";
        }
				//Door Slam noise here
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "No! Open the door!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "Door control unavailable.";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "How do I open it?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		       else if (primeInt ==8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "The door appears to have been locked.
				There is a member of the crew on the other side.";
        }
		       else if (primeInt ==9){
                Char1name.text = "YOU";
                Char1speech.text = "Hey! Let me out!";
                Char2name.text = "";
                Char2speech.text = "";
        }
				//Alarm noise here
		       else if (primeInt ==10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "The crewmember appears to be intent on neutralizing you.";
		}
		       else if (primeInt ==11){
                Char1name.text = "YOU";
                Char1speech.text = "What does that mean?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		       else if (primeInt ==12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "The Air Lock is going to open.
				You will not survive.";
		}

        public void SceneChange1(){
               SceneManager.LoadScene("Scene_Lose");

        }
}