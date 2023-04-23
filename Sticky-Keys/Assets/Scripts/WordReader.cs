using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// reads the word list in for the word.cs checking isLetter
public class WordReader : MonoBehaviour
{
    private int[] letters = new int[26];
    private string word;
    private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string letterPrint;
    private int letterNum;
    private int wordCount;
    private int score = 0;
    private bool isValid;

    Dictionary<string, int> WordBank;
    [SerializeField] private TextAsset file;

    public TMP_Text Points;
    public TMP_Text validLetters;

    void Start() {
        WordBank = new Dictionary<string, int>();
        ReadFile();
        Debug.Log(wordCount);
        for (int i = 0; i < 26; i++)
        {
            letters[i] = 2;
            for (int j = 0; j < letters[i]; j++)
            {
                letterPrint += alphabet[i];
            }
            letterPrint += "   ";
        }
        validLetters.text = letterPrint;
    }

    void ReadFile()
    {
        var splitFile = new string[] { "\r\n", "\r", "\n" };
        var Lines = file.text.Split(splitFile, System.StringSplitOptions.RemoveEmptyEntries);
        wordCount = Lines.Length;
        for(int i = 0; i < wordCount; i++)
        {
            int length = Lines[i].Length;
            WordBank.Add(Lines[i], length);
        }
    }


    public void ReadStringInput(string input)
    {
        word = input;
        Debug.Log(word);
        int length = word.Length;
        isValid = true;
        letterPrint = "";
        for (int i = 0; i < length; i++)
        {
            int a = word[i];
            a -= 97;
            if (letters[a] <= 0)
            {
                isValid = false;
            }
            else
            {
                letters[a]--;
            }
        }
        if (isValid == true)
        {
            if (WordBank.ContainsKey(word))
            {
                score += WordBank[word];
                Debug.Log(score);
                Points.text = "Score: " + score;
            }
        }
        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < letters[i]; j++)
            {
                letterPrint += alphabet[i];
            }
            if (letters[i] != 0)
            {
                letterPrint += " ";
            }
        }
        validLetters.text = letterPrint;

    }
}
