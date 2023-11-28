using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace TrafficInfinity
{
    public class LoadExcel : MonoBehaviour
    {
        public Item blankItem;
        public List<Item> itemDatabase = new List<Item>();

        public void LoadItemData()
        {
            itemDatabase.Clear();

            var data = CSVReader.Read("ItemDatabase");
            for (var i = 0; i < data.Count; i++)
            {
                int id = int.Parse(data[i]["id"].ToString(), System.Globalization.NumberStyles.Integer);
                string name = data[i]["name"].ToString();
                string speed = data[i]["speed"].ToString();
                string boost = data[i]["boost"].ToString();

                AddItem(id, name, speed, boost);

            }

        }
        void AddItem(int id, string name, string speed, string boost)
        {
            Item tempItem = new Item(blankItem);

            tempItem.id = id;
            tempItem.name = name;
            tempItem.speed = speed;
            tempItem.boost = boost;

            itemDatabase.Add(tempItem);
        }
    }
} 



