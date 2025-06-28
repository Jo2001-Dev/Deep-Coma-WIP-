using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item
{
    public enum ItemType 
    {
        roccia,
        scala,
        cacciavite,
        keycard,
        foglio1,
        foglio2,
        ferro,
        graffette,
        martello,
        adesivo,
        barra_nastro,
        porco,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            
            default:
            case ItemType.roccia:         return ItemAssets.Instance.rocciaSprite;
            case ItemType.scala:          return ItemAssets.Instance.scalaSprite;
            case ItemType.cacciavite:     return ItemAssets.Instance.cacciaviteSprite;
            case ItemType.keycard:        return ItemAssets.Instance.keycardSprite;
            case ItemType.foglio1:        return ItemAssets.Instance.foglio1Sprite;
            case ItemType.foglio2:        return ItemAssets.Instance.foglio2Sprite;
            case ItemType.ferro:          return ItemAssets.Instance.ferroSprite;
            case ItemType.graffette:      return ItemAssets.Instance.graffetteSprite;
            case ItemType.martello:       return ItemAssets.Instance.martelloSprite;
            case ItemType.adesivo:        return ItemAssets.Instance.adesivoSprite;
            case ItemType.barra_nastro:   return ItemAssets.Instance.barra_nastroSprite;
            case ItemType.porco:          return ItemAssets.Instance.porcoSprite;
        }
    }
}
