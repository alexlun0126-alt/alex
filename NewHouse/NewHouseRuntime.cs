using UnityEngine;

namespace NewHouse;

internal static class NewHouseRuntime
{
    private static GameObject player;
    private static int shortFrame = -1;
    private static int normalFrame = -1;
    private static RaycastHit[] shortHits = new RaycastHit[0];
    private static RaycastHit[] normalHits = new RaycastHit[0];
    private static readonly RaycastHit[] emptyHits = new RaycastHit[0];

    internal static GameObject Player
    {
        get
        {
            if ((UnityEngine.Object)player == (UnityEngine.Object)null)
                player = GameObject.Find("PLAYER");
            return player;
        }
    }

    internal static RaycastHit[] GetMouseHits(float distance)
    {
        int frame = Time.frameCount;
        bool shortRange = distance <= 1.01f;
        if (shortRange)
        {
            if (shortFrame != frame)
            {
                shortFrame = frame;
                Camera camera = Camera.main;
                shortHits = camera != null
                    ? Physics.RaycastAll(camera.ScreenPointToRay(Input.mousePosition), 1f)
                    : emptyHits;
            }
            return shortHits;
        }

        if (normalFrame != frame)
        {
            normalFrame = frame;
            Camera camera = Camera.main;
            normalHits = camera != null
                ? Physics.RaycastAll(camera.ScreenPointToRay(Input.mousePosition), 1.5f)
                : emptyHits;
        }
        return normalHits;
    }
}
