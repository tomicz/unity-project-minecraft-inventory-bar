using UnityEngine;
using UnityEngine.UI;

namespace Tomicz.Inventory
{
    public class DragSlot : MonoBehaviour
    {
        public Sprite Sprite => _spriteContainer.sprite;

        [Header("Dependencies")]
        [SerializeField] private Image _spriteContainer; 

        public void Show() => gameObject.SetActive(true);

        public void Hide() => gameObject.SetActive(false);

        public void SetSprite(Sprite sprite) => _spriteContainer.sprite = sprite;

        public void SetUIPosition(Vector2 position) => transform.position = position;
    }
}