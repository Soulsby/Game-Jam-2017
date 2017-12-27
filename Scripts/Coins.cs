using UnityEngine;

public class Coins : Collectibles
{
    public const int BASE_SCORE = 100;

    public const int TIMER_VALUE = 30;

    public const int SCORE_MULT = 2;

    public float previousTimer=0;

    public new void add()
    {
        base.add();
        Timer();
    }
   public void Timer() {
        float timer = Time.time;

        float difference = timer - previousTimer;
        if (difference < TIMER_VALUE)
        {
            Player.control.addToScore(BASE_SCORE * SCORE_MULT);

        }
        else
        {
            Player.control.addToScore(BASE_SCORE);
        }
    }
}
