using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Search;
using UnityEngine;

[System.Serializable]
public class ItemDefinition
{
    public string itemName;
    public int itemID;
    public int buff;
}


public class LinqItemFilter : MonoBehaviour
{


    public List<ItemDefinition> items;
    public int sum = 0;

    // Start is called before the first frame update
    void Start()
    {
        var hasItemId3 = items.Contains(items[3]);  //check if ItemID 3 exists in the list and print out true or false
        Debug.Log("has itemID 3 = " + hasItemId3);

        //grab all items with buff greater than 20 and print them out

        var greater20 = items.Where(items => items.buff > 20);
        foreach (var item in greater20)
        {
            Debug.Log("items with buff greater than 20 = " + item.itemName);
        }

        //Calculate the average of all the buff stats.

        //var avgOfBuffs = sum / items.Sum(items => sum + items.buff);
        
        var avgofBuffs = (items.Sum(items => sum + items.buff))/items.Count;
        var avgExt = items.Average(items => items.buff);

        Debug.Log("Average of buffs should be: "+ (131 / 5));
        Debug.Log("Avg of buffs 131 == " + avgofBuffs);
        Debug.Log("Avg of buffs 131 == " + avgExt);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
