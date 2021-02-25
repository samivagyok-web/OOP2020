namespace Bars
{
    // TODO
    /// <summary>
    /// +---+
    /// |
    /// |
    /// +---+
    /// |
    /// |
    /// +---+
    /// |
    /// |
    /// +---+
    /// </summary>
    class Ladder
    {
        public Ladder(int width, int heigth)
        {
            for (int i = 0; i < 3; i++)
            {
                new Frame(width, heigth / 3);
                new VertBar(1);
            }
            new HorzBar(width);
        }
    }
}