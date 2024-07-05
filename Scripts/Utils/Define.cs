using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Define : MonoBehaviour
{
    public static readonly string TextEffect = "Text";
    public enum Sound
    {
        Bgm,
        Sfx,
        MaxCount,
    }

    public enum UIEvent
    {
        Click,
        Down,
        Up,
        Drag,
    }
    public enum EffectType
    {
        FadeIn,
        FadeOut,

    }

}