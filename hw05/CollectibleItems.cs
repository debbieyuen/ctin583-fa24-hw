using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Flags]
public enum CollectibleItems
{
    Bomb,
    Rock,
    Gem,
    Leaf,
    Flower,
    Fake,
    Enemy,
    Player
}

public interface CollectibleInterface {
    void myCollectable(CollectibleItems items);
}
