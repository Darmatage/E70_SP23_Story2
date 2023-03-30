using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour {

        public static int batteries = 0;
		public static bool corridorCAlready = false;           // have you visited corridor C already?
		public static bool corridorBAlready = false;           // have you visited corridor B already?
		public static bool foundManual = false;                 // have you found the hydrator manual in engineering?
		public static bool kitchenAlready = false;             // have you been to the kitchen already?
		public static bool engiAlready = false;               // have you looked in engineering storage?
		public static bool seenPantry = false;               // have you investigated the kitchen's pantry?
		public static bool seenHydrator = false;            // have you investigated the kitchen's hydrator?
		public static bool armoryAlready = false;          // have you visited the armory already?
		public static bool armoryCell = false;          // have you retrieved the power cell from the armory's back room?
		public static bool barracksAlready = false;
		public static bool airlockAlready = false;
		public static bool ventAlready = false;           //have you investigated the vent in cargo yet?
		public static bool cargoAlready = false;           //have you visited the cargo hold already?
		public static bool cratesAlready = false;           //have you searched the cargo crates already?
		public static bool guardsAlert = false;            // have you alerted the guards in the armory?
		public static bool guardsTension = false;         // should you see the 'armory escape' dialogue when returning to corridor c?
		public static bool hasScrewdriver = false;       // got screwdriver from barracks?
        public static bool GameisPaused = false;
		public static bool cryoAlready = false;          // have you visited cryo yet?
		public static bool cryoCells = false;          // did you take the power cells from the cryo facility?
		public static bool medbayAlready = false;              // have you visited the medbay yet?
		public static bool capQuartersAlready = false;              // have you visited the captain's quarters yet?
		public static bool capsGun = false;                    // did you take the captain's gun?
        public GameObject pauseMenuUI;
        public AudioMixer MyMusicMixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;

        void Awake(){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start(){
                pauseMenuUI.SetActive(false);
                GameisPaused = false;
        }

        void Update(){
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){ Resume(); }
                        else{ Pause(); }
                }
                // Stat tester:
                // if (Input.GetKey("p")){
                       // Debug.Log("Player Stat = " + playerStat1);
                // }
        }

        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel (float sliderValue){
                MyMusicMixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }


        public void StartGame(){
                SceneManager.LoadScene("Scene1");
        }

        public void OpenCredits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                Time.timeScale = 1f;
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
}