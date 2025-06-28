using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set;}

    private void Awake()
    {
        Instance = this;
    }

    public Transform pfItemWorld;
    public Sprite rocciaSprite;
    public Sprite scalaSprite;
    public Sprite cacciaviteSprite;
    public Sprite keycardSprite;
    public Sprite foglio1Sprite;
    public Sprite foglio2Sprite;
    public Sprite ferroSprite;
    public Sprite graffetteSprite;
    public Sprite martelloSprite;
    public Sprite adesivoSprite;
    public Sprite barra_nastroSprite;
    public Sprite porcoSprite;
}
