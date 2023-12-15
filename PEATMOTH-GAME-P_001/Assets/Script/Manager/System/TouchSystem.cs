using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSystem : MonoBehaviour
{
    private static TouchSystem _instance;

    public static TouchSystem Instance
    {
        get { return _instance; }
    }

    void Awake()
    {
        _instance = this;
    }

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode keyCode in System.Enum.GetValues(typeof(GameKeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    GameEventManager.Instance.OnKeyDowned(keyCode,GetScreenCoordinates(keyCode));
                }
            }
        }
    }


    public Vector2 GetScreenCoordinates(KeyCode key)
    {
        Vector2 keyboardPosition = KeyCodeToVector2(key);
        Vector2 screenPixelPosition = new Vector2(Mathf.Lerp(0, Screen.width, keyboardPosition.x),
            Mathf.Lerp(0, Screen.height, keyboardPosition.y));
        
        return screenPixelPosition;
    }
    
    public Vector2 KeyCodeToVector2(KeyCode key)
    {
        switch (key)
        {
            case KeyCode.Alpha1:
                return new Vector2(0, 1);
            case KeyCode.Alpha2:
                return new Vector2(0.09f, 1);
            case KeyCode.Alpha3:
                return new Vector2(0.18f, 1);
            case KeyCode.Alpha4:
                return new Vector2(0.27f, 1);
            case KeyCode.Alpha5:
                return new Vector2(0.36f, 1);
            case KeyCode.Alpha6:
                return new Vector2(0.45f, 1);
            case KeyCode.Alpha7:
                return new Vector2(0.55f, 1);
            case KeyCode.Alpha8:
                return new Vector2(0.64f, 1);
            case KeyCode.Alpha9:
                return new Vector2(0.73f, 1);
            case KeyCode.Alpha0:
                return new Vector2(0.82f, 1);
            case KeyCode.Minus:
                return new Vector2(0.91f, 1);
            case KeyCode.Equals:
                return new Vector2(1, 1);
            case KeyCode.Q:
                return new Vector2(0, 0.67f);
            case KeyCode.W:
                return new Vector2(0.09f, 0.67f);
            case KeyCode.E:
                return new Vector2(0.18f, 0.67f);
            case KeyCode.R:
                return new Vector2(0.27f, 0.67f);
            case KeyCode.T:
                return new Vector2(0.36f, 0.67f);
            case KeyCode.Y:
                return new Vector2(0.45f, 0.67f);
            case KeyCode.U:
                return new Vector2(0.55f, 0.67f);
            case KeyCode.I:
                return new Vector2(0.64f, 0.67f);
            case KeyCode.O:
                return new Vector2(0.73f, 0.67f);
            case KeyCode.P:
                return new Vector2(0.82f, 0.67f);
            case KeyCode.LeftBracket:
                return new Vector2(0.91f, 0.67f);
            case KeyCode.RightBracket:
                return new Vector2(1, 0.67f);
            case KeyCode.A:
                return new Vector2(0, 0.33f);
            case KeyCode.S:
                return new Vector2(0.1f, 0.33f);
            case KeyCode.D:
                return new Vector2(0.2f, 0.33f);
            case KeyCode.F:
                return new Vector2(0.3f, 0.33f);
            case KeyCode.G:
                return new Vector2(0.4f, 0.33f);
            case KeyCode.H:
                return new Vector2(0.5f, 0.33f);
            case KeyCode.J:
                return new Vector2(0.6f, 0.33f);
            case KeyCode.K:
                return new Vector2(0.7f, 0.33f);
            case KeyCode.L:
                return new Vector2(0.8f, 0.33f);
            case KeyCode.Semicolon:
                return new Vector2(0.9f, 0.33f);
            case KeyCode.Quote:
                return new Vector2(1, 0.33f);
            case KeyCode.Z:
                return new Vector2(0, 0);
            case KeyCode.X:
                return new Vector2(0.11f, 0);
            case KeyCode.C:
                return new Vector2(0.22f, 0);
            case KeyCode.V:
                return new Vector2(0.33f, 0);
            case KeyCode.B:
                return new Vector2(0.44f, 0);
            case KeyCode.N:
                return new Vector2(0.56f, 0);
            case KeyCode.M:
                return new Vector2(0.67f, 0);
            case KeyCode.Comma:
                return new Vector2(0.78f, 0);
            case KeyCode.Period:
                return new Vector2(0.89f, 0);
            case KeyCode.Slash:
                return new Vector2(1, 0);

            default: return Vector2.zero;
        }
    }
}


public enum GameKeyCode
{
    /// <summary>
    ///   <para>The '0' key on the top of the alphanumeric keyboard.</para>
    /// </summary>
    Alpha0 = 48, // 0x00000030
    
    /// <summary>
    ///   <para>The '1' key on the top of the alphanumeric keyboard.</para>
    /// </summary>
    Alpha1 = 49, // 0x00000031

    /// <summary>
    ///   <para>The '2' key on the top of the alphanumeric keyboard.</para>
    /// </summary>
    Alpha2 = 50, // 0x00000032

    /// <summary>
    ///   <para>The '3' key on the top of the alphanumeric keyboard.</para>
    /// </summary>
    Alpha3 = 51, // 0x00000033

    /// <summary>
    ///   <para>The '4' key on the top of the alphanumeric keyboard.</para>
    /// </summary>
    Alpha4 = 52, // 0x00000034

    /// <summary>
    ///   <para>The '5' key on the top of the alphanumeric keyboard.</para>
    /// </summary>
    Alpha5 = 53, // 0x00000035

    /// <summary>
    ///   <para>The '6' key on the top of the alphanumeric keyboard.</para>
    /// </summary>
    Alpha6 = 54, // 0x00000036

    /// <summary>
    ///   <para>The '7' key on the top of the alphanumeric keyboard.</para>
    /// </summary>
    Alpha7 = 55, // 0x00000037

    /// <summary>
    ///   <para>The '8' key on the top of the alphanumeric keyboard.</para>
    /// </summary>
    Alpha8 = 56, // 0x00000038

    /// <summary>
    ///   <para>The '9' key on the top of the alphanumeric keyboard.</para>
    /// </summary>
    Alpha9 = 57, // 0x00000039
    
    /// <summary>
    ///   <para>'a' key.</para>
    /// </summary>
    A = 97, // 0x00000061
    
    /// <summary>
    ///   <para>'b' key.</para>
    /// </summary>
    B = 98, // 0x00000062

    /// <summary>
    ///   <para>'c' key.</para>
    /// </summary>
    C = 99, // 0x00000063

    /// <summary>
    ///   <para>'d' key.</para>
    /// </summary>
    D = 100, // 0x00000064

    /// <summary>
    ///   <para>'e' key.</para>
    /// </summary>
    E = 101, // 0x00000065

    /// <summary>
    ///   <para>'f' key.</para>
    /// </summary>
    F = 102, // 0x00000066

    /// <summary>
    ///   <para>'g' key.</para>
    /// </summary>
    G = 103, // 0x00000067

    /// <summary>
    ///   <para>'h' key.</para>
    /// </summary>
    H = 104, // 0x00000068

    /// <summary>
    ///   <para>'i' key.</para>
    /// </summary>
    I = 105, // 0x00000069

    /// <summary>
    ///   <para>'j' key.</para>
    /// </summary>
    J = 106, // 0x0000006A

    /// <summary>
    ///   <para>'k' key.</para>
    /// </summary>
    K = 107, // 0x0000006B

    /// <summary>
    ///   <para>'l' key.</para>
    /// </summary>
    L = 108, // 0x0000006C

    /// <summary>
    ///   <para>'m' key.</para>
    /// </summary>
    M = 109, // 0x0000006D

    /// <summary>
    ///   <para>'n' key.</para>
    /// </summary>
    N = 110, // 0x0000006E

    /// <summary>
    ///   <para>'o' key.</para>
    /// </summary>
    O = 111, // 0x0000006F

    /// <summary>
    ///   <para>'p' key.</para>
    /// </summary>
    P = 112, // 0x00000070

    /// <summary>
    ///   <para>'q' key.</para>
    /// </summary>
    Q = 113, // 0x00000071

    /// <summary>
    ///   <para>'r' key.</para>
    /// </summary>
    R = 114, // 0x00000072

    /// <summary>
    ///   <para>'s' key.</para>
    /// </summary>
    S = 115, // 0x00000073

    /// <summary>
    ///   <para>'t' key.</para>
    /// </summary>
    T = 116, // 0x00000074

    /// <summary>
    ///   <para>'u' key.</para>
    /// </summary>
    U = 117, // 0x00000075

    /// <summary>
    ///   <para>'v' key.</para>
    /// </summary>
    V = 118, // 0x00000076

    /// <summary>
    ///   <para>'w' key.</para>
    /// </summary>
    W = 119, // 0x00000077

    /// <summary>
    ///   <para>'x' key.</para>
    /// </summary>
    X = 120, // 0x00000078

    /// <summary>
    ///   <para>'y' key.</para>
    /// </summary>
    Y = 121, // 0x00000079

    /// <summary>
    ///   <para>'z' key.</para>
    /// </summary>
    Z = 122, // 0x0000007A
    
    /// <summary>
    ///   <para>Semicolon ';' key.</para>
    /// </summary>
    Semicolon = 59, // 0x0000003B
    
    /// <summary>
    ///   <para>Period '.' key.</para>
    /// </summary>
    Period = 46, // 0x0000002E
    
    /// <summary>
    ///   <para>Minus '-' key.</para>
    /// </summary>
    Comma = 44, // 0x0000002D
    
    /// <summary>
    ///   <para>Slash '/' key.</para>
    /// </summary>
    Slash = 47, // 0x0000002F
    
    /// <summary>
    ///   <para>Back quote key '`'.</para>
    /// </summary>
    Quote = 39, // 0x00000060
    
    /// <summary>
    ///   <para>Left square bracket key '['.</para>
    /// </summary>
    LeftBracket = 91, // 0x0000005B
    
    /// <summary>
    ///   <para>Right square bracket key ']'.</para>
    /// </summary>
    RightBracket = 93, // 0x0000005D
    
    /// <summary>
    ///   <para>Minus '-' key.</para>
    /// </summary>
    Minus = 45, // 0x0000002D
    
    /// <summary>
    ///   <para>Equals '=' key.</para>
    /// </summary>
    Equals = 61, // 0x0000003D
}