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

public interface CollectibleInterface {
    void myCollectable(CollectibleItems items);
}
