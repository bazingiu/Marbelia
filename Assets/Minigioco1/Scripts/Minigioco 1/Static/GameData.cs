using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    // Wave Manager
    public static float timeBetweenWaves = 5;
    public static float searchCountdown = 1f;

    // Mouse Look
    public static float mouseSensibility = 100f;

    // Player health
    public static int maxHealth = 100;

    // Player moovement
    public static float speed = 12f;
    public static float gravity = +9.81f;
    public static float jumpHeight = 3f;
    public static float groundDistance = 0.4f; 

    // Power-Up
    public static float duration = 10f;

    // Gun 
    public static float damage = 10f;
    public static float range = 100f; 
}

