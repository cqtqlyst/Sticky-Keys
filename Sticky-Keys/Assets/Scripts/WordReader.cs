using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// reads the word list in for the word.cs checking isLetter
public class WordReader
{

    void Start() {

        string[] words = System.IO.File.ReadAllLines(@"Assets\Words\words.txt");

    }

}
