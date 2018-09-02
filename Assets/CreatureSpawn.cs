using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

public class CreatureSpawn : MonoBehaviour
{

    public string path;

    [Header("Red Creature")]
    public Transform redImp;

	public const string sNothing = "[NOT]";
    public const string sRedImp = "[RIM]";

    string[][] ReadFile(string file)
    {
        string text = System.IO.File.ReadAllText(file);
        string[] lines = System.Text.RegularExpressions.Regex.Split(text, "\r\n");
        int rows = lines.Length;

        string[][] levelBase = new string[rows][];
        for (int i = 0; i < lines.Length; i++)
        {
            string[] stringsOfLine = System.Text.RegularExpressions.Regex.Split(lines[i], " ");
            levelBase[i] = stringsOfLine;
        }
        return levelBase;
    }

    public void Start()
    {
        string[][] jagged = ReadFile(path);

        // create planes based on matrix
        for (int y = 0; y < jagged.Length; y++)
        {
            for (int x = 0; x < jagged[0].Length; x++)
            {
                switch (jagged[y][x])
                {
                    case sRedImp:
                        Instantiate(redImp, new Vector3(x, 0.5f, -y), Quaternion.identity);
                        break;
					case sNothing:
                        break;
                }
            }
        }
    }
}