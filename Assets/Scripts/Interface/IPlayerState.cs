using UnityEngine;
using UnityEngine.UI;

namespace VD
{
    public interface IPlayerState
    {
        void Enter();
        void Exit();
        void HandleLeftClick();
        void HandleRightClick();
        void HandleTriggerEnter2D(Collider2D collider);
        void HandleTriggerExit2D();

    }
}