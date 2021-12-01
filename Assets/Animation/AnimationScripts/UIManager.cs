using UnityEngine;
using UnityEngine.UI;

namespace Animation.AnimationScripts
{
    public class UIManager : MonoBehaviour
    {
        public Animator contentPanel;
        private static readonly int IsHidden = Animator.StringToHash("isHidden");
        public Button magic1;
        public Button magic2;
        public Button magic3;
        public MagicController MagicController;
        private static readonly int Count = Animator.StringToHash("Count");

        public void ToggleMenu()
        {
            var count = MagicController.GetCount();
            switch (count)
            {
                case 3:
                    break;
                case 2:
                    magic3.enabled = false;
                    magic3.gameObject.SetActive(false);
                    break;
                case 1:
                    magic3.gameObject.SetActive(false);
                    magic2.gameObject.SetActive(false);
                    magic3.enabled = magic2.enabled = false;
                    break;
            }
            contentPanel.enabled = true;
            var isHidden = contentPanel.GetBool(IsHidden);
            contentPanel.SetBool(IsHidden, !isHidden);
            
        }

        // Start is called before the first frame update
        void Start()
        {
            var transform = contentPanel.gameObject.transform as RectTransform;
            var position = transform.anchoredPosition;
            position.y -= transform.sizeDelta.y;
            transform.anchoredPosition = position;
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}