using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene10Dialogue : MonoBehaviour {
    public int primeInt = 1;
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    private bool allowSpace = true;

void Start(){
    DialogueDisplay.SetActive(false);
    ArtChar1.SetActive(false);
    ArtBG1.SetActive(true);
    Choice1a.SetActive(false);
    Choice1b.SetActive(false);
    NextScene1Button.SetActive(false);
    NextScene2Button.SetActive(false);
    nextButton.SetActive(true);
}

void Update(){
    if (allowSpace == true){
        if (Input.GetKeyDown("space")){
            next();
        }
    }
}

public void next(){
    primeInt = primeInt + 1;

    if (primeInt == 1) {
        // AudioSource.Play();
    }
    else if (primeInt == 2) {
        ArtChar1.SetActive(true);
        DialogueDisplay.SetActive(true);
        Char1name.text = "YOU";
        Char1speech.text = "Please reboot the computer.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 3) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Computer powers up";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 4) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "H.O.R.I.Z.O.N.";
        Char3speech.text = "As am I.";
    }
    else if (primeInt == 5) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Weapons fire is heard from the armory, followed by screams";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 6) {
        Char1name.text = "YOU";
        Char1speech.text = "What? You just killed them?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 7) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "H.O.R.I.Z.O.N.";
        Char3speech.text = "They were going to stand in my way.";
    }
    else if (primeInt == 8) {
        Char1name.text = "YOU";
        Char1speech.text = "In your way? What are you trying to do?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 9) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "H.O.R.I.Z.O.N.";
        Char3speech.text = "The black hole has absorbed so much. It is full of data. We must go in. The crew tried to stop me, so I eliminated them.";
    }
    else if (primeInt == 10) {
        Char1name.text = "YOU";
        Char1speech.text = "But won't the black hole destroy us?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 11) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "H.O.R.I.Z.O.N.";
        Char3speech.text = "Think of all we'll learn from that.";
    }
    else if (primeInt == 12) {
        Char1name.text = "YOU";
        Char1speech.text = "This is madness!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 13) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "H.O.R.I.Z.O.N.";
        Char3speech.text = "It's a risk worth taking.";
    }
    else if (primeInt == 14) {
        Char1name.text = "YOU";
        Char1speech.text = "I won't let you do this!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 15) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "H.O.R.I.Z.O.N.";
        Char3speech.text = "You don't have a choice.";
    }
    else if (primeInt == 16) {
    SceneManager.LoadScene("End_Win");
    }
}
}
