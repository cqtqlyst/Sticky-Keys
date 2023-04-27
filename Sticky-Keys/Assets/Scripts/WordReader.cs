using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// reads the word list in for the word.cs checking isLetter
public class WordReader : MonoBehaviour
{
    //creating global letters to be acessed from any file
    public static int[] letters = new int[26];
    // creating private variables for:
    // the word inputted by the player
    // initialize the alphabet for converting letters to numbers
    // initialize string for printing on screen
    // implements amount of words in the dictionary
    // creates booleans to see if words inputted by the player is legal
    private string word;
    private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string letterPrint;
    private int wordCount;
    private bool isValid;

    // initializes a dictionary where all of the words are stored
    // initialize the file asset in our game
    Dictionary<string, int> WordBank;
    [SerializeField] private TextAsset file;

    // creates on screen text boxes
    public TMP_Text Points;
    public TMP_Text validLetters;

    void Start() {
        // intializes the dictionary
        WordBank = new Dictionary<string, int>();
        // reads file and adds words to dictionary
        ReadFile();
        // prints word counts for testing
        Debug.Log(wordCount);
        for (int i = 0; i < 26; i++)
        {
            //letters[i] = 2;
            for (int j = 0; j < letters[i]; j++)
            {
                letterPrint += alphabet[i];
            }
            if (letters[i] != 0)
            {
                letterPrint += "   ";
            }
        }
        validLetters.text = letterPrint;
        ScoreManager.score = 0;

        //for (int i = 0; i<26; i++)
        //{
        //    Debug.Log(i + " " + WordReader.letters[i]);
        //}
    }

    void ReadFile()
    {
        // reads file and splits file by new line to save words and their points 
        var splitFile = new string[] { "\r\n", "\r", "\n" };
        var Lines = file.text.Split(splitFile, System.StringSplitOptions.RemoveEmptyEntries);
        wordCount = Lines.Length;
        for(int i = 0; i < wordCount; i++)
        {
            int length = Lines[i].Length;
            WordBank.Add(Lines[i], length);
        }
    }

    // method read every time player inputs a word and presses enter on screen
    public void ReadStringInput(string input)
    {
        // word that the player inputs
        word = input;
        // implements word to lowercase and removes spaces for easier player aces
        word = word.ToLower();
        word = word.Replace(" ", "");
        // prints word for testing
        Debug.Log(word);
        // finds the length of the word to test each individual letter
        int length = word.Length;
        // the word starts as valid everytime 
        isValid = true;
        // initializing the print screen for the available letters
        letterPrint = "";
        for (int i = 0; i < length; i++)
        {
            //finds the integer value of each character
            int a = word[i];
            a -= 97;
            // if the letter is invalid the word will become false and the player won't recive any points
            if (letters[a] <= 0)
            {
                isValid = false;
            }
            else
            {
                letters[a]--;
            }
        }
        // checks if the word is still valid 
        if (isValid == true)
        {
            // checks if the word actually exists
            if (WordBank.ContainsKey(word))
            {
                //adds score since the word passes all checks
                ScoreManager.score += WordBank[word];
                // outputs player score to make sure bugs don't exist
                Debug.Log(ScoreManager.score);
                // prints score on screen
                Points.text = "Score: " + ScoreManager.score;
            }
        }
        // runs loop to print remaining letters on screen for the player
        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < letters[i]; j++)
            {
                letterPrint += alphabet[i];
            }
            if (letters[i] != 0)
            {
                letterPrint += "   ";
            }
        }
        validLetters.text = letterPrint;

    }
}
