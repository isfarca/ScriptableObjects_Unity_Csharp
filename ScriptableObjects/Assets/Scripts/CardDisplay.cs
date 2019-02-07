using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour 
{
    // Declare variables.
    [SerializeField] private Card _card;
    [SerializeField] private Image _artwork;
    [SerializeField] private Text _name, _description;
    [SerializeField] private Text _mana, _attack, _health;

    /// <summary>
    /// Set the information to default game object.
    /// </summary>
    private void Start()
    {
        _artwork.sprite = _card.Artwork;
        _name.text = _card.Name;
        _description.text = _card.Description;
        _mana.text = _card.Mana.ToString();
        _attack.text = _card.Attack.ToString();
        _health.text = _card.Health.ToString();
    }
}