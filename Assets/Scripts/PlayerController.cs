using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Keyboard keyboard;
    private const float playerSpeed = 0.05f; // プレイヤーの移動速度

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        keyboard = Keyboard.current; // キーボードのインスタンスを取得

        Application.targetFrameRate = 60; // フレームレートを60fpsで固定
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard == null)
        {
            Debug.LogError("Keyboard not found. Make sure the Input System package is installed and configured.");
            return;
        }

        if (keyboard.wKey.isPressed) // Wキーを押している間
        {
            transform.Translate(0, playerSpeed, 0); // Y座標をプラス側（上）に進める
        }
        if (keyboard.sKey.isPressed) // Sキーを押している間
        {
            transform.Translate(0, -playerSpeed, 0); // Y座標をマイナス側（下）に進める
        }
        if (keyboard.aKey.isPressed) // Aキーを押している間
        {
            transform.Translate(-playerSpeed, 0, 0); // X座標をマイナス側（左）に進める
        }
        if (keyboard.dKey.isPressed) // Dキーを押している間
        {
            transform.Translate(playerSpeed, 0, 0); // X座標をプラス側（右）に進める
        }
    }
}
