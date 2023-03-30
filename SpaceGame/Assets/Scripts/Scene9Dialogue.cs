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
    //public GameObject ArtChar1b;
    //public GameObject ArtChar2;
    public GameObject ArtBG1;
    public GameObject Choice1a;	// go to bridge
    public GameObject Choice1b;	// remain in generator room
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
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "H.O.R.I.Z.O.N.";
            Char3speech.text = "Please reassemble the battery array.";
        }
        else if (primeInt ==3){
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "H.O.R.I.Z.O.N.";
            Char3speech.text = "Attach the three batteries and reinstall.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4){
            Char1name.text = "YOU";
            Char1speech.text = "OK, here goes nothing.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name
.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The generator powers on.";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
               Char1name.text = "YOU";
                Char1speech.text = "Hey, it worked!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "With the power restored, the Bridge is now accessible.";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Please proceed to the Bridge to reboot the computer.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		
else if (primeInt == 150){
Char1name.text = "";
Char1speech.text = "";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "H.O.R.I.Z.O.N.";
Char3speech.text = "Please proceed to the Bridge to reboot the computer.";
// Turn off "Next" button, turn on "Choice" buttons
nextButton.SetActive(false);
allowSpace = false;
Choice1a.SetActive(true); // function Choice1aFunct()
Choice1b.SetActive(true); // function Choice1bFunct()
}

// ENCOUNTER AFTER CHOICE #1
else if (primeInt == 100){
Char1name.text = "";
Char1speech.text = "";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";

}
else if (primeInt == 101){
Char1name.text = "";
Char1speech.text = "";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
nextButton.SetActive(false);
allowSpace = false;
NextScene1Button.SetActive(true);
}

else if (primeInt == 200){
Char1name.text = "";
Char1speech.text = "";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
}
else if (primeInt == 201){
Char1name.text = "";
Char1speech.text = "";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
nextButton.SetActive(false);
allowSpace = false;
NextScene2Button.SetActive(true);
}

// Closing brace for the Scene9Dialogue class
}
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
public void Choice1aFunct(){
Char1name.text = "YOU";
Char1speech.text = "OK, let's go to the Bridge.";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
primeInt = 99;
Choice1a.SetActive(false);
Choice1b.SetActive(false);
nextButton.SetActive(true);
allowSpace = true;
}

public void Choice1bFunct(){
    Char1name.text = "YOU";
    Char1speech.text = "Maybe I'll just wait in here.";
    Char2name.text = "";
    Char2speech.text = "";
    Char3name.text = "";
    Char3speech.text = "";
    primeInt = 149;
    Choice1a.SetActive(false);
    Choice1b.SetActive(false);
    nextButton.SetActive(true);
    allowSpace = true;



		else if (primeInt == 100)
  void SceneChange1(){
       SceneManager.LoadScene("Scene10");
};

 void SceneChange2(){
 SceneManager.LoadScene("Scene2b")};
