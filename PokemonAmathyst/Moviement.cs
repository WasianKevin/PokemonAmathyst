using System;
using Raylib_cs;
using System.Numerics;
public class Moviement
{
    //Movement
    public static (float, Texture2D) Movimint(float speed, Texture2D MaleImgS)
    {
        //Picture moves with character
        Vector2 Movement = MOOvement.ReadMovement(speed);

        // Pictures Male Character
        if (Movement.X > 0)
        {
            MaleImgS = Raylib.LoadTexture("MaleD.png");
        }
        else if (Movement.X < 0)
        {
            MaleImgS = Raylib.LoadTexture("MaleA.png");
        }
        if (Movement.Y > 0)
        {
            MaleImgS = Raylib.LoadTexture("MaleS.png");
        }
        else if (Movement.Y < 0)
        {
            MaleImgS = Raylib.LoadTexture("MaleW.png");
        }

        return(speed, MaleImgS);
    }

}
