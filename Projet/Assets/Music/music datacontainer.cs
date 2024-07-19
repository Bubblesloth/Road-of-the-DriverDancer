using UnityEngine;
using System;
using System.Collections.Generic;
using NorskaLib.Spreadsheets;

[CreateAssetMenu(fileName = "Musics", menuName = "ScriptableObjects/Musics")]
[Serializable]
public class MusicPage : SpreadsheetsContainerBase
{
    [SpreadsheetContent]
    [SerializeField] Musiclist content;
    public Musiclist Content => content;
}

[Serializable]
public class Musiclist
{
    [SpreadsheetPage("Music1")]
    public List<Music> Musics1;
    [SpreadsheetPage("Music2")]
    public List<Music> Musics2;
    [SpreadsheetPage("Music2EASY")]
    public List<Music> Musics2EASY;
    [SpreadsheetPage("Music3")]
    public List<Music> Musics3;
}

[Serializable]
public class Music
{
    public int road1;
    public int road2;
    public int road3;
    public int road4;
    public int road5;
    public int road6;
    public int activebeats;
}