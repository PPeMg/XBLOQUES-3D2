using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public static int lives = 3;
    public static int points = 0;

    public Text livesT;
    public Text pointsT;
    public Ball ball;
    public Player player;

	// Use this for initialization
	void Start ()
    {
        this.refreshLives();
        this.refreshPoints();
    }

    public void reduceLives()
    {
        lives--;
        player.Reset();
        ball.Reset();
        this.refreshLives();
    }

    public void addPoints()
    {
        points++;
        refreshPoints();
    }

    void refreshPoints()
    {
        pointsT.text = "Puntos: " + points;
    }

    void refreshLives()
    {
        livesT.text = "Vidas: " + lives;
    }

    public static int getLives()
    {
        return lives;
    }

    public static int getPoints()
    {
        return points;
    }
}
