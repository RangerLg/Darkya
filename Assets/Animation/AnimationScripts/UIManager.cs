using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Animation.AnimationScripts
{
    public class UIManager : MonoBehaviour
    {
        public Animator contentPanel1;
        public Animator contentPanel2;
        public Animator contentPanel3;
        private static readonly int IsHidden = Animator.StringToHash("IsHidden");
        public Button magic1;
        public Button magic2;
        public Button magic3;
        public MagicController MagicController;
        private static readonly int Count = Animator.StringToHash("Count");
        public RawImage Image;
        public GameObject Controls;


        public void ToggleMinimap()
        {
            MagicController.isMagicAvailable = Image.enabled;
            Controls.SetActive(Image.enabled);
            Image.enabled = !Image.enabled;
        }

       

        public void ToggleMenu()
        {
            //contentPanel3.enabled = true;
            //var isHidden = contentPanel3.GetBool(IsHidden);
            //contentPanel3.SetBool(IsHidden, !isHidden);


            contentPanel2.enabled = true;
            var isHidden = contentPanel2.GetBool(IsHidden);
            contentPanel2.SetBool(IsHidden, !isHidden);

            contentPanel1.enabled = true;
            isHidden = contentPanel1.GetBool(IsHidden);
            contentPanel1.SetBool(IsHidden, !isHidden);
        }

        // Start is called before the first frame update
        void Start()
        {
            var transform1 = contentPanel1.gameObject.transform as RectTransform;
            var transform2 = contentPanel2.gameObject.transform as RectTransform;
            var transform3 = contentPanel3.gameObject.transform as RectTransform;
            var position = transform1.anchoredPosition;
            position.y = -26;
            transform1.anchoredPosition = position;

            position = transform2.anchoredPosition;
            position.y = -26;
            transform2.anchoredPosition = position;

            position = transform3.anchoredPosition;
            position.y = -26;
            transform3.anchoredPosition = position;
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}