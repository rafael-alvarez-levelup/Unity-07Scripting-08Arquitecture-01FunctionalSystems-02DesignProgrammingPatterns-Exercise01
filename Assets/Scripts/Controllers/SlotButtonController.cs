using UnityEngine;
using UnityEngine.UI;

public class SlotButtonController : MonoBehaviour
{
    [SerializeField] GameObject icon;
    [SerializeField] private Sprite[] actionSprites;

    private Button button;
    private Image iconImage;
    private int index = 0;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => ChangeIcon());

        iconImage = icon.GetComponent<Image>();
    }

    private void ChangeIcon()
    {
        index = (index + 1) % actionSprites.Length;
        iconImage.sprite = actionSprites[index];
    }
}