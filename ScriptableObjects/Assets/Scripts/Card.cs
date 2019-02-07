using UnityEngine;

[CreateAssetMenu(menuName = "Card", fileName = "NewCard")]
public class Card : ScriptableObject 
{
    // Declare variables.
    public Sprite Artwork;
    public string Name, Description;
    public int Mana, Attack, Health;

    /// <summary>
    /// Output the important card information.
    /// </summary>
    public void Print()
    {
        Debug.LogFormat("{0} : {1} \nThe Card costs: '{2}'!", Name, Description, Mana);
    }
}