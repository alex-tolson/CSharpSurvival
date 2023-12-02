using System.Linq;
using UnityEngine;

public class LinqExample : MonoBehaviour
{
    public string[] names = { "tom", "dimi", "harry", "jesse", "patrick", "clause", "pete" };


    void Start()
    {
        var doesNameMatch = names.Any(name => name == "pete");

        Debug.Log("Name Found: " + doesNameMatch);
    }

    void Update()
    {
        
    }
}
