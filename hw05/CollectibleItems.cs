using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Flags]
public enum CollectibleItems
{
    Bomb = 1,
    Rock = 2,
    Gem = 3,
    Leaf = 4,
    Flower = 5,
    Fake = 6,
    Enemy = 7,
    Player = 8
}

public interface CollectibleInterface
{
    void myCollectable(CollectibleItems items);
}

public class CollectibleHandler : CollectibleInterface
{
    public void myCollectable(CollectibleItems items)
    {
        switch (items)
        {
            case CollectibleItems.Bomb:
                HandleCollectible(CollectibleItems.Bomb);
                break;

            case CollectibleItems.Rock:
                HandleCollectible(CollectibleItems.Rock);
                break;

            case CollectibleItems.Gem:
                HandleCollectible(CollectibleItems.Gem);
                break;

            case CollectibleItems.Leaf:
                HandleCollectible(CollectibleItems.Leaf);
                break;

            case CollectibleItems.Flower:
                HandleCollectible(CollectibleItems.Flower);
                break;

            case CollectibleItems.Fake:
                HandleCollectible(CollectibleItems.Fake);
                break;

            case CollectibleItems.Enemy:
                HandleCollectible(CollectibleItems.Enemy);
                break;

            case CollectibleItems.Player:
                HandleCollectible(CollectibleItems.Player);
                break;

            default:
                Debug.Log("Unknown collectible item.");
                break;
        }
    }

    private void HandleCollectible(CollectibleItems item)
    {
        Debug.Log($"You collected a {item.ToString()}!");
        // Add more specific logic based on the collectible here if needed
    }
}