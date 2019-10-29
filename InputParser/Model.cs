﻿using System;
using System.Collections.Generic;


namespace InputParser
{
    public enum LayoutType
    {
        Normal,
        TextOnly,
        MapOnly
    }
    public enum ColorList
    {
        black,//
        lightgrey,
        magenta,
        cyan,
        yellow,
        red,
        green,
        darkgrey,
        blue,
        lightblue,
        lightgreen,
        lightcyan,
        brown,
        lightmagenta,
        lightred,//
        white//
    }
    public class Model
    {
        public LayoutType Layout { get; set; } = LayoutType.Normal;
        public List<string> TileNames { get; set; } = new List<string> { " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", "#cyan", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", ".darkgrey", ".darkgrey", "(brown", "#cyan", "#cyan", "#cyan", "#cyan", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", ".darkgrey", "%lightgreen", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", " darkgrey", "#yellow", "#yellow", "#yellow", "#yellow", "#yellow", " darkgrey", " darkgrey", " darkgrey", " darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", " darkgrey", ".yellow", ".yellow", ".yellow", ".yellow", "#yellow", "#yellow", "#cyan", "#cyan", "#cyan", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", " darkgrey", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", "#cyan", ".darkgrey", "@black", "(black", ".darkgrey", "(yellow", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", " darkgrey", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", "#cyan", ".darkgrey", "#cyan", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", " darkgrey", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", "#cyan", ".darkgrey", "#yellow", "#cyan", ".darkgrey", ".darkgrey", ".darkgrey", "#cyan", "#cyan", "#cyan", " darkgrey", "#yellow", "#yellow", "#yellow", ".yellow", ".yellow", ".yellow", "#cyan", ".darkgrey", "#yellow", " darkgrey", ".darkgrey", ".darkgrey", ".darkgrey", "#cyan", " darkgrey", " darkgrey", " darkgrey", "'yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".darkgrey", ".darkgrey", "#yellow", " darkgrey", " darkgrey", ".darkgrey", "^cyan", "#cyan", " darkgrey", " darkgrey", " darkgrey", "#yellow", "#yellow", "#yellow", "#yellow", "#yellow", "#yellow", "#cyan", "#cyan", "#yellow", " darkgrey", " darkgrey", "#cyan", ".darkgrey", "#cyan", " darkgrey", " darkgrey", " darkgrey", "'yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", " darkgrey", " darkgrey", " darkgrey", " darkgrey", ".darkgrey", ".darkgrey", " darkgrey", " darkgrey", " darkgrey", "#yellow", "#yellow", "#yellow", "#yellow", "#yellow", "#yellow", "#yellow", "#yellow", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", "#cyan", "#cyan", " darkgrey", " darkgrey", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", ".yellow", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", "#yellow", "#yellow", "#yellow", "#yellow", "#yellow", "#yellow", "#yellow", ".yellow", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", "#yellow", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey", " darkgrey" };
        public List<string> HighlightColors { get; set; } = new List<string> { "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "darkgrey", "yellow", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", "black", };
        public int LineLength { get; set; } = 80;
        public new List<List<string>> FullLengthStrings { get; set; } = new List<List<string>> {
            new List<string> { ""},
            new List<string> { "" } 
        };
        public List<List<string>> FullLengthStringColors { get; set; } = new List<List<string>> {
            new List<string> { ""},
            new List<string> { "" }
        };
        public SideData SideData { get; set; }
    }
    public class SideData
    {
        public string Name { get; set; } = "Sentinel The Covered";
        public string Race { get; set; } = "Demigod";
        public int Health { get; set; } = -320;
        public int MaxHealth { get; set; } = 320;
        public int Magic { get; set; } = 50;
        public int MaxMagic { get; set; } = 50;
        public string ArmourClass { get; set; } = "100";
        public string Evasion { get; set; } = "100";
        public string Shield { get; set; } = "100";
        public string ExperienceLevel { get; set; } = "27";
        public string NextLevel { get; set; } = "-130%";
        public string Weapon { get; set; } = "9999";
        public string Quiver { get; set; } = "9999";
        public string Strength { get; set; } = "9999";
        public string Dexterity { get; set; } = "9999";
        public string Inteligence { get; set; } = "9999";
        public string Place { get; set; } = "Dungeon:1";
        public string Time { get; set; } = "999999 (25.0)";
        public string Statuses1 { get; set; } = "Slow Agi Might Haste Para";
        public string Statuses2 { get; set; } = "Tree -Tele ";

    };
}