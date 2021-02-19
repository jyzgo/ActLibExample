using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ActLib
{
    public class testActLib : MonoBehaviour
    {
        public GameObject gb;
        public Button moveAnchorBtn;
        // Start is called before the first frame update
        private void Awake()
        {
            moveAnchorBtn.onClick.AddListener(MoveAncor);
        }
        void Start()
        {
            gb.PlayAct(new ActMoveToLocal(1, new Vector3(2, 2, 2)));
        }

        void MoveAncor()
        {
            print("move Ancor");
            gb.PlayAct(new ActUIAnchorPositionChangeTo(1f, moveAnchorBtn.GetComponent<RectTransform>(), new Vector2(100, 100)));
        }

    }
}
