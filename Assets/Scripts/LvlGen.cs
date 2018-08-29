using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

public class LvlGen : MonoBehaviour
{

    public string path;

    [Header("Materials")]
    public Material BedrockMaterial;
    public Material GoldMaterial;
    public Material GemMaterial;

    [Header("Objects")]
    public Transform Bedrock;
    public Transform Dirtblock;
    public Transform Goldseam;
    public Transform Gemseam;
    public Transform Ground;
    public Transform Water;
    public Transform Lava;
    public Transform FogOfWar;
    public Transform Roof;

    [Header("Dungeon Hearts")]
    public Transform RHeart;
    public Transform BHeart;
    public Transform GHeart;
    public Transform YHeart;
    public Transform WHeart;

    [Header("Fortified Walls")]
    public Transform RWall;
    public Transform BWall;
    public Transform GWall;
    public Transform YWall;
    public Transform WWall;

    [Header("Fortified Ground")]
    public Transform RGround;
    public Transform BGround;
    public Transform GGround;
    public Transform YGround;
    public Transform WGround;


    public const string sBedrock = "00";
    public const string sDirtblock = "01";
    public const string sGoldseam = "02";
    public const string sGemseam = "03";
    public const string sGround = "04";
    public const string sWater = "05";
    public const string sLava = "06";
    public const string sRHeart = "RH";
    public const string sBHeart = "BH";
    public const string sGHeart = "GH";
    public const string sYHeart = "YH";
    public const string sWHeart = "WH";
    public const string sRWall = "RW";
    public const string sBWall = "BW";
    public const string sGWall = "GW";
    public const string sYWall = "YW";
    public const string sWWall = "WW";
    public const string sRGround = "RG";
    public const string sBGround = "BG";
    public const string sGGround = "GG";
    public const string sYGround = "YG";
    public const string sWGround = "WG";

    private Transform BedrockGround;
    private Transform GoldGround;
    private Transform GemGround;
    private Transform Block;

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
                    case sBedrock:
                        Block = Instantiate(Bedrock, new Vector3(x, 0.5f, -y), Quaternion.identity);
                        BedrockGround = Instantiate(Ground, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        BedrockGround.GetComponentInChildren<Renderer>().material = BedrockMaterial;
                        Instantiate(Roof, Block.transform.position, Quaternion.identity);
                        break;
                    case sDirtblock:
                        Block = Instantiate(Dirtblock, new Vector3(x, 0.5f, -y), Quaternion.identity);
                        Instantiate(Ground, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        Instantiate(Roof, Block.transform.position, Quaternion.identity);
                        break;
                    case sGoldseam:
                        Block = Instantiate(Goldseam, new Vector3(x, 0.5f, -y), Quaternion.identity);
                        GoldGround = Instantiate(Ground, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        GoldGround.GetComponentInChildren<Renderer>().material = GoldMaterial;
                        Instantiate(Roof, Block.transform.position, Quaternion.identity);
                        break;
                    case sGemseam:
                        Block = Instantiate(Gemseam, new Vector3(x, 0.5f, -y), Quaternion.identity);
                        GemGround = Instantiate(Ground, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        GemGround.GetComponentInChildren<Renderer>().material = GemMaterial;
                        Instantiate(Roof, Block.transform.position, Quaternion.identity);
                        break;
                    case sGround:
                        Instantiate(Ground, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        
                        break;
                    case sWater:
                        Instantiate(Water, new Vector3(x, -0.08f, -y), Quaternion.identity);
                        
                        break;
                    case sLava:
                        Instantiate(Lava, new Vector3(x, -0.08f, -y), Quaternion.identity);
                        
                        break;

                    case sRHeart:
                        Instantiate(RHeart, new Vector3(x, 0.95f, -y), Quaternion.identity);
                        Instantiate(RGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        break;
                    case sBHeart:
                        Instantiate(BHeart, new Vector3(x, 0.95f, -y), Quaternion.identity);
                        Instantiate(BGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        
                        break;
                    case sGHeart:
                        Instantiate(GHeart, new Vector3(x, 0.95f, -y), Quaternion.identity);
                        Instantiate(GGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        
                        break;
                    case sYHeart:
                        Instantiate(YHeart, new Vector3(x, 0.95f, -y), Quaternion.identity);
                        Instantiate(YGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        
                        break;
                    case sWHeart:
                        Instantiate(WHeart, new Vector3(x, 0.95f, -y), Quaternion.identity);
                        Instantiate(WGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        
                        break;

                    case sRWall:
                        Block = Instantiate(RWall, new Vector3(x, 0.5f, -y), Quaternion.identity);
                        Instantiate(RGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        Instantiate(Roof, Block.transform.position, Quaternion.identity);
                        break;
                    case sBWall:
                        Block = Instantiate(BWall, new Vector3(x, 0.5f, -y), Quaternion.identity);
                        Instantiate(BGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        Instantiate(Roof, Block.transform.position, Quaternion.identity);
                        break;
                    case sGWall:
                        Block = Instantiate(GWall, new Vector3(x, 0.5f, -y), Quaternion.identity);
                        Instantiate(GGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        Instantiate(Roof, Block.transform.position, Quaternion.identity);
                        break;
                    case sYWall:
                        Block = Instantiate(YWall, new Vector3(x, 0.5f, -y), Quaternion.identity);
                        Instantiate(YGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        Instantiate(Roof, Block.transform.position, Quaternion.identity);
                        break;
                    case sWWall:
                        Block = Instantiate(WWall, new Vector3(x, 0.5f, -y), Quaternion.identity);
                        Instantiate(WGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        Instantiate(Roof, Block.transform.position, Quaternion.identity);
                        break;

                    case sRGround:
                        Instantiate(RGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        break;
                    case sBGround:
                        
                        Instantiate(BGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        break;
                    case sGGround:
                        Instantiate(GGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        
                        break;
                    case sYGround:
                        Instantiate(YGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        
                        break;
                    case sWGround:
                        Instantiate(WGround, new Vector3(x, -0.3f, -y), Quaternion.identity);
                        
                        break;
                }
            }
        }
    }
}