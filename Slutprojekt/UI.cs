class UI
{
        public void Draw()
        {

                Raylib.DrawRectangle(0, 0, 1280, 32, Color.DarkBrown);//top
                Raylib.DrawRectangle(0, 768, 1280, 32, Color.DarkBrown);//bottom
                Raylib.DrawRectangle(0, 0, 32, 800, Color.DarkBrown);//left
                Raylib.DrawRectangle(800, 0, 800, 800, Color.DarkBrown);//right

        }

}