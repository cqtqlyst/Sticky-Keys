using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// reads the word list in for the word.cs checking isLetter
public class WordReader : MonoBehaviour
{
    private int[] letters = new int[26];
    private string word;
    private int letterNum;
    private int wordCount;
    Dictionary<string, int> WordBank;
    [SerializeField] private TextAsset file;
    void Start() {

        WordBank = new Dictionary<string, int>();
        ReadFile();
        Debug.Log(wordCount);
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

    void Update()
    {
       
    }

    public void ReadStringInput(string input)
    {
        word = input;
        Debug.Log(word);
    }
}
