namespace Bars
{
    class Frame
    {
        HorzBar h1, h2;
        VertBar v;
     
        public Frame(int width, int height)
        {
            h1 = new HorzBar(width);
            v = new VertBar(height);
            h2 = new HorzBar(width);
        }
    }
}