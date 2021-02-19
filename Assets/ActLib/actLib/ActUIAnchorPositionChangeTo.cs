using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActLib
{
    public class ActUIAnchorPositionChangeTo : BaseAct
    {
        public ActUIAnchorPositionChangeTo(float duration, RectTransform rectTrans, Vector2 position)
        {
            _duration = duration;
            _endPosition = position;
            _trans = rectTrans; 
        }

        Vector2 _endPosition;
        RectTransform _trans;

        public override void SetGameObject(GameObject tar)
        {
            base.SetGameObject(tar);
        }

        public override IEnumerator IAct()
        {
            float elapsedTime = 0;
            Vector2 startingPos = _trans.anchoredPosition;

            while (elapsedTime < _duration)
            {
                _trans.anchoredPosition= Vector2.Lerp(startingPos, _endPosition, (elapsedTime / _duration));
                elapsedTime += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            _trans.anchoredPosition = _endPosition;
            Done();
        }
    }
}

