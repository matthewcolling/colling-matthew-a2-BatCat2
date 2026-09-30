// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        private bool isBloodThirsty = false;
        private bool isAngry = false;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Project Bat-Cat");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground (0, 0, 0);
            // Mouse Click interaction to toggle Blood Thirsty state
            //Hitbox around the mouth area to toggle the Blood Thirsty state
            Vector2 mousePos = Input.GetMousePosition();
            if (Input.IsMouseButtonPressed(MouseButton.Left) && mousePos.X >= 170 && mousePos.X <= 230 && mousePos.Y >= 235 && mousePos.Y <= 285 && isBloodThirsty == false && isAngry == false)
            {

              if (isBloodThirsty == false && isAngry == false)
                {
                    isBloodThirsty = true; // Toggle the state
                }   

            }
            else if (Input.IsMouseButtonPressed(MouseButton.Left) && mousePos.X >= 170 && mousePos.X <= 230 && mousePos.Y >= 235 && mousePos.Y <= 285 && isBloodThirsty == true)
            {



                isBloodThirsty = false;// Toggle the state
                isAngry = true; // Set Angry state to true


            }
            else if (Input.IsMouseButtonPressed(MouseButton.Left) && mousePos.X >= 170 && mousePos.X <= 230 && mousePos.Y >= 235 && mousePos.Y <= 285 && isAngry == true)
            {
                isAngry = false; // Reset Angry state to false
            }  
        

            //---Draw Head and Ears (Black Bat-Cat Shape)---
            //Head fill and outline
            Draw.SetFillColor(30, 30, 30);
            Draw.SetLineColor(255, 255, 255);
            Draw.SetLineSize(3);

            //Pointed Ears (Flushly connected to head)
            //Left Ear
            Draw.Line(100, 120, 120, 50);
            Draw.Line(120, 50, 140, 120);

            //Right Ear
            Draw.Line(260, 120, 280, 50);
            Draw.Line(280, 50, 300, 120);

            //Head (matching black fur)
            Draw.Line(140, 120, 260, 120);  // Top Flat Head
            Draw.Line(100, 120, 100, 145);  // Left Upper Cheek
            Draw.Line(100, 145, 100, 215);  // Left Side
            Draw.Line(100, 215, 180, 280);  // Left jaw to chin
            Draw.Line(180, 280, 220, 280);  // Flat chin bottom
            Draw.Line(220, 280, 300, 215);  // Right jaw up
            Draw.Line(300, 215, 300, 145);  // Right Side
            Draw.Line(300, 145, 300, 120);  // Right Upper Cheek

            //---Draw Eyes (Red Eyes)---
            if (isBloodThirsty == true)
            {
                Draw.SetFillColor(255, 0, 0); // Red Eyes when Blood Thirsty
                Draw.SetLineColor(255, 255, 255);

                Draw.Triangle(140, 165, 180, 180, 140, 195); // Left Eye Fill
                Draw.Triangle(260, 165, 220, 180, 260, 195); // Right Eye Fill
            }
            else if (isAngry == true)
            {
                Draw.SetFillColor(255, 255, 0); // White Eyes when Angry
                Draw.SetLineColor(255, 255, 255);

                Draw.Triangle(140, 165, 180, 180, 140, 195); // Left Eye Fill
                Draw.Triangle(260, 165, 220, 180, 260, 195); // Right Eye Fill
            }
            else
            {
                Draw.SetFillColor(255, 255, 255); // White Eyes when Normal
                Draw.SetLineSize(3);
                Draw.Line(140, 175, 180, 175);
                Draw.Line(220, 175, 260, 175);
            }

            Draw.SetLineSize(5);
           

            // Mouth and Fangs
            Draw.SetLineColor(255, 255, 255);
            Draw.SetLineSize(3);

            if (isBloodThirsty == true)
            {
                // Blood Drops
                Draw.SetLineColor(255, 0, 0);
                Draw.Circle(188, 267, 4);
                Draw.Circle(212, 267, 4);

                // Longer Sharper Fangs
                Draw.Line(185, 250, 188, 265);
                Draw.Line(188, 265, 192, 250);

                Draw.Line(208, 250, 212, 265);
                Draw.Line(212, 265, 215, 250);
            }
            else
            {
                // Standard Small Fangs
                Draw.Line(185, 250, 188, 260);
                Draw.Line(188, 260, 192, 250);

                Draw.Line(208, 250, 212, 260);
                Draw.Line(212, 260, 215, 250);

               
            }
        }
    }

}
