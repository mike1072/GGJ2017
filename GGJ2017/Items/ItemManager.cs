﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGJ2017.Items
{
    public static class ItemManager
    {
        public static Dictionary<ItemType, Item> Items { get; } = new Dictionary<ItemType, Item>()
        {
            { ItemType.Wine, new Item("Wine", ItemType.Wine) },
            { ItemType.Hat, new Item("Hat", ItemType.Hat) },
            { ItemType.ModernArt, new Item("Modern Art", ItemType.ModernArt) },
            { ItemType.Toy, new Item("Toy", ItemType.Toy) },
        };
    }
}
