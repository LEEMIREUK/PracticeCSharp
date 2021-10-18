using System;
using System.Collections.Generic;

namespace CSharp
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }


    class Program
    {
        static List<Item> _items = new List<Item>();

        delegate bool ItemSelector(Item item);
        //delegate Return MyFunc<T, Return>(T item);

        static bool IsWeapon(Item item)
        {
            return item.ItemType == ItemType.Weapon;
        }

        static Item FindItem(Func<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }


        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }

        //static Item FindWeapon()
        //{
        //    foreach (Item item in _items)
        //    {
        //        if (item.ItemType == ItemType.Weapon)
        //            return item;
        //    }
        //    return null;
        //}

        //static Item FindRareItem()
        //{
        //    foreach (Item item in _items)
        //    {
        //        if (item.Rarity == Rarity.Rare)
        //            return item;
        //    }
        //    return null;
        //}

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            // Lambda : 일회용 함수를 만드는데 사용하는 문법이다.

            //Item item = FindItem(IsWeapon);

            ItemSelector selector = new ItemSelector((Item item) => { return item.ItemType == ItemType.Weapon; });

            // Anonymous Function: 무명함수 / 익명함수
            Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });

            // Lambda
            Item item2 = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });

            Func<Item, bool> selector2 = (Item item) => { return item.ItemType == ItemType.Weapon; };
        }
    }
}
