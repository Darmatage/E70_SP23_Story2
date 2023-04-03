using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene9Dialogue : MonoBehaviour {
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1;
	public GameObject ArtChar2;
	public GameObject ArtChar3;
	public GameObject ArtChar4;
    public GameObject ArtBG1;
	public GameObject ArtBG2;
	public GameObject ArtBG3;
    public GameObject NextScene1Button;
    public GameObject nextButton;
    //public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;
    public AudioSource audioBeep;


    // initial visibility settings. Any new images or buttons need to also be SetActive(false);
    void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
        NextScene1Button.SetActive(false);
        nextButton.SetActive(true);
        audioBeep.Play();
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
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "...";
            Char2speech.text = "You hurry through the ship, following H.O.R.I.Z.O.N.’s directions for the quickest path back.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt ==3){
            audioBeep.Play();
            ArtBG2.SetActive(true);
			ArtBG1.SetActive(false);
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "...";
            Char2speech.text = "Before you know it, you find yourself back in the generator room. It’s just as you left it.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 4){
			Char1name.text = "YOU";
            Char1speech.text = "Finally. This will all be over soon, just need to get this array slotted into the generator.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5){
			ArtChar1.SetActive(true);
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "...";
            Char2speech.text = "You approach the hulking machine.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 6){
            audioBeep.Play();
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "";
            Char1speech.text = "";
			Char2name.text = "...";
			Char2speech.text = "Unslinging the battery array, you heft it toward the empty ports. The batteries slot in with a solid click.";
			Char3name.text = "";
			Char3speech.text = "";
		}
        else if (primeInt == 7){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "...";
            Char2speech.text = "The error message is replaced with new text.";
            Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 8){
            Char1name.text = "YOU";
            Char1speech.text = "“Power cells detected. Press Start.”";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 9){
            Char1name.text = "YOU";
            Char1speech.text = "Simple enough.";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 10){
            ArtChar2.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "";
            Char1speech.text = "";
			Char2name.text = "...";
			Char2speech.text = "The machine immediately hums to life, electricity crackling across it for a moment as diagnostic text surges across its display.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 11){
			ArtBG3.SetActive(true);
			ArtBG2.SetActive(false);
			Char1name.text = "";
            Char1speech.text = "";
			Char2name.text = "...";
			Char2speech.text = "In the distance, you can hear the clank and whine of systems coming back online throughout the ship.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 12){
			ArtChar3.SetActive(false);
			ArtChar4.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Finally…";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 13){
            Char1name.text = "";
            Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "H.O.R.I.Z.O.N.";
			Char3speech.text = "Main power restored. Directive: Proceed to Bridge.";
		}
		else if (primeInt == 14){
            Char1name.text = "YOU";
            Char1speech.text = "You think it’s open now?";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 15){
            Char1name.text = "";
            Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "H.O.R.I.Z.O.N.";
			Char3speech.text = "Affirmative. Furthermore, the Primary Intelligence must be re-awakened, to return the Orpheus to its course.";
		}
		else if (primeInt == 16){
            ArtChar4.SetActive(false);
			Char1name.text = "YOU";
            Char1speech.text = "So we’re going home?";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 17){
            Char1name.text = "";
            Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "H.O.R.I.Z.O.N.";
			Char3speech.text = "Affirmative.";
		}
		else if (primeInt == 18){
			Char1name.text = "YOU";
            Char1speech.text = "Thank goodness… ";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(false);
            allowSpace = false;
			NextScene1Button.SetActive(true);
		}
   

    } // Closing brace for the next() function

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
//public void Choice1aFunct(){                                        //choice: go to bridge
       // Char1name.text = "YOU";
      //  Char1speech.text = "OK, let's go to the Bridge.";
      //  Char2name.text = "";
       // Char2speech.text = "";
       // Char3name.text = "";
       // Char3speech.text = "";
       // primeInt = 99;
       // Choice1a.SetActive(false);
       // Choice1b.SetActive(false);
       // nextButton.SetActive(true);
        //allowSpace = true;
   // }

   // public void Choice1bFunct(){
        //Char1name.text = "YOU";
       // Char1speech.text = "Maybe I'll just wait in here.";
       // Char2name.text = "";
       // Char2speech.text = "";
      //  Char3name.text = "";
      //  Char3speech.text = "";
      //  primeInt = 149;
      //  Choice1a.SetActive(false);
      //  Choice1b.SetActive(false);
      //  nextButton.SetActive(true);
      //  allowSpace = true;
   // }

    public void SceneChange1(){
        SceneManager.LoadScene("Scene10");
    }

   // public void SceneChange2(){
      //  SceneManager.LoadScene("Scene2b");
   // }
}
