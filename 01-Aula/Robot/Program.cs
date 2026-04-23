using robot;

var robo = new Robot(new Caminhando());
for (int i = 0; i < 20; i++)
{
    robo.Agir();
}