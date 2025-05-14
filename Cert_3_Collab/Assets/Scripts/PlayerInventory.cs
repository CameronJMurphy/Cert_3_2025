using UnityEngine;
using System.IO;

public class PlayerInventory : MonoBehaviour
{
    private const int maxItems = 10;
    private string[] inventory;
    int currentItemsHeld = 0;
    private static readonly string filepath = Application.dataPath + "/TextData/PlayerInventory.txt";
    void Start()
    {
        //inventory = new string[maxItems] {"knife", "bear", "bear", "robe", "frog", "staff", "", "", "", "" };
        //StreamWriter writer = new StreamWriter(Application.dataPath + "/TextData/PlayerInventory.txt");
        //for (int i = 0; i < inventory.Length; i++)
        //{
        //    writer.WriteLine(inventory[i]);
        //}
//
        //writer.Close();
        inventory = new string[maxItems];
        if (File.Exists(filepath))
        {
            StreamReader reader = new StreamReader(filepath);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (currentItemsHeld < maxItems)
                {
                    inventory[currentItemsHeld] = line;
                    currentItemsHeld++;
                }
            }
            reader.Close();
        }
        PrintInventory();
    }

    void PrintInventory()
    {
        for (int i = 0; i < currentItemsHeld; i++)
        {
            Debug.Log(inventory[i]);
        }
    }
    void GetItem(string itemName)
    {
        StreamWriter writer = new StreamWriter(Application.dataPath + "/TextData/PlayerInventory.txt", true);
        writer.WriteLine(itemName);
        writer.Close();
        
        
    }
    
    void Update()
    {
        
    }
}
