using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordReader
{

    void Start() {

        string[] words = System.IO.File.ReadAllLines(@"Assets\Words\words.txt");

    }

}
