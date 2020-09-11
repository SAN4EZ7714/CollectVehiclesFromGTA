using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using Rage.Native;

[assembly: Rage.Attributes.Plugin("RPHDemo", Description = "", Author = "")]


namespace GTA_V_pulgin
{
    public static class Class1
    {
        
        public static void Main()
        {
            Vector3 spawnPosition = Game.LocalPlayer.Character.GetOffsetPositionFront(7f);
            Vehicle vehicle = new Vehicle(spawnPosition);

            Camera.DeleteAllCameras();

            GameFiber.Sleep(1000);


            Camera CharacterDesignerCam = new Camera(false);
            CharacterDesignerCam.FOV = 60.0f;
            CharacterDesignerCam.Active = true;
            CharacterDesignerCam.PointAtEntity(vehicle, new Vector3(), false);


            
            //Camera CharacterDesignerCam = new Camera(false);

            //Nati

            //GameFiber.Sleep(5000);

            //CharacterDesignerCam.PointAtEntity(Game.LocalPlayer.Character, new Vector3(), false);
            //CharacterDesignerCam.Active = true;

            float angle = 0;
            float dist = 10;

            for (int i = 0; i < 10000; i++)
            {
                // Start a new fiber, that'll execute the HandleSuicideBomber method.
                //GameFiber.StartNew(Class1.HandleSuicideBomber);


                //NativeFunction.Natives.DrawLine(vehicle.FrontPosition.X, vehicle.FrontPosition.Y, vehicle.FrontPosition.Z, vehicle.FrontPosition.X, vehicle.FrontPosition.Y, vehicle.FrontPosition.Z + 2, 255, 0, 0, 255);
                //NativeFunction.Natives.DrawLine(vehicle.LeftPosition.X, vehicle.LeftPosition.Y, vehicle.LeftPosition.Z, vehicle.LeftPosition.X, vehicle.LeftPosition.Y, vehicle.LeftPosition.Z + 1, 255, 0, 0, 255);

                CharacterDesignerCam.Position = vehicle.Position + new Vector3((float)Math.Sin(angle) * dist, (float)Math.Cos(angle) * dist, 0.5f);
                angle += 0.01f;
                GameFiber.Yield();

                //NativeFunction.Natives.DrawCircle(Rage.World.ConvertWorldPositionToScreenPosition(vehicle.FrontPosition), 10.0f, 10, 255, 255);
                try
                {
                    Game.DisplaySubtitle(Rage.World.ConvertWorldPositionToScreenPosition(vehicle.FrontPosition).ToString());
                    Vector2 position= new Vector2(0, 0);

                    //Game.LogTrivial("Enabling Player Loop...");
                    float radius = 0;
                    Color color = Color.White;
                    //Rage.Graphics.DrawCircle(position, radius, color);
                }
                finally
                {

                }
            }

        }
    }
}